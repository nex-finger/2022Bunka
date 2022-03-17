using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoonDirection : MonoBehaviour
{
    private int AntennaLevel;
    private float TotalTime;
    private int Flag;

    // Start is called before the first frame update
    void Start()
    {
        AntennaLevel = LevelStorage.GetAntenna();
        TotalTime = 0.0f;
        Flag = 1;
    }

    // Update is called once per frame
    void Update()
    {
        TotalTime += Time.deltaTime;
        if(TotalTime > 10.0f)
        {
            TotalTime -= 10.0f;
        }

        if (AntennaLevel == 1)
        {
            if(Flag == 1)
            {
                GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
                if (TotalTime > 1.0f)
                {
                    GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                    Flag = 0;
                }
            }
        }
        else if (AntennaLevel == 2)
        {
            if (TotalTime > 0.0f && TotalTime < 1.0f)
            {
                GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            }
            else
            {
                GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
            }
        }
    }
}
