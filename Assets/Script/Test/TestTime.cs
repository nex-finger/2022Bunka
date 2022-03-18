using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestTime : MonoBehaviour
{
    public Text Texta;
    private float Timea;

    // Start is called before the first frame update
    void Start()
    {
        Timea = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        Timea += Time.deltaTime;
        Texta.text = string.Format("{0}", Timea);
    }
}
