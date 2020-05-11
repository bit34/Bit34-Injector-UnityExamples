## Game 1 - A step back

Here is a small project. It may look ok but has some issues that will cause problems when it gets larger. Let's point out and fix some of those before moving forward to using dependency injection library.

### Entry point

When we look at the current state of scene references we see this;

    Game1MusicPlayerPanel ─┐
                           ├─► Game1SettingsPanel
          Game1Controller ─┘

*`Game1SettingsPanel`* has been referenced from multiple points of the project. Having complex references in scene will make it harder to understand starting state of the project for other people (and probably for you, too when revisiting project after some time).

### Scene and data separation

Inspector is a great tool for managing references and values within editor, but when dealing with some data (especially non-scene related once) using classes that are not components is better. We should be able follow the data flow through project without regularly going back-and-forth between code and unity editors. 

### Data access restriction

You can access **any** public field of **any** component of **any** game object in the scene. This may sounds like something good but it just leads to bad practices. There should be a level of data access restriction to keep data access under control.

Lets move on to [Game2](../Game2/ReadMe2.md) where we fix some of those cases.