# Test Engineer Demo

This is a sample project intended to demonstrate the use of NUnit and Selenium in C#. 

The Razor Pages project is based on this tutorial: https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/?view=aspnetcore-5.0, rethemed around games.
An age checker on the Details page of each game to demonstrate ESRB rating enforcement has also been added.

### Build Requirements
.NET Core 5.0 SDK https://dotnet.microsoft.com/download/dotnet/5.0

### Framework
#### Models
Game definitions are stored in a local SQLite database. The Game model describes a basic Game object and its properties as it exists in the database. The virtual properties are overridden in specific Game definitions that inherit the base class to verify them against the pre-seeded database entries.

#### Selenium
The Selenium driver is wrapped for customizable functionality, including the ThreadStatic attribute for simple, parallelized use of the driver and its associated methods.

#### Services
The IGameService interface requires any implementing service to offer the ability to retrieve a game's definition by name only. This is demonstrated in InMemoryGameService, which serves instances of games by name.
