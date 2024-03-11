# SMTP Email Notification:

curl --url 'smtps://smtp.gmail.com:465' --ssl-reqd \
  --mail-from 'utsavsingh085@gmail.com' \
  --mail-rcpt 'shashikumar04433@gmail.com' \
  --user 'utsavsingh085@gmail.com:pnmhxysmdigqjxyd' \
  -T <(echo -e 'From: utsavsingh085@gmail.com\nTo: shashikumar04433@gmail.com\nSubject: Curl Test\n\nHello')

