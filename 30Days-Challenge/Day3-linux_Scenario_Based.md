### Day3-linux_Scenario_Based:

## Senario based questions:
Delete files older than 10 days using shell script in Unix [duplicate] ??
```
find /path/to/directory -type f -newermt "2025-01-17" ! -newermt "2025-01-21" -exec rm -f {} +
find / -type f -newermt 

/path/to/directory: Directory to search for files.
-type f: Match only files (not directories).
-newermt "2025-01-17": Files modified after January 17, 2025.
! -newermt "2025-01-21": Files modified before January 21, 2025.
-exec rm -f {} +: Delete matched files.

```
How do you check the monitor CPU utilization
```
mpstat
```
How do u generate load on cpu using the alternative command?
```
sudo apt install stress    # For Debian/Ubuntu

stress --cpu 2 --timeout 30
```
