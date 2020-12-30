# Test Engineer Demo

This is a sample project intended to demonstrate the use of NUnit and Selenium in C#. 

### Build Requirements
.NET Core 5.0 SDK https://dotnet.microsoft.com/download/dotnet/5.0

## RazorPagesGame

The Razor Pages project is based on this tutorial: https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/?view=aspnetcore-5.0, rethemed around games.
An age checker on the Details page of each game to demonstrate ESRB rating enforcement has also been added.

## Framework
The backing for Selenium, as well as the definitions for the base Game and specific game classes are contained in this project.

#### Models
Game definitions are stored in a local SQLite database. The Game model describes a basic Game object and its properties as it exists in the database. The virtual properties are overridden in specific Game definitions that inherit the base class to verify them against the pre-seeded database entries.

#### Selenium
The Selenium driver is wrapped for customizable functionality, including the ```[ThreadStatic]``` attribute for simple, parallelized use of the driver and its associated methods.

#### Services
The ```IGameService``` interface requires any implementing service to offer the ability to retrieve a game's definition by name only. This is demonstrated in ```InMemoryGameService```, which serves instances of defined games by name.


## Games

This project contains page map models for each of the web pages that is tested in Games.UITests. The PageBase includes the header navigation bar abstract class, which is inherited by all other page classes as it is present on every page of the site.

The rest of the pages inclue a page map class, which defines what elements are present on each page, and a page class, which defines what the user can do with those elements.

```AllPages``` encapsulates a ```[ThreadStatic]``` instance of each page so they may be tested in parallel alongside the Selenium driver.

## TeamCity

I've included the TeamCity project files to replicate the build steps if desired.
