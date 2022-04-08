using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataStorage : MonoBehaviour
{
    // 起動回数
    public static int BootTimes;
    public static int GetBootTimes()
    {
        return BootTimes;
    }

    //第一引数0は新規代入
    //第一引数1は加算
    //第一引数2は初期化

    public static void InputBootTimes(int num, int value)
    {
        switch (num)
        {
            case 0:
                BootTimes = value;
                break;
            case 1:
                BootTimes += value;
                break;
            case 2:
                BootTimes = 1;
                Debug.Log(BootTimes);
                break;
            default:

                break;
        }
    }

    public static void FirstData()
    {
        PlayerPrefs.SetInt("BootTimes", 1);
    }

    public static void InputData()
    {

    }

    public static void DeleteData()
    {

    }
}
