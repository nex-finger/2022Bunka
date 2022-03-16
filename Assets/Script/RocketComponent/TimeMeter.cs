using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeMeter : MonoBehaviour
{
    private float TimeLimit;
    private bool Flag;

    // Start is called before the first frame update
    void Start()
    {
        Flag = MeterFlag0.GetMeterFlag();

        if (Flag == false)
        {
            MeterFlag0.TrueMeterFlag();
            TimeLimit = 300.0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float NeedleRotate;
        float RotateRate;

        TimeLimit -= Time.deltaTime;
        if (TimeLimit < 0.0f)
        {
            SceneManager.LoadScene("GameOver1");
        }

        RotateRate = 240.0f / TimeLimit;
        NeedleRotate = (RotateRate * Time.deltaTime);

        GameObject.Find("Needle_Time").GetComponent<RectTransform>().Rotate(0.0f, 0.0f, NeedleRotate);
        //Debug.Log(TimeLimit);
    }
}
