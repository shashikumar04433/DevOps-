# SMTP Email Notification:
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
