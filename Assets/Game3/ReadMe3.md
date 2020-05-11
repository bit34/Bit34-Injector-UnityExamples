## Game 3 - Do it for me, please

Let's integrate our library step by step

### 0. Add library to our project
Before writing any code we have to add our library package to **manifest.json** file.

```
{
  "dependencies": {
    "com.bit34games.di": "https://github.com/bit34/Bit34-DI-UPM.git#v1.0.0",

    ...

}
```

if your version of Unity does not support packages you can download and add it to your library directly from [Github](https://github.com/bit34/Bit34-DI)

### 1. Add attributes
First, you have to add `[Inject]` attribute to the fields or properties where you want to receive instances. They can be public or private.

```
public class Game3MusicPlayerPanel : MonoBehaviour
{
    ...

    [Inject] private IGame3Settings _settings;

    ...
}
```

```
public class Game3SettingsPanel : MonoBehaviour
{
    ...

    [Inject] private Game3Settings _settings;

    ...
}
```

### 2. Create injector
Create an instance of `Injector` class. This instance will hold your references to be injected to your project.

```
public class Game3Controller : MonoBehaviour
{
    ...

	private Injector _injector;

    ...

    Injector injector = new Injector();

    ...
}
```

### 3. Add bindings
It is time to add bindings. Bindings will define which instance will be assigned to which types. There are two options for adding a binding:

- Binding a type to an initialized object : You can bind a type to an already instantiated instance. Actually you can bind all **assignable** types to this instance. See examples below for details;

```
    //  Create and initialize your object
    Game3Settings settings = new Game3Settings();
    settings.Volume = 0.5f;
    settings.IsMusicPlaying = true;

    //  this line means; every "[Inject] Game3Settings" field will receive settings instance when injected
    _injector.AddBinding<Game3Settings>()  .ToValue(settings);

    //  this line means; every "[Inject] Game3Settings" field will receive settings instance when injected
    _injector.AddBinding<IGame3Settings>() .ToValue(settings);
```

- Binding a type to type : If you do not need to initialize your object before hand you could just bind its type and it will be instantiated when first requested. You can also bind all *assignable* single type. They will share same instance. See examples below;

NOTE : To use automatic instantiation your binded type must have a parameterless constructor.

```
    //  this lines mean; when one of "[Inject] Game3Settings" or "[Inject] IGame3Settings" fields 
    //  first encountered a new instance of "Game3Settings" be created and assigned. 
    //  All subsequent ones will receive that same instance  
    _Injector.AddBinding<Game3Settings>()  .ToType<Game3Settings>();
    _Injector.AddBinding<IGame3Settings>() .ToType<Game3Settings>();
```

### 4. Inject dependencies

This is where we actually make the injections. At this point all you have to do is have a list of game objects that has `[Inject]` attributes in thier components and make injections.

Here is the best part, the code below will not change for any number of type bindings and injection targets.


```
public class Game3Controller : MonoBehaviour
{
    ...
    
	[SerializeField] private GameObject[] _injectionTargets;

    ...

    //  Iterate all objects in list
    foreach (GameObject injectionTarget in _injectionTargets)
    {
        //  iterate all scripts
        MonoBehaviour[] scriptlist = injectionTarget.GetComponents<MonoBehaviour>();
        foreach (MonoBehaviour script in scriptlist)
        {
            //  Perform injections : Find fields with [Inject] attribute 
            //  and assign binded values to them
            _injector.InjectInto(script);
        }
    }
}
```

That is it for now, you can continue [reading](../ReadMe.After.md) for details.