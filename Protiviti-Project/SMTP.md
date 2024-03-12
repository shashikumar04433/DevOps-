# SMTP Email Notification in Two methods:

**Method1**
```
curl --url 'smtps://smtp.gmail.com:465' --ssl-reqd \
  --mail-from 'uxxxxxxxx@gmail.com' \
  --mail-rcpt 'sxxxxxxxxxxxx@gmail.com' \
  --user 'xxxxxxxxxxxxxxxx.com:pnmhxysmdigqjxyd' \
  -T <(echo -e 'From: xxxxxxxxx085@gmail.com\nTo: xxxxxxxxxx04433@gmail.com\nSubject: Curl Test\n\nHello')

```
**SMTP Email Notification with Attched files**
```
#!/bin/bash

# Define the attachment file and the MIME boundary
attachment_path="/path/to/your/attachment.txt"
filename="attachment.txt"
mime_boundary="=====MIME_BOUNDARY====="

# Create the MIME message
{
    echo "From: utsavsingh085@gmail.com"
    echo "To: shashikumar04433@gmail.com"
    echo "Subject: Curl Test"
    echo "MIME-Version: 1.0"
    echo "Content-Type: multipart/mixed; boundary=\"$mime_boundary\""
    echo ""
    echo "--$mime_boundary"
    echo "Content-Type: text/plain"
    echo ""
    echo "Hello"
    echo ""
    echo "--$mime_boundary"
    echo "Content-Type: application/octet-stream"
    echo "Content-Disposition: attachment; filename=\"$filename\""
    echo "Content-Transfer-Encoding: base64"
    echo ""
    base64 "$attachment_path"
    echo ""
    echo "--$mime_boundary--"
} > /tmp/email_with_attachment.mime

# Send the email
curl --url 'smtps://smtp.gmail.com:465' \
    --ssl-reqd \
    --mail-from 'utsavsingh085@gmail.com' \
    --mail-rcpt 'shashikumar04433@gmail.com' \
    --user 'utsavsingh085@gmail.com:pnmhxysmdigqjxyd' \
    -T /tmp/email_with_attachment.mime

# Cleanup
rm /tmp/email_with_attachment.mime
```
**Method2**
**Install the Powershell in Docker Container**
```
# install the requirements
sudo apk add --no-cache \
    ca-certificates \
    less \
    ncurses-terminfo-base \
    krb5-libs \
    libgcc \
    libintl \
    libssl1.1 \
    libstdc++ \
    tzdata \
    userspace-rcu \
    zlib \
    icu-libs \
    curl

* apk -X https://dl-cdn.alpinelinux.org/alpine/edge/main add --no-cache \
    lttng-ust

# Download the powershell '.tar.gz' archive
* curl -L https://github.com/PowerShell/PowerShell/releases/download/v7.4.1/powershell-7.4.1-linux-musl-x64.tar.gz -o /tmp/powershell.tar.gz

# Create the target folder where powershell will be placed
* mkdir -p /opt/microsoft/powershell/7

# Expand powershell to the target folder
* tar zxf /tmp/powershell.tar.gz -C /opt/microsoft/powershell/7

# Set execute permissions
* chmod +x /opt/microsoft/powershell/7/pwsh

# Create the symbolic link that points to pwsh
* ln -s /opt/microsoft/powershell/7/pwsh /usr/bin/pwsh

# Start PowerShell
* pwsh
```
```
[string]$userName = 'utsavsingh085@gmail.com'
[string]$userPassword = 'pnmhxysmdigqjxyd'

# Crete credential Object
[SecureString]$secureString = $userPassword | ConvertTo-SecureString -AsPlainText -Force 
[PSCredential]$credentialObejct = New-Object System.Management.Automation.PSCredential -ArgumentList $userName, $secureString


$From = "utsavsingh085@gmail.com"
$To = "shashikumar04433@gmail.com"
$Cc = "shashikumar04433@gmail.com"
$Attachment = "/app/file.txt"
$Subject = "Test Email Subject"
$Body = "Test Insert body text here"
$SMTPServer = "smtp.gmail.com"
$SMTPPort = "587"
Send-MailMessage -From $From -to $To -Cc $Cc -Subject $Subject `
-Body $Body -SmtpServer $SMTPServer -port $SMTPPort -UseSsl `
-Credential $credentialObejct -Attachments $Attachment
```
