using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeterHide : MonoBehaviour
{
    private float LanderLevel;

    // Start is called before the first frame update
    void Start()
    {
        LanderLevel = LevelStorage.GetLander();

        if (LanderLevel == 1)
        {
            GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
        }
    }
}
