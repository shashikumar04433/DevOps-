## Multi-Stage DockerFile
```
FROM ubuntu as build
RUN apt-get update && apt-get install -y golang-go
ENV G0111MODULE = off
COPY . .
RUN CGO_ENABLED=0 go build -o /app .

##### Stage 2 #######
FROM Scratch
COPY --from=build /app/app
ENTRYPOINT["/app"]
```
