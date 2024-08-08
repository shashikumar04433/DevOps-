
### Ansible:
Ansible is a configuration management tool that automates the deployment and management of IT resources. 

**Pre-Requisites**
----------------
On both Control node and manage node
- Python 2.7 or 3.5 and above installed on your system.
- Ansible installed on only control node.

**Feattures of Ansible are:**
Ansible is agent less.
Ansible playbooks are written in .yaml files.
Ansible is platform indepentent.

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
* Create a inventory file in 
* vi /etc/inventory.ini
* insert the ips which u want to connect.
* ansible -i inventory.ini -m ping all
* ansible -i inventory.ini -m shell -a "apt install -y vim net-tools" all

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


### Fourth Task

**Write a 5 plays with specific condition when ever the os is redhat tomcat should be installed and when ever its ubuntu then nginx should install using block keyword.**

```
---
- name: Execute tasks based on OS type
  hosts: all
  become: yes

  tasks:
    - name: Detect OS type
      set_fact:
        is_redhat: "{{ ansible_os_family == 'RedHat' }}"
        is_ubuntu: "{{ ansible_os_family == 'Debian' }}"

    - name: Execute RedHat specific commands
      block:
        - name: Install httpd
          yum:
            name: httpd
            state: present
        - name: Start httpd
          service:
            name: httpd
            state: started
            enabled: yes
        - name: Install Java
          yum:
            name: java-1.8.0-openjdk
            state: present
        - name: Create Tomcat user
          user:
            name: tomcat
        - name: Install Tomcat
          yum:
            name: tomcat
            state: present
      when: is_redhat

    - name: Execute Ubuntu specific commands
      block:
        - name: Update apt cache
          apt:
            update_cache: yes
        - name: Install nginx
          apt:
            name: nginx
            state: present
        - name: Start nginx
          service:
            name: nginx
            state: started
            enabled: yes
        - name: Install Java
          apt:
            name: openjdk-8-jdk
            state: present
        - name: Create Nginx user
          user:
            name: nginx
      when: is_ubuntu

    - name: Install web server based on OS
      block:
        - name: Install Tomcat on RedHat
          yum:
            name: tomcat
            state: present
          when: ansible_os_family == "RedHat"

        - name: Install Nginx on Ubuntu
          apt:
            name: nginx
            state: present
          when: ansible_os_family == "Debian"
```
```
This playbook uses the `when` keyword to conditionally execute different blocks of tasks based on the OS
family. The `is_redhat` and `is_ubuntu` variables are used to determine whether
the current OS is RedHat or Ubuntu. The `block` keyword is used to group related tasks
together. The `yum` and `apt` modules are used to install packages on RedHat
and Ubuntu respectively. The `service` module is used to start and enable the nginx service on Ubuntu.
```

### Fifth Task

**I want to single play out of 10 plays using the tag names:**
```
---
- name: Update apt cache
  hosts: all
  become: yes
  tags: update_cache
  tasks:
    - name: Update apt cache
      apt:
        update_cache: yes

- name: Install Nginx
  hosts: all
  become: yes
  tags: install_nginx
  tasks:
    - name: Install Nginx
      apt:
        name: nginx
        state: present

- name: Start Nginx Service
  hosts: all
  become: yes
  tags: start_nginx
  tasks:
    - name: Ensure Nginx is running
      service:
        name: nginx
        state: started
        enabled: yes

- name: Install OpenJDK
  hosts: all
  become: yes
  tags: install_java
  tasks:
    - name: Install OpenJDK 11
      apt:
        name: openjdk-11-jdk
        state: present

- name: Create a User
  hosts: all
  become: yes
  tags: create_user
  tasks:
    - name: Create a new user
      user:
        name: newuser
        state: present
        shell: /bin/bash
```

### Sixth Task

**How to make child groups & variables to the specific group for inventory file**
```
# inventory file

[app]

3.110.33.20


[db]
13.233.108.87


# inventory.ini
# [webservers]
#web1
#web2

#[dbservers]
#db1
#db2

#[development:children]
#webservers
#dbservers

#[production:children]
#webservers

#[development:vars]
#env=dev
#db_host=dev-db.example.com

#[production:vars]
#env=prod
#db_host=prod-db.example.com

#[webservers:vars]
#http_port=80
#server_name=example.com

#[dbservers:vars]
#db_port=3306
```

### Seventh Task:

**Variable Presidence in Ansible**
```
1.Command Line Values
2.Playbook Variables
3.Role Variables (vars/main.yml)
4.Role Defaults (defaults/main.yml)
5.Inventory Variables
6.Host Variables
7.Group Variables
8.Facts
9.Playbook Vars Files
10.Extra Vars
```

### Types of modules with the examples:

**Ping**
```
- name : ping the host
  ansible.package.ping


```
**Command**
```
- name: run a command
  ansible.builtin.command:
  cmd: ls -ltr

```
**shell**
```
- name: run a shell command
ansible.builtin.shell: 
echo "hey world"
```
**Copy**
```
- name :copy a file
ansible.builtin.copy:
src: /path/src
dest: /path/dest
```

**file**
```
- name : copy a file
ansible.builtin.file:
path:/local/path
state: directory or file
mode: '0755'

```
**templete**
```
- name : write a templete
ansible.builtin.templete:
src /path/file
dest /path/dest
```

**Yum**
```
- name: Install a package with yum
  ansible.builtin.yum:
    name: httpd
    state: present
```









### Ansible inteview questions:

**1. What is Ansible and how does it work?**
```
Answer: Ansible is an open-source automation tool that uses SSH to manage configurations, deployments, and orchestrations via playbooks written in YAML.
```
**2. What are Playbooks in Ansible?**
```
Answer: Playbooks are YAML files that define a series of tasks for Ansible to execute on specified hosts.
```
**3. Explain the difference between a task and a handler in Ansible.**
```
Answer: Tasks are actions executed sequentially in a playbook, while handlers are triggered by tasks and run once at the end if notified.
```

**4. What is an inventory file in Ansible?**
```
Answer: An inventory file lists the hosts and groups of hosts that Ansible manages, including their IPs and variables.
```

**5. How do you secure sensitive data in Ansible?**
```
Answer: Use Ansible Vault to encrypt sensitive data such as files, strings, or variables.
```

**6. What are roles in Ansible?**
```
Answer: Roles are a way to organize tasks, handlers, files, templates, and variables in a reusable and modular structure.
```

**7. How can you execute a single Ansible task on multiple hosts?**
```
Answer: Use the ansible ad-hoc command, e.g., ansible all -m command -a "uptime".
```

**8. What is the purpose of the ansible.cfg file?**
```
Answer: The ansible.cfg file sets default configurations for Ansible, such as inventory location and SSH settings.
```

**9. How do you handle dynamic inventory in Ansible?**
```
Answer: Use scripts or plugins to generate inventory dynamically, configured via ansible.cfg or the -i option.
```

**10. What is Ansible Galaxy and how do you use it?**
```
Answer: Ansible Galaxy is a repository for sharing and downloading Ansible roles, which can be installed with ansible-galaxy install <role_name>.
```
