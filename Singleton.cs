//Shady
using UnityEngine;

public abstract class SingletonBase : MonoBehaviour
{
    public abstract void Init();
}//class end

public abstract class Singleton<T> : SingletonBase where T : Component
{
    public static T Instance {get; protected set;}

    public override void Init()
    {
        if(Instance == null)
            Instance = this as T;
        else
            Destroy(gameObject);
    }//Init() end

}//class end

public abstract class DontDestroySingleton<T> : Singleton<T> where T : Component
{
    public override void Init()
    {
        if(Instance == null)
        {
            Instance = this as T;
            DontDestroyOnLoad(gameObject);
        }//if end
        else
            DestroyImmediate(gameObject);
    }//Init() end
    
}//class end