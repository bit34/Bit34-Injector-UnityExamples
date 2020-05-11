using UnityEngine;
using Com.Bit34Games.DI;

public class Game3Controller : MonoBehaviour
{
    //  MEMBERS
#pragma warning disable 0649
	[SerializeField] private GameObject[] _injectionTargets;
#pragma warning restore 0649
	private Injector _injector;
	
    //  METHODS
	void Awake ()
	{
        //  Create injector
		_injector = new Injector(true);

        AddBindings();
        InjectToTargets();
	}

    private void AddBindings()
    {
        bool loadSettings = true;
        if(loadSettings)
        {
            //  Create your object and initialize
            Game3Settings settings = new Game3Settings();
            settings.Volume = 0.5f;
            settings.IsMusicPlaying = true;
            
            //  Bind those types to instance
            _injector.AddBinding<Game3Settings>().ToValue(settings);
            _injector.AddBinding<IGame3Settings>().ToValue(settings);
        }
        else
        {
            //  Bind those types to Game3Settings, it will be instantiated when first needed
            _injector.AddBinding<Game3Settings>().ToType<Game3Settings>();
            _injector.AddBinding<IGame3Settings>().ToType<Game3Settings>();
        }
    }

    private void InjectToTargets()
    {
        //  Iterate all objects in list
        foreach (GameObject injectionTarget in _injectionTargets)
        {
            //  iterate all scripts
            MonoBehaviour[] scriptlist = injectionTarget.GetComponents<MonoBehaviour>();
            foreach (MonoBehaviour script in scriptlist)
            {
                //  Perform injections
                _injector.InjectInto(script);
            }
        }
    }
}
