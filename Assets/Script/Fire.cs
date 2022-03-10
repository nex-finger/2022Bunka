using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    SpriteRenderer Firea;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") || Input.GetMouseButtonDown(2))
        {
            this.GetComponent<SpriteRenderer>().color += new Color(0, 0, 0, 255);
        }

        if (Input.GetKeyUp("space") || Input.GetMouseButtonUp(2))
        {
            this.GetComponent<SpriteRenderer>().color += new Color(0, 0, 0, -255);
        }
    }
}
