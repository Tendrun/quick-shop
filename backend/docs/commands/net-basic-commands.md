1. Uninstall package
Uninstall-Package <Package-name> -ProjectName <Project-name>

2. Create migration
dotnet ef migrations add <Migration Name> --project <Project Migration>

3. Apply migration
dotnet ef database update --project <Project Name>

4. reverse migration
dotnet ef migrations remove

5. show list of migrations
dotnet ef migrations list