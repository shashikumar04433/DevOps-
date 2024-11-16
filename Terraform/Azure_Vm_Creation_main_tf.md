provider "azurerm" {
  features {}

  subscription_id = "XXXXXXXXXXXXXXXXXXXX"
  client_id       = "XXXXXXXXXXXXXXXXXXXX"
  client_secret   = "XXXXXXXXXXXXXXXXXXXX"
  tenant_id       = "XXXXXXXXXXXXXXXXXXXX"
}

# Create a Resource Group
resource "azurerm_resource_group" "Dev-rg" {
  name     = "Dev-rg"
  location = "West Europe"
}

# Create a Virtual Network
resource "azurerm_virtual_network" "Dev_vnet" {
  name                = "Vnet_for_dev"
  address_space       = ["10.0.0.0/16"]
  location            = azurerm_resource_group.Dev-rg.location
  resource_group_name = azurerm_resource_group.Dev-rg.name
}

# Create a Subnet
resource "azurerm_subnet" "Dev_subnet" {
  name                 = "Dev-subnet"
  resource_group_name  = azurerm_resource_group.Dev-rg.name
  virtual_network_name = azurerm_virtual_network.Dev_vnet.name
  address_prefixes     = ["10.0.1.0/24"]
}

# Create a Public IP with Static Allocation
resource "azurerm_public_ip" "Dev_pip" {
  name                = "Dev-pip"
  location            = azurerm_resource_group.Dev-rg.location
  resource_group_name = azurerm_resource_group.Dev-rg.name
  allocation_method   = "Static"
  sku                 = "Standard"
}

# Create a Network Interface
resource "azurerm_network_interface" "Dev_nic" {
  name                = "Dev-nic"
  location            = azurerm_resource_group.Dev-rg.location
  resource_group_name = azurerm_resource_group.Dev-rg.name

  ip_configuration {
    name                          = "internal"
    subnet_id                     = azurerm_subnet.Dev_subnet.id
    private_ip_address_allocation = "Dynamic"
    public_ip_address_id          = azurerm_public_ip.Dev_pip.id
  }
}

# Create a Network Security Group (NSG) allowing RDP on port 3389
resource "azurerm_network_security_group" "Dev_nsg" {
  name                = "Dev-nsg"
  location            = azurerm_resource_group.Dev-rg.location
  resource_group_name = azurerm_resource_group.Dev-rg.name

  security_rule {
    name                       = "RDP-allow"
    priority                   = 100
    direction                  = "Inbound"
    access                     = "Allow"
    protocol                   = "Tcp"
    source_port_range          = "*"
    destination_port_range     = "3389"
    source_address_prefix      = "*"
    destination_address_prefix = "*"
  }
}

# Associate the NSG to the network interface
resource "azurerm_network_interface_security_group_association" "Dev_nic_nsg_association" {
  network_interface_id      = azurerm_network_interface.Dev_nic.id
  network_security_group_id = azurerm_network_security_group.Dev_nsg.id
}

# Create a Virtual Machine
resource "azurerm_windows_virtual_machine" "Dev_vm" {
  name                  = "Dev-vm"
  resource_group_name   = azurerm_resource_group.Dev-rg.name
  location              = azurerm_resource_group.Dev-rg.location
  size                  = "Standard_DS1_v2"
  admin_username        = var.admin_username
  admin_password        = var.admin_password
  network_interface_ids = [azurerm_network_interface.Dev_nic.id]
  
  os_disk {
    caching              = "ReadWrite"
    storage_account_type = "Standard_LRS"
  }
  
  source_image_reference {
    publisher = "MicrosoftWindowsServer"
    offer     = "WindowsServer"
    sku       = "2019-Datacenter"
    version   = "latest"
  }

  tags = {
    environment = "testing"
  }
}
