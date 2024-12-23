### Input Validation
```
Terraform provides the validation block within a variable definition to enforce rules.
You can combine this with custom error messages to guide users.
```
variable "inputcheck" {
  type = string

validation {
  condition     = length(var.inputcheck) >= 3 && length(var.inputcheck) <=10
  error_message = "Input must be between 3 and 10 characters long."
}
}
```
