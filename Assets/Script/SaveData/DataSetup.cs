using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSetup : MonoBehaviour
{
    private int BootTimes;

    //データが存在するならロードする
    //存在しないなら初期値設定
    void Awake()
    {
        BootTimes = PlayerPrefs.GetInt("BootTimes");

        if (BootTimes != 0)
        {
            DataStorage.InputBootTimes(1, 1);
            Debug.Log(BootTimes + "回目の起動です");
            DataStorage.InputData();
        }
        else{
            DataStorage.InputBootTimes(2, 0);
            Debug.Log("初めてこのゲームを起動しました");
            DataStorage.FirstData();
        }

        BootTimes = DataStorage.GetBootTimes();
        Debug.Log(BootTimes);
        PlayerPrefs.SetInt("BootTimes", BootTimes);
    }
}