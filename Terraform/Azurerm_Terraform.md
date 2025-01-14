### Login with Cli  and create a role with cli:
```
* az account clear
* az config set core.enable_broker_on_windows=false
* az login
* az account show --output table
* az account set --subscription "3f45d258-1749-49e4-9647-6d2b1e73599a"
* az account list --output table
```
**1. Log Out and Clear Account Cache:**
```
az account clear
```
**2. Log In Explicitly::**
```
az login --scope https://graph.microsoft.com//.default
```
**3. Log In with Specific Tenant**
```
az login --tenant "93193f73-1076-41e0-a756-33058e7ec697
```
**4. Verify Active Subscription:**
```
az account list --output table
```
**5.Retry Role Assignment:**
```
az role assignment create --assignee "15d6340c-b236-401f-8499-4bf55b9e1bdf" --role "Contributor" --scope "/subscriptions/3f45d258-1749-49e4-9647-6d2b1e73599a"
```
**6.Check the principal id access type**
```
az role assignment list --assignee "15d6340c-b236-401f-8499-4bf55b9e1bdf" --output table
```

