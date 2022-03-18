using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    public Text TextScore;
    private int Score;

    // Start is called before the first frame update
    void Start()
    {
        Score = 3000 - LevelStorage.GetCash();
        TextScore.text = string.Format("{0}", Score);
    }
}
