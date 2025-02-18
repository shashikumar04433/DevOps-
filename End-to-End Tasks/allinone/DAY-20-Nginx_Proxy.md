1. What is Proxy /Reverse Proxy and Forward Proxy.

2. Deploy the sample python application using flask (add simple apis)
   / , /home /login

 3. Deploy the application using NGINX as a reverse proxy and if you got 404 error then it should show or redirect to error.html page.

 4. How can u set up nginx as load balancer.

 5. accesslogs , error logs .

 6. Refresh nginx configuration without using restart use (nginx -t).

 7. nginx vs apache.

 8. Five different interview question of nginx not as per above.



**proxy**
```
A proxy is an intermediary server that acts as a gateway between a client (such as a web browser) and another server 
```

 **Forward Proxy**
 ```
 A forward proxy is a server that sits between a client and the internet, forwarding client requests to the internet on behalf of the client.

 Forward Proxy: Client → Nginx (forward proxy) → Internet
 Forward Proxy: Hides the client from the internet.

 ```
 **Reverse Proxy**
 ```
  A reverse proxy is a server that sits in front of web servers and forwards client requests (usually from the internet) to those web servers. It hides the identity of the backend servers and presents itself as the actual server to the clients.

  Reverse Proxy: Client → Nginx (reverse proxy) → Backend Servers
  Reverse Proxy: Hides the backend servers from the client.
  ```


## 2. Deploy the sample python application using flask (add simple apis) / , /home /login
```
    * apt install python3.12-venv
    * source venv/bin/activate
    * pip install Flask
    * touch app.py
```
```
app = Flask(__name__)

@app.route('/')
def index():
    return jsonify(message="Hey this is the Home Page")

@app.route('/home')
def home():
    return jsonify(message="This is the Home Page")

@app.route('/login')
def login():
    return jsonify(message="This is the Login Page")

if __name__ == '__main__':
    app.run(host='0.0.0.0', port=5000)
```

```
* vi /etc/nginx/sites-available/flask_app
* ln -s /etc/nginx/sites-available/flask_app /etc/nginx/sites-enabled/
* nginx -t
```


## 3. Deploy the application using NGINX as a reverse proxy and if you got 404 error then it should show or redirect to error.html page.

```
server {
    listen 80;
    server_name 3.108.217.93;

    location / {
        proxy_pass http://127.0.0.1:5000;
        proxy_set_header Host $host;
        proxy_set_header X-Real-IP $remote_addr;
        proxy_set_header X-Forwarded-For $proxy_add_x_forwarded_for;
        proxy_set_header X-Forwarded-Proto $scheme;
        try_files $uri $uri/ =404;  # Handle 404 within this block
    }

    error_page 404 /error.html;
    location = /error.html {
        root /usr/share/nginx/html;
        internal;
    }
}
```
## 4. How can u set up nginx as load balancer.
```
 replace with the server names
upstream my_app {
    # Define your backend servers
    server 192.168.1.100:5000;
    server 192.168.1.101:5000;
    server 192.168.1.102:5000;
}
```

## 5. Default path of access logs and error logs in nginx
  ```
  access logs  --->/var/log/nginx/access.log
  error logs   --->/var/log/nginx/error.log
  ```

## 6. Refresh nginx configuration without using restart (nginx -t)
```
* nginx -t

or also 

* systemctl reload nginx (with out restarting nginx)
```

## 7. Difference Between Apache and Nginx.
  ```

    Apache is versatile and feature-rich, suitable for complex configurations and dynamic content.
    Nginx is efficient and fast, ideal for high-traffic scenarios and serving static content.

  ```