using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultStorage : MonoBehaviour
{
    public string Name;
    public int Score;
    public float Time;
    public InputField nameInput;

    // Start is called before the first frame update
    void Start()
    {
        Score = 3000 - LevelStorage.GetCash();
        Time = LevelStorage.GetTotalTime(0);
    }
    public void submitButton(){
		Name = nameInput.text;
		Debug.Log (Name);
        Debug.Log (Score);
		SaveScore.save(Name, Score, Time);
  }
}
