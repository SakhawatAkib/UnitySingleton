# UnitySingleton

The Singleton Design Pattern is one of the most used design patterns in Unity. It ensures that a class has only one static Instance and it is globally accessible.

The most common Singleton classes we make in a game are mostly the Managers for example GameManager, AudioManager etc.
We can either make a static instance within the class and implement it in the Awake Method or we can use a Generic approach shown below to make any class a Singleton.

In this approach I don't use the Unity's built-in Awake method for creating the Instance because commonly we have a bunch of Singletons in the Project, you do not know which Singletons Awake will be called first upon playing the game so if an Instance has not been created and its reference is called an error is thrown. To tackle this problem the instances are created manually and in the sequential order you want so the reference required first has an instance available. So for initializations of all the Singletons they are assigned to the Initializer script in an array and there Instances are created sequentially in the order you have assigned them in the array from the inspector also shown below.

If you don't want to use the Initializer approach you can simply Make an Awake method in the class you Inherited from the Singleton class and call base.Init(); in the Awake method.

Also there is a Dont Destroy On Load option for the Singleton as well. Inheriting a class from DontDestroyOnLoadSingleton will preserve that GameObject upon shifting Scenes.

This implementation has been modified check it out here:
https://lnkd.in/dTaxQren

Note: Singletons are good for a Small Scale project but they aren't suitable for Large Scale Projects because it is Globally Accessible from anywhere, even from the scripts which don't require it so tracking a call becomes very hectic to find in this case.
To overcome this problem you can use the Dependency Injection Design Pattern which I will elaborate in a future post.
Do read about Inversion of Control to understand DI.
For implementing DI in Unity a free framework is available on the Asset Store named Zenject do check it out too
https://lnkd.in/dPzTFzQM


Rather than adding MonoBehaviours in the List of Initializer we added another layer of inheritance as SingletonBase and made an abstract method which is called from the Initializer.
So rather than assigning any MonoBehaviour in the List of Initializer you can only assign those scripts which are a Singleton.
And rather than making the DontDestroySingleton an independent class we made it a child of the existing Singleton class.