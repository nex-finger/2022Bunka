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
                Volume = num;
                break;
            case 1:
                Volume += num;
                break;
            case 2:
                Volume = 0.5f;
                break;
            default:
                
                break;
        }
    }

    public static void InputSensi_Rotate(int num, float value)
    {
        switch (num)
        {
            case 0:
                Sensi_Rotate = num;
                break;
            case 1:
                Sensi_Rotate += num;
                break;
            case 2:
                Sensi_Rotate = 1.0f;
                break;
            default:
                break;
        }
    }

    public static void InputSensi_Zoom(int num, float value)
    {
        switch (num)
        {
            case 0:
                Sensi_Zoom = num;
                break;
            case 1:
                Sensi_Zoom += num;
                break;
            case 2:
                Sensi_Zoom = 1.0f;
                break;
            default:
                break;
        }
    }

    void Start()
    {

    }


}