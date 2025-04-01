```
provider "aws" {
region = "ap-south-1"
access_key=var.access_key
secret_key=var.secret_key

}


resource "aws_s3_bucket" "bucketname" {
bucket="s3bucket01"
}


resource "aws_s3_bucket_public_access_block" "example" {
bucket=aws_s3_bucket.example_bucket.id
block_public_acls = false
block_public_policy = false
ignore_public_acls = false
restrict_public_buckets = false
}
```
