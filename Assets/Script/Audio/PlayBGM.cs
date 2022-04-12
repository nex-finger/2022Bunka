using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBGM : MonoBehaviour
{
    public AudioSource Audio1;
    public AudioSource Audio2;
    public AudioSource Audio3;
    public AudioSource Audio4;

    public GameObject Script;
    public GameObject Object1; 
    public GameObject Object2; 
    public GameObject Object3; 
    public GameObject Object4;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(Script);
        DontDestroyOnLoad(Object1);
        DontDestroyOnLoad(Object2);
        DontDestroyOnLoad(Object3);
        DontDestroyOnLoad(Object4);

        //Audio1.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
