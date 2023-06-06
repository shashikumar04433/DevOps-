# GitLab

  ## Create the Gitlab Account on Ubuntu using below command:
  https://caffeinedev.medium.com/how-to-setup-and-configure-your-own-gitlab-server-on-ubuntu-20-04-73214cf63882
  
Step 1:
      sudo apt update
      apt upgrade
      sudo apt-get install -y curl openssh-server ca-certificates
Step 2:   
      sudo apt-get install -y postfix
      systemctl reload postfix
      systemctl status postfix
Step 3:
      curl -sS https://packages.gitlab.com/install/repositories/gitlab/gitlab-             ce/script.deb.sh | sudo bash
      sudo EXTERNAL_URL="http://gitlabce.example.com" apt-get install gitlab-ce
      (or)
      sudo apt-get install gitlab-ce
Step 4:
      sudo gitlab-rake "gitlab:password:reset"
      present username: username (eg: root)
      then set passwd 
                
                T
       
              
