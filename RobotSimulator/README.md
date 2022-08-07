# Description
This application is for robot simulation.

# Complile application
Use this command this application
```
dotnet build
```

# Test application
## Due to lack of famility, skipped testing parts.
```
dotnet test
```


# How to use application
## Assumption
ALL command should be UPPER CASE.
Command validation is not checked so if there is command error this application throw Runtime Exception
except for non-valid location on PLACE command.

## Console Input Application
```
./bin/Debug/net6.0/RobotSimulator
```
## File Input Application
```
./bin/Debug/net6.0/RobotSimulator <filePath>
```