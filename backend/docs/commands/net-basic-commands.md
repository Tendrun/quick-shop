1. Uninstall package
Uninstall-Package <Package-name> -ProjectName <Project-name>

2. Create migration
dotnet ef migrations add <Migration Name> --project <Project Migration>

3. Apply migration
dotnet ef database update --project <Project Name>

3.1 Apply Migration 
# Must be used from folder "backend"
dotnet ef database update --project src\Workshop.Infrastructure --startup-project src\Workshop.Api

4. reverse migration
dotnet ef migrations remove

5. show list of migrations
dotnet ef migrations list

5.1 Show list of migrations without connect to database and build 
dotnet ef migrations list --project src\Workshop.Infrastructure --startup-project src\Workshop.Api --no-build --no-connect

