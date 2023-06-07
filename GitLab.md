# GitLab

  ## Create the Gitlab Account on Ubuntu using below command:
                https://caffeinedev.medium.com/how-to-setup-and-configure-your-own-gitlab-server-on-ubuntu-20-04-73214cf63882
  
                      Step 1:
                            sudo apt update
                            apt upgrade
                            sudo apt-get install -y curl openssh-server ca-certificates
                            (if u get problem for above command then try below and then try)
                            sudo dpkg --configure -a
                      Step 2:   
                            sudo apt-get install -y postfix
                            systemctl reload postfix
                            systemctl status postfix
                      Step 3:
                            curl -sS https://packages.gitlab.com/install/repositories/gitlab/gitlab-ce/script.deb.sh | sudo bash
                            sudo EXTERNAL_URL="http://private ip" apt-get install gitlab-ce
                            (or)
                            sudo apt-get install gitlab-ce
                      Step 4:
                            sudo gitlab-rake "gitlab:password:reset"
                            present username: username (eg: root)
                            then set passwd 
                
 ### Create the Gitlab Account on Redhat using below command:
                    https://medium.com/devops-world/installing-gitlab-on-centos7-8d4230cb145a (link for steps of installtion)
                     Step 1: 
                            yum -y install postfix  (Postfix is an email service tool or Mail Transfer Agent)
                            systemctl start postfix
                            systemctl enable postfix
                     Step 2:
                            yum -y install curl openssh-server cronie
                            curl https://packages.gitlab.com/install/repositories/gitlab/gitlab-ce/script.rpm.sh |bash
                     Step 3:
                            yum install gitlab-ce
                     
                     Step 4:
                            cd /etc/gitlab/
                            vi gitlab.rb
                            edit the <make it changes as ur ip (https://privateip) >
                            sudo gitlab-rake "gitlab:password:reset"
                            root username
                            setpasswd
                            sudo gitlab-ctl reconfigure
                            (bye)
                         

                            

                            

                     
       
              
