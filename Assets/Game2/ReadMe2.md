## Game 2 - Better point to start

### Entry point

Now take a look at the new state of scene references;

                     ┌─► Game2SettingsPanel
    Game2Controller ─┤
                     └─► Game2MusicPlayerPanel

*`Game2Controller`* is now the starting point of the scene and it initiates other parts of it. So when investigating the project (either for the first time for learning or remembering where you left off) you will know exactly where to start.

### Scene and data separation

Setting related data is removed from *`Game2SettingsPanel`* component to data only *`Game2Settings`* class. It is now created in *`Game2Controller`* and then passed to others who need it.

### Data access restriction

In this version of project we do a few things to allow us to do better control access.

- Changing component fields from *`public`* to *`[SerializeField] private`* we have prevented access to those fields from inspector.

- By providing *`Settings`* and its readonly *`ISettings`* interface we prevent accidental modification of data through out the game.

### Are we done?
Things look better with all those changes but still there is one part of program that looks ugly (and will get uglier) and require alot of manual work, injecting dependencies.

```
public class Game2Controller : MonoBehaviour
{
    ...

    [SerializeField] private Game2SettingsPanel _settingsPanel;
    [SerializeField] private Game2MusicPlayerPanel _musicPlayerPanel;
    private Game2Settings _settings;

    ...

    _settingsPanel.InjectValues(_settings);
    _musicPlayerPanel.InjectValues(_settings);

    ...
}
```
This is where **Dependency injection** library shines. It will automate this task with minimal effort.

We are all set to move to [Game3](../Game3/ReadMe3.md) folder to see our library in action.