//Shady
using UnityEngine;
using System.Collections.Generic;

public class Initializer : MonoBehaviour
{
    [SerializeField] List<SingletonBase> _singletons = new List<SingletonBase>();

    private void Awake() => _singletons.ForEach(s => s?.Init());

}//class end