using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingStorage : MonoBehaviour
{
    public static float Volume;
    public static float GetVolume(){
        return Volume;
    }

    public static float Sensi_Rotate;
    public static float GetSensi_Rotate(){
        return Sensi_Rotate;
    }

    public static float Sensi_Zoom;
    public static float GetSensi_Zoom(){
        return Sensi_Zoom;
    }

    //第一引数0は新規代入
    //第一引数1は加算
    //第一引数2は初期化

    public static void InputVolume(int num, float value)
    {
        switch (num)
        {
            case 0:
                Volume = value;
                break;
            case 1:
                Volume += value;
                break;
            case 2:
                Volume = 0.5f;
                break;
            default:
                
                break;
        }
        DataStorage.InputVolume(0, Volume);
    }

    public static void InputSensi_Rotate(int num, float value)
    {
        switch (num)
        {
            case 0:
                Sensi_Rotate = value;
                break;
            case 1:
                Sensi_Rotate += value;
                break;
            case 2:
                Sensi_Rotate = 1.0f;
                break;
            default:

                break;
        }
        DataStorage.InputSpin(0, Sensi_Rotate);
    }

    public static void InputSensi_Zoom(int num, float value)
    {
        switch (num)
        {
            case 0:
                Sensi_Zoom = value;
                break;
            case 1:
                Sensi_Zoom += value;
                break;
            case 2:
                Sensi_Zoom = 1.0f;
                break;
            default:

                break;
        }
        DataStorage.InputZoom(0, Sensi_Zoom);
    }

    void Start()
    {

    }


}