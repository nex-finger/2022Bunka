using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMainBGM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObjectUtils.DestoryIfExist( "MainBGM" );
    }
}
