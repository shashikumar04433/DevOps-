### Ansible Roles
```
In an Ansible role, the following directories and files serve specific purposes:
```
1. README.md
```
Documentation file that describes the role's purpose, usage, and requirements.
```
2. defaults/
```
Contains default variables for the role.
These variables have the lowest priority and can be overridden by other variable sources.
Example: defaults/main.yml
```

3. handlers/
```
Stores task handlers, which are triggered by tasks when changes occur.
Handlers are only executed when notified by a task.
Example: handlers/main.yml
---
- name: Restart Nginx
  service:
    name: nginx
    state: restarted
```
4. meta/
```
Defines metadata about the role, including dependencies, author, and license.
Example: meta/main.yml
---
galaxy_info:
  author: your_name
  description: Installs and configures Java 11
  license: MIT
  min_ansible_version: 2.9
dependencies: []
```
5. tasks/
```
The core execution file that contains the sequence of tasks to be executed.
Example: tasks/main.yml
---
- name: Install Java 11
  apt:
    name: openjdk-11-jdk
    state: present
  notify: Restart Nginx
```
6. tests/
```
Contains test playbooks and configurations to validate the role.
Example: tests/test.yml

---
- hosts: localhost
  roles:
    - my_role
```
7. vars/
```
Stores variables with higher priority than defaults/.
These variables cannot be overridden easily.
Example: vars/main.yml
---
java_package: openjdk-11-jdk
```

**Overall Summary Table:**
```
Directory/File	Purpose
README.md	Role documentation
defaults/	Lowest-priority variables
handlers/	Defines handlers for tasks
meta/	Role metadata and dependencies
tasks/	Defines tasks for execution
tests/	Contains test playbooks
vars/	High-priority variables
```


**Creating a role manually or using the role from ansible-galaxy**
```
mkdir -p my_apache_role/{defaults,handlers,tasks,templates,files,meta,vars}
touch my_apache_role/{defaults,handlers,tasks,meta,vars}/main.yml
touch my_apache_role/README.md my_apache_role/files/index.html
```
(or)
```
ansible-galaxy init my_apache_role
Then create a tasks and all the required with the data.
```
**defaults/main.yml**
```
---
apache_package: apache2
index_html_src: index.html
index_html_dest: /var/www/html/index.html
```
**tasks/main.yml**
```
---
- name: Install Apache if not present
  apt:
    name: "{{ apache_package }}"
    state: present
  notify: Get Apache Version

- name: Display Apache Version
  command: apache2 -v
  register: apache_version
  changed_when: false

- name: Print Apache Version
  debug:
    msg: "{{ apache_version.stdout }}"

- name: Copy index.html to /var/www/html
  copy:
    src: "{{ index_html_src }}"
    dest: "{{ index_html_dest }}"
    owner: www-data
    group: www-data
    mode: '0644'
  notify: Restart Apache
```
**handlers/main.yml**
```
---
- name: Get Apache Version
  command: apache2 -v
  listen: Get Apache Version
  register: apache_version

- name: Restart Apache
  service:
    name: apache2
    state: restarted
  listen: Restart Apache
```
**files/index.html**
```
<!DOCTYPE html>
<html>
<head>
    <title>Welcome</title>
</head>
<body>
    <h1>Hello from Apache Server!</h1>
</body>
</html>
```
**Use the Role in a Playbook (site.yml) (It should be outside of this folder where inventory.ini is there)**
```
---
- hosts: all
  become: true
  roles:
    - my_apache_role
```
**This is a basic example of how you can create a role in Ansible to manage Apache.**
```
ansible-playbook -i inventory.ini site.yml
```
