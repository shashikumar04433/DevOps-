## How to write the DockerFile .

### Pillars of Docker image :
```
1. FROM 
2. ADD
3. RUN 
4. CMD 
5. ENTRYPOINT 
6. ENV  
7. MAINTAINER
8. COPY
9. EXPOSE
10.LABEL
11.VOLUME
12.USER
13.ARG
14.HEALTH
14.WORKDIR
```

 **FROM**
 ```
  * Specifies the base image for your Docker image. It's the starting point for your image.
  * Example: FROM ubuntu:18.04
```

 **ADD**
 ```
  * Copy the current directory contents into the container at /app
  * ADD . /app
 ```

 **RUN**
 ```
  * Executes commands during the build process. These commands are run in a new layer on top of the current image.
  * Example: RUN apt-get update && apt-get install -y package-name
 ```

 **CMD**
 ```
  * Provides default values for the ENTRYPOINT instruction. These values are used when the container is run without specifying a command.
  * Example: CMD ["executable", "param1", "param2"]
 ```

 **ENTRYPOINT**
 ```
  * Configures the container to run as an executable. It allows you to set a default application to run when the container starts.
  * Example: ENTRYPOINT ["executable", "param1", "param2"]
 ```

 **ENV**
 ```
  * Sets environment variables in the image. These variables persist when a container is run from the image.
  * Example: ENV MY_VAR=value
  ```

 **MAINTAINER**
 ```
  * Its a Keyword and just mention with the email id.
  * Example: shashi.reddy@gmail.com
 ```

 **COPY**
 ```
  * Copies files or directories from the build context (the local filesystem where the docker build command is run) into the image.
  * Example: COPY . /app
 ```

 **EXPOSE**
 ```
  * Informs Docker that the container listens on the specified network ports at runtime.
  * Example: EXPOSE 80
 ```

 **LABEL**
 ```
  * Adds metadata to the image in the form of key-value pairs.
  * Example: LABEL version="1.0" maintainer="yourname@example.com"
 ```

 **VOLUME**
 ```
  * Creates a mount point and/or assigns a volume to the container. Used for persisting data outside the container.
  * Example: VOLUME /data
 ```

 **USER**
 ```
  * Sets the user or UID to use when running the image.
  * Example: USER username
 ```

 **ARG**
 ```
  * Defines variables that users can pass at build-time to the builder with the docker build command.
  * Example: ARG version=latest
 ```

 **HEALTH**
 ```
  * Tells Docker how to test a container to check that it is still working.
  * Example: HEALTHCHECK CMD curl --fail http://localhost/ || exit 1
 ```

 **WORKDIR**
 ```
  * Sets the working directory for any RUN, CMD, ENTRYPOINT, COPY, and ADD instructions that follow it.
  * Example: WORKDIR /app
 ```

**FROM SCRATCH**
```
  * Indicates that the image will be built from scratch, with no pre-existing layers.
  * Example: FROM scratch
```

 **Docker Volume**
 ```
    Docker volume is used to persist and store the data .Volumes provide a way to share data between Docker containers, and they are also used to persist data even if the associated container is removed or replaced.

    * Docker Volume create <volume name>
    * Docker run -d --name name_of_the_volume -v volume:/path
    * docker volume ls
 ```
 
 
 
 

 
