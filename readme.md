# Basic example of Dapper with APS.Net

1. Create a disposable class for your connection. (Check `Db.cs`)
2. Add you connection string to appsettings.json
3. Setup DI. (Check `Startup.cs` and `services.AddTransient<Db>`)
4. Use your DB connection wherever you want. (Check `HelloController`)