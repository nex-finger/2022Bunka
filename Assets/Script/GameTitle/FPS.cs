using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPS : MonoBehaviour
{
    public Text Textb;
    private float Timeb;
    private int FPSb;

    // Start is called before the first frame update
    void Start()
    {
        Timeb = 0.0f;
        FPSb = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Timeb += Time.deltaTime;
        FPSb += 1;

        Textb.text = string.Format("{0}", FPSb);

        if (Timeb > 1.0f)
        {
            Timeb -= 1.0f;
            FPSb = 0;
        }
    }
}
