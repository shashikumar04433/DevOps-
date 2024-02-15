# Automation script for building Docker image and pushing into ECR:

**Install the js**
* apt install js -y
```
```
* vi script.sh
* chmod +x script.sh
* ./script.sh
```
```
REPOSITORY="fcra"
AWS_REGION="ap-south-1"
AWS_ACCOUNT_ID="240887461522"  # Replace with your AWS account ID

# Get Docker login password and then login
aws ecr get-login-password --region $AWS_REGION | docker login --username AWS --password-stdin "$AWS_ACCOUNT_ID.dkr.ecr.$AWS_REGION.amazonaws.com"

# Check if Docker login was successful
if [ $? -ne 0 ]; then
    echo "Docker login failed."
    exit 1
fi

# Docker build
docker build -t $REPOSITORY:latest .

# Check if Docker build was successful
if [ $? -ne 0 ]; then
    echo "Docker build failed."
    exit 1
fi

# Tag the image for ECR
docker tag $REPOSITORY:latest "$AWS_ACCOUNT_ID.dkr.ecr.$AWS_REGION.amazonaws.com/$REPOSITORY:latest"

# Push the image to ECR
docker push "$AWS_ACCOUNT_ID.dkr.ecr.$AWS_REGION.amazonaws.com/$REPOSITORY:latest"

# Check if Docker push was successful
if [ $? -ne 0 ]; then
    echo "Docker push failed."
    exit 1
fi

# Find old image digests
OLD_IMAGE_DIGESTS=$(aws ecr --region $AWS_REGION list-images --repository-name $REPOSITORY --filter tagStatus=UNTAGGED | jq '.imageIds | map({imageDigest: .imageDigest})')

# Delete old images if they exist
if [ ! "$OLD_IMAGE_DIGESTS" = '[]' ]; then
  aws ecr --region $AWS_REGION batch-delete-image --repository-name $REPOSITORY --image-ids "$OLD_IMAGE_DIGESTS"
fi
```
