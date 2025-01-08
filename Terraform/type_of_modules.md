## Type_of_modules:

**Root Module**
```
Main entry point for the configuration.
Source Example: Current working directory.
```
**Child Module**
```
Called by another module.
Source Example: ./modules/network
```
**Public Module**
```
Published in public registries.
Source Example: terraform-aws-modules/vpc/aws
```
**Private Module**
```
Custom modules for internal use.
Source Example: git::https://github.com/org/private.git
```
**Community Module**
```
Shared by the community.
Source Example: GitHub repositories or similar sources.
```
**Submodule**
```
A module within another module.
Source Example: git::repo.git//submodule-path
```
**Local Module**
```
Stored locally in the project directory.
Source Example: ./modules/example
```
**Remote Module**
```
Stored in remote locations.
Source Example: Terraform Registry or GitHub URL.
```
