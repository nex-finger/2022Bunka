using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Value_Storage : MonoBehaviour
{
    public static float BoostPower;
    public static float RCSPower;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
