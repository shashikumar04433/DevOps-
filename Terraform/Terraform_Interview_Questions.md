### Terraform_Interview_Questions

1. What is Terraform?
```
Terraform is an Infrastructure as Code (IaC) tool that enables you to define and manage infrastructure.
```
2. What are Terraform Providers?
```
Providers are plugins used by Terraform to interact with APIs of cloud providers such as (AWS, Azure).
```
3. How does Terraform manage infrastructure state?
```
The state file is used to keep track of the current state of the infrastructure resources managed by Terraform.
```
4. What are Terraform modules?
```
Modules are reusable containers for multiple resources. They simplify and organize your configurations for scalability and maintainability.
```
5. What is the difference between terraform plan and terraform apply?
```
terraform plan: Displays the changes Terraform will make without applying them.
terraform apply: Executes the planned changes to create or modify resources.
```
6. What is terraform init?
```
It initializes a Terraform configuration directory by downloading provider plugins and setting up the backend configuration.
````
7. How do you handle sensitive data in Terraform?
```
Use environment variables (TF_VAR_<variable_name>).
Store secrets in a secure backend like AWS Secrets Manager.
Mark variables as sensitive.
```

8. What is the difference between terraform refresh and terraform taint?
```
terraform refresh: Updates the state file with the  resource statuses.
terraform taint: Marks a resource for forced recreation during the next terraform apply.
```
9. What are Terraform backends?
```
Backends define where the Terraform state file is stored. Examples include local storage, S3, Azure Blob Storage.
```
10. What is a null_resource in Terraform?
```
A null_resource is a resource with no physical infrastructure. It’s used to trigger provisioners or manage ddependencies.
```
11. How does Terraform handle dependencies between resources?
```
Terraform automatically manages dependencies using resource references and interpolation.
Explicit dependencies can be defined using depends_on.
```
12. What is a dynamic block in Terraform?
```
Dynamic blocks allow for programmatic generation of nested blocks based on a loop or condition.
```
13. What is for_each in Terraform?
```
for_each is used to iterate over a map or a set to create multiple instances of a resource.
```
14. What is the purpose of terraform import?
```
terraform import allows you to bring existing infrastructure into
Terraform's state management without altering the resource.
```
15. What is the .terraform.lock.hcl file?
```
This file locks the provider versions used in a project, ensuring consistency across environments.
```
16. What is the difference between count and for_each?
```
count: Creates multiple instances of a resource based on an integer value.
for_each: Creates instances based on iterable objects like maps or sets.
```
17. What are local values in Terraform?
```
locals are key-value pairs used to simplify and optimize configurations by storing reusable expressions.
```
```
Example:
locals {
  region = "us-west-1"
}
```
18. What is the purpose of terraform validate?
```
Validates the syntax of Terraform configuration files without running any resource creation.
```
19. What are the different ways to pass variables in Terraform?
```
Command-line flags: -var "key=value".
Variable files: .tfvars.
Environment variables: TF_VAR_<variable_name>.
```
20. What is remote state in Terraform?
```
Remote state stores the state file in a shared backend for team collaboration (S3, Azure Blob).
```
21. What is the difference between terraform destroy and terraform apply?
```
terraform destroy: Deletes all managed resources.
terraform apply: Creates or updates resources to match the configuration.
```
22. How does Terraform ensure idempotency?
```
Terraform compares the desired configuration with the current state and applies only the required changes.
```
23. Can Terraform work with multiple cloud providers?
```
Yes, Terraform can provision resources across multiple providers in a single configuration using multiple providers (aws).
```
24. What are output values in Terraform?
```
Outputs expose values after a configuration is applied, making them available for use in other modules or for reference.
```
25. What is the purpose of terraform workspace?
```
Workspaces allow managing multiple environments ( dev, test, prod) within a single Terraform configuration.
```
26. What is a lifecycle rule in Terraform?
```
Lifecycle rules control resource behavior, such as,create_before_destroy and Ensures new resources are created before old ones are destroyed.prevent_destroy: Prevents accidental deletion.
```
27. What is the purpose of terraform fmt?
```
Formats configuration files to follow a consistent style for better readability.
```
28. What are provisioners in Terraform?
```
Provisioners execute scripts or commands on a resource after it is created or before it is destroyed.
Examples include local-exec and remote-exec and file provisioner.
```

29. How do you manage versioning in Terraform?
```
Use required_version in the configuration to lock the Terraform version.
Use required_providers to specify provider versions.
```
30. How do you debug Terraform issues?
```
Enable debug logs: TF_LOG=DEBUG.
Review the state file for inconsistencies.
Use terraform plan to identify mismatches.
```
