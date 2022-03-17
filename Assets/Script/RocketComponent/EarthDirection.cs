using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EarthDirection : MonoBehaviour
{
    private int AntennaLevel;

    // Start is called before the first frame update
    void Start()
    {
        AntennaLevel = LevelStorage.GetAntenna();
        if (AntennaLevel < 4)
        {
            GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
        }
    }
}
