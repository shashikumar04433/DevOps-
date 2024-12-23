### Local_Variables:
```
Local variables are defined and used within a  module .
```
**Types of Variables**
```
1.Simple Local Variable.
2.Computed Values
3.Complex locals for readability
4.Using locals with conditions
```

**Eg:**
```
locals {
  region = "us-west-2"
}

resource "aws_instance" "example" {
  ami           = "ami-0c55b159cbfafe1f0"
  instance_type = "t2.micro"
  availability_zone = local.region
}
```
