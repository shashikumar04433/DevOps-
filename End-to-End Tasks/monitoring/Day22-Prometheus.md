### Prometheus 

sudo apt update
sudo apt upgrade -y

wget https://github.com/prometheus/prometheus/releases/download/v2.45.0/prometheus-2.45.0.linux-amd64.tar.gz

tar xvf prometheus-2.45.0.linux-amd64.tar.gz
cd prometheus-2.45.0.linux-amd64

* nano prometheus.yml
```
global:
  scrape_interval: 15s  # Default scrape interval

scrape_configs:
  - job_name: 'prometheus'
    static_configs:
      - targets: ['localhost:9090']
```
**Run Prometheus**
```
./prometheus --config.file=prometheus.yml
```
### Set Up Prometheus as a System Service
#### Step 1: Create a Prometheus User and Directory
```
sudo useradd --no-create-home --shell /bin/false prometheus
```
**Create directories for Prometheus configuration and data:**
```
sudo mkdir /etc/prometheus
sudo mkdir /var/lib/prometheus
```
**Change ownership of these directories:**
```
sudo chown prometheus:prometheus /etc/prometheus
sudo chown prometheus:prometheus /var/lib/prometheus
```

#### Step 2: Copy Prometheus Files
```
Copy the Prometheus binary to /usr/local/bin:
sudo cp prometheus /usr/local/bin/
sudo cp promtool /usr/local/bin/
```
```
Copy the configuration file to /etc/prometheus:
sudo cp prometheus.yml /etc/prometheus/
```
```
Change ownership of these files:
sudo chown prometheus:prometheus /usr/local/bin/prometheus
sudo chown prometheus:prometheus /usr/local/bin/promtool
sudo chown prometheus:prometheus /etc/prometheus/prometheus.yml
```
#### Step 3: Create a Systemd Service File
Create a service file for Prometheus:
```
sudo nano /etc/systemd/system/prometheus.service
```
```
[Unit]
Description=Prometheus Monitoring System
Documentation=https://prometheus.io/
After=network-online.target

[Service]
User=prometheus
Group=prometheus
ExecStart=/usr/local/bin/prometheus \
  --config.file /etc/prometheus/prometheus.yml \
  --storage.tsdb.path /var/lib/prometheus/
Restart=always

[Install]
WantedBy=multi-user.target
```
```
sudo systemctl daemon-reload
```
```
sudo systemctl start prometheus
```
```
sudo systemctl enable prometheus
```
```
sudo systemctl status prometheus
```
```
http://ip:9090
```