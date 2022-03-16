using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LanderTimeMeter : MonoBehaviour
{
    private float TimeLimit;
    private float TotalTime;

    // Start is called before the first frame update
    void Start()
    {
        TimeLimit = TimeMeter.GetTimeLimit();
        TotalTime = 300.0f - TimeLimit;

        GameObject.Find("Needle_Time").GetComponent<RectTransform>().Rotate(0.0f, 0.0f, ((240.0f / TimeLimit) * TotalTime));
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
