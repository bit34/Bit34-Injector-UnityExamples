using Com.Bit34Games.DI;
using UnityEngine;

public class Example2 : MonoBehaviour
{
    //  MEMBERS
	public GameObject[] InjectionTargetList;
	private Injector _Injector;
	
    //  METHODS
	void Awake ()
	{
        //  Create injector
		_Injector = new Injector(true);

        //  Add bindings
        //  As long as they are all assignable to binding type you can exchange between different implementations of classes. 
        //  This gives you easy way to achieve follwing without touching rest of your code.
        //  - test special cases to find spesific errors
        //  - isolate some part of your programs for easy debugging
        //  - change between different implementation for different platforms or plugins

        //  In this example given implemetation of Setting class is always muted and will not be changed with user input
        _Injector.AddBinding<ISettings>().ToType<SettingsDummy>();
        _Injector.AddBinding<IReadonlySettings>().ToType<SettingsDummy>();

        //  Iterate all object in list
        foreach (GameObject go in InjectionTargetList)
        {
            MonoBehaviour[] scriptlist = go.GetComponents<MonoBehaviour>();

            //  iterate all scripts
            foreach (MonoBehaviour sc in scriptlist)
            {
                //  Perform injections
                _Injector.InjectInto(sc);
            }
        }
	}
}
