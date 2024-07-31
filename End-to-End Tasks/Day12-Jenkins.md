### Jenkins

#### Installation steps of jenkins on ubuntu.

Step1:
```
      sudo apt update
      sudo apt install openjdk-11-jdk -y
```
Step2:
```
      curl -fsSL https://pkg.jenkins.io/debian-stable/jenkins.io-2023.key | sudo tee \
/usr/share/keyrings/jenkins-keyring.asc > /dev/null
echo deb [signed-by=/usr/share/keyrings/jenkins-keyring.asc] \
https://pkg.jenkins.io/debian-stable binary/ | sudo tee \
/etc/apt/sources.list.d/jenkins.list > /dev/null
```
Step3:
```
      sudo apt update
      sudo apt install jenkins -y
```
```
Then hit the url:
http://ip:8080
to access the jenkin page & go back to terminal and paste 
cat /var/lib/jenkins/secrets/initialAdminPassword
to set the password and login into jenkins successfully
```

 ### Types of Jobs in Jenkins:

**Freestyle Project:**
```
Freestyle project is based on ui .
Simple, quick setup, good for basic tasks.
Best for: Small projects, simple builds, or quick automation needs.
Disadvantage:Limited flexibility, harder to manage complex workflows.
```

**Pipeline:**
```
Pipelines are code based .
Highly flexible, can handle complex workflows, versioned as code.
Best for: Complex CI/CD workflows, large projects, and teams needing detailed build automation.
Cons: Requires knowledge of Groovy, initial setup can be more complex.
```

**Multi-configuration-Project**
```
    It is used to test the project on multiple environment

```
**Multibranch Pipeline**
```
A special type of pipeline job that automatically creates a pipeline for each branch in a source code repository.
```

**The main features of jenkins are:**
```
1. Continuous Integration and Continuous Delivery - extensible automation server, Jenkins can be used as a simple CI server or turned into the continuous delivery hub for any project. 

2. Easy installation -jenkins is easy to install

3. Easy configuration - easy configuration using the ui.

4. Plugins - It has hundreds of pulgins to update the center of jenkins

5. distributed - Jenkins can easily distribute work across multiple machines, helping drive builds, tests and deployments across multiple platforms faster.
```

#### Parameters:
**String based parameter**
```
A simple text field
eg:
jenkins_version="1.2.3"
```
**Boolean parameter**
```
 A checkbox that represents a true/false value.
 eg:
 PARAM_DEBUG = true
```
**Choice parameter**
```
A dropdown menu with predefined options.
eg:
environment="devlopment"
```
**Password Parameter**
```
A secure text field for sensitive information.
eg:
password="******"
```
**File Parameter**
```
allow uploading a file to be used in the build 
eg:
fath_path=/opt/path
```
**Run Parameter**
```
Select a specific run of a job.
eg:
run_job=1
```



### Types of Builds in Jenkin
**1. Freestyle Build:**
```
    A basic and simple type of build that can be configured with multiple build steps and post build steps.
```
**2. Maven Build**
```
    A build type that is used for building the java projects using apache maven .Jenkins integrates the maven to execute goals and build lifecycle phases.
```
**3. Ant Build**
```
    It is specially designed to build the java projects using apache ant.
```
**4. Jenkinsfile Build**
```
    Jenkins Pipeline defined in a jenkinsfile which stores the project source code repository.The jenkins file defines the stages and steps of the application.
```

**5. Multi-branch Pipeline Build**
```
Automatically creates and manages the pipelines for the multiple branches in scr(source code repository)
```

**.6 Jenkinsfile Build with Parameters**
```
A pipeline that is defined in a jenkinsfile allowing the users to input values while triggering the build.
```

**7. Jenkinsfile Build with Parameters and Environment Variables**
```
A pipeline that is defined in a jenkinsfile with parameters and environment variables.
```



**Pipeline to deploy the docker image into docker hub**

```
pipeline {
    environment {
        imagename = "shashikumar023/jenkinss"
        dockerImage = ''
        containerName = 'my-container'
        dockerHubCredentials = 'dockerdetais'
        dockerImageTag = "${imagename}:${env.BUILD_NUMBER}"
    }

    agent any

    stages {
        stage('Cloning Git') {
            steps {
                git(url: 'https://github.com/shashikumar04433/Jenkins_with_Docker.git', branch: 'main')
            }
        }

        stage('Building image') {
            steps {
                script {
                    dockerImageTag = "${imagename}:${env.BUILD_NUMBER}"
                    dockerImage = docker.build dockerImageTag
                }
            }
        }

        stage('Running image') {
            steps {
                script {
                    sh "docker run -d --name ${containerName} ${dockerImageTag}"
                    // Perform any additional steps needed while the container is running
                }
            }
        }

        stage('Stop and Remove Container') {
            steps {
                script {
                    sh "docker stop ${containerName} || true"
                    sh "docker rm ${containerName} || true"
                }
            }
        }

        stage('Deploy Image') {
            steps {
                script {
                    withCredentials([usernamePassword(credentialsId: dockerHubCredentials, usernameVariable: 'DOCKER_USERNAME', passwordVariable: 'DOCKER_PASSWORD')]) {
                        sh "docker login -u $DOCKER_USERNAME -p $DOCKER_PASSWORD"
                        sh "docker push ${dockerImageTag}"
                    }
                }
            }
        }

       
            }
        }
    }
}

```
