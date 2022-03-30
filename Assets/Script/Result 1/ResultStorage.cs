using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultStorage : MonoBehaviour
{
    public string Name;
    public int Score;
    public float Time;
    //public int flag;
    public InputField nameInput;

        
    // Start is called before the first frame update
    void Start()
    {
        //flag = 0;
        Score = 3000 - LevelStorage.GetCash();
        Time = LevelStorage.GetTotalTime(0);
    }
    public void submitButton(){
        /*if(flag == 0){
		Name = nameInput.text;
		Debug.Log (Name);
        Debug.Log (Score);
		SaveScore.save(Name, Score, Time);
        flag = 1;
        }else{
        Debug.Log("保存済みですよね？一回までだよ。");  
        }*/
        Name = nameInput.text;
		Debug.Log (Name);
        Debug.Log (Score);
		SaveScore.save(Name, Score, Time);
        SceneManager.LoadScene("LeaderBoard");
  }
}
