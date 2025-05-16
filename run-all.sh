#!/bin/bash
dotnet run --project ./LM.IdentityService &
dotnet run --project ./LM.UserService &
dotnet run --project ./LM.Gateway
