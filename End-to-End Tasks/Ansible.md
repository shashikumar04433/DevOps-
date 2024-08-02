
### Ansible:
```
Ansible is a configuration management tool that automates the deployment and management of IT resources. 
```
**Pre-Requisites**
```
----------------
On both Control node and manage node
- Python 2.7 or 3.5 and above installed on your system.
- Ansible installed on only control node.
```
**Feattures of Ansible are:**
```
Ansible is agent less.
Ansible playbooks are written in .yaml files.
Ansible is platform indepentent.
```
### What can you do with Ansible
```
* You can create Provising or infrastructure (same like terraform)
* Configuration management can be done.
* Automate Ci/cd can be done using ansible.
* You can automate the network configuration as well.
```

### How can you set up the Control Node and the Manage Node

**Pre-requirements are:**
```
* Make sure that python installed in all servers
* Make sure that Ansible installed in control node only
* Make password less authentication for all the server to do that follow below steps.
```
```
1.  ssh-keygen (first in control or master node)
2.  go to ~/.ssh and copy the .pub id 
3. then log in to the manage node or slave node and do ssh-keygen there too.
4. then paste the copied control node pub content in authorized keys in manage node or slave node.
5. then go to /etc /ssh
6. vi ssh_config file and uncomment the password yes one.
7. then restart the manage node with bewlow command 
   <systemctl restart ssh>  same setup should be done in all then manage nodes
```

### To ping the servers with ips:
```
* Create a inventory file in 
* vi /etc/inventory.ini
* insert the ips which u want to connect.
* ansible -i inventory.ini -m ping all
* ansible -i inventory.ini -m shell -a "apt install -y vim net-tools" all
```
### If u want to create the groups 
```
* vi /etc/inventory.ini
group1
<ip1>
group2
<ip2>
* ansible -i inventory.ini -m  group1
* ansible -i inventory.ini -m shell -a "sudo ls /home/ubuntu" group1 group2
```

### Basic Structure of Yaml file :

```
--- (always starts with 3 highpens)
name: 'shashi' --->string
age: 25 ---> integer
male: True -->Boolean

list:
  - item1
  - item2
  - item3  (list always comes with 2 spaces )

address:
street: 'xyz'
city: 'abc'
country: 'india' (dictory comes with the key value pair)

```

### Ubuntu modules yaml file reference on below link:
```
https://docs.ansible.com/ansible/latest/modules/ubuntu_module.html

https://docs.ansible.com/ansible/latest/collections/ansible/builtin/apt_module.html#ansible-collections-ansible-builtin-apt-module
```

### Playbook Script of Ansible:

```
eg:
---
- hosts: all
  become: true
  tasks:
    - name: Install apache httpd
      ansible.builtin.apt:
        name: apache2
        state: present
        update_cache: yes
    - name: Copy file with owner and permissions
      ansible.builtin.copy:
        src: index.html
        dest: /var/www/html
        owner: root
        group: root
        mode: '0644'
```
**To run the playbook the command is:**
```
ansible-playbook -i <inventory file path> playbook.yaml path
eg:
ansible-playbook -i inventory.ini firstplaybook.yaml
```

### Tasks:
1.Install wget zip unzip telnet as a playbook on remote
```
---
- name: Install required packages on Ubuntu
  hosts: all
  become: yes

  tasks:
    - name: Install wget
      apt:
        name: 
        - wget
        - zip
        - unzip
        - telnet
        - net-tools
        state: present

        state: present

```
```
ansible-playbook -i inventory.ini playbookname
```
## Second Task
**Create a user called "shashi" set password allow password authentication and attach "shashi user to wheel or sudo group with the ansible playbook"**
```
apt install pipx
pipx install passlib
sudo apt update
```
```
---
- name: Create user and configure sudo privileges
  hosts: all
  become: yes

  tasks:
    - name: Create user 'shashi'
      user:
        name: shashi
        password: "{{ 'shashi' | password_hash('sha512', 'passlib') }}"
        state: present

    - name: Ensure 'shashi' is in the sudo group
      user:
        name: shashi
        groups: shashi
        append: yes

    - name: Allow password authentication
      lineinfile:
        path: /etc/ssh/sshd_config
        regexp: '^PasswordAuthentication'
        line: 'PasswordAuthentication yes'
        state: present
      notify: Restart SSH

  handlers:
    - name: Restart SSH
      service:
        name: ssh
        state: restarted
```

### Third Task:

**Install apache2 server in all slave nodes then when ever index.html has changed automatically it should reflect in all machines**
```
---
- name: Install Apache and deploy index file
  hosts: all
  become: yes

  tasks:
    - name: Update the apt package index
      apt:
        update_cache: yes

    - name: Install Apache
      apt:
        name: apache2
        state: present

    - name: Deploy index.html to Apache document root
      copy:
        src: index.html
        dest: /var/www/html/index.html
        owner: root
        group: root
        mode: '0644'
      notify:
        - Restart Apache

  handlers:
    - name: Restart Apache
      service:
        name: apache2
        state: restarted
```




