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

    public static float Volume;
    public static float GetVolume()
    {
        return Volume;
    }

    public static float Spin;
    public static float GetSpin()
    {
        return Spin;
    }

    public static float Zoom;
    public static float GetZoom()
    {
        return Zoom;
    }

    public static int ClearTimes;
    public static int GetClearTimes()
    {
        return ClearTimes;
    }

    public static int BestScore;
    public static int GetBestScore()
    {
        return BestScore;
    }

    public static int BSBoost;
    public static int GetBSBoost()
    {
        return BSBoost;
    }

    public static int BSFuel;
    public static int GetBSFuel()
    {
        return BSFuel;
    }

    public static int BSAntenna;
    public static int GetBSAntenna()
    {
        return BSAntenna;
    }

    public static int BSLander;
    public static int GetBSLander()
    {
        return BSLander;
    }

    public static float BestTime;
    public static float GetBestTime()
    {
        return BestTime;
    }

    public static int BTBoost;
    public static int GetBTBoost()
    {
        return BTBoost;
    }

    public static int BTFuel;
    public static int GetBTFuel()
    {
        return BTFuel;
    }

    public static int BTAntenna;
    public static int GetBTAntenna()
    {
        return BTAntenna;
    }

    public static int BTLander;
    public static int GetBTLander()
    {
        return BTLander;
    }

    public static int ClearBoost;
    public static int GetClearBoost()
    {
        return ClearBoost;
    }

    public static int ClearFuel;
    public static int GetClearFuel()
    {
        return ClearFuel;
    }

    public static int ClearAntenna;
    public static int GetClearAntenna()
    {
        return ClearAntenna;
    }

    public static int ClearLander;
    public static int GetClearLander()
    {
        return ClearLander;
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
                break;
            default:

                break;
        }
    }

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
    }

    public static void InputSpin(int num, float value)
    {
        switch (num)
        {
            case 0:
                Spin = value;
                break;
            case 1:
                Spin += value;
                break;
            case 2:
                Spin = 1.0f;
                break;
            default:

                break;
        }
    }

    public static void InputZoom(int num, float value)
    {
        switch (num)
        {
            case 0:
                Zoom = value;
                break;
            case 1:
                Zoom += value;
                break;
            case 2:
                Zoom = 1.0f;
                break;
            default:

                break;
        }
    }

    public static void InputClearTimes(int num, int value)
    {
        switch (num)
        {
            case 0:
                ClearTimes = value;
                break;
            case 1:
                ClearTimes += value;
                break;
            case 2:
                ClearTimes = 0;
                break;
            default:

                break;
        }
    }

    public static void InputBestScore(int num, int value)
    {
        switch (num)
        {
            case 0:
                BestScore = value;
                break;
            case 1:
                BestScore += value;
                break;
            case 2:
                BestScore = 0;
                break;
            default:

                break;
        }
    }

    public static void InputBSBoost(int num, int value)
    {
        switch (num)
        {
            case 0:
                BSBoost = value;
                break;
            case 1:
                BSBoost += value;
                break;
            case 2:
                BSBoost = 0;
                break;
            default:

                break;
        }
    }

    public static void InputBSFuel(int num, int value)
    {
        switch (num)
        {
            case 0:
                BSFuel = value;
                break;
            case 1:
                BSFuel += value;
                break;
            case 2:
                BSFuel = 0;
                break;
            default:

                break;
        }
    }

    public static void InputBSAntenna(int num, int value)
    {
        switch (num)
        {
            case 0:
                BSAntenna = value;
                break;
            case 1:
                BSAntenna += value;
                break;
            case 2:
                BSAntenna = 0;
                break;
            default:

                break;
        }
    }

    public static void InputBSLander(int num, int value)
    {
        switch (num)
        {
            case 0:
                BSLander = value;
                break;
            case 1:
                BSLander += value;
                break;
            case 2:
                BSLander = 0;
                break;
            default:

                break;
        }
    }

    public static void InputBestTime(int num, float value)
    {
        switch (num)
        {
            case 0:
                BestTime = value;
                break;
            case 1:
                BestTime += value;
                break;
            case 2:
                BestTime = 300.0f;
                break;
            default:

                break;
        }
    }

    public static void InputBTBoost(int num, int value)
    {
        switch (num)
        {
            case 0:
                BTBoost = value;
                break;
            case 1:
                BTBoost += value;
                break;
            case 2:
                BTBoost = 0;
                break;
            default:

                break;
        }
    }

    public static void InputBTFuel(int num, int value)
    {
        switch (num)
        {
            case 0:
                BTFuel = value;
                break;
            case 1:
                BTFuel += value;
                break;
            case 2:
                BTFuel = 0;
                break;
            default:

                break;
        }
    }

    public static void InputBTAntenna(int num, int value)
    {
        switch (num)
        {
            case 0:
                BTAntenna = value;
                break;
            case 1:
                BTAntenna += value;
                break;
            case 2:
                BTAntenna = 0;
                break;
            default:

                break;
        }
    }

    public static void InputBTLander(int num, int value)
    {
        switch (num)
        {
            case 0:
                BTLander = value;
                break;
            case 1:
                BTLander += value;
                break;
            case 2:
                BTLander = 0;
                break;
            default:

                break;
        }
    }

    public static void InputClearBoost(int num, int value)
    {
        switch (num)
        {
            case 0:
                ClearBoost = value;
                break;
            case 1:
                ClearBoost += value;
                break;
            case 2:
                ClearBoost = 0;
                break;
            default:

                break;
        }
    }

    public static void InputClearFuel(int num, int value)
    {
        switch (num)
        {
            case 0:
                ClearFuel = value;
                break;
            case 1:
                ClearFuel += value;
                break;
            case 2:
                ClearFuel = 0;
                break;
            default:

                break;
        }
    }

    public static void InputClearAntenna(int num, int value)
    {
        switch (num)
        {
            case 0:
                ClearAntenna = value;
                break;
            case 1:
                ClearAntenna += value;
                break;
            case 2:
                ClearAntenna = 0;
                break;
            default:

                break;
        }
    }

    public static void InputClearLander(int num, int value)
    {
        switch (num)
        {
            case 0:
                ClearLander = value;
                break;
            case 1:
                ClearLander += value;
                break;
            case 2:
                ClearLander = 0;
                break;
            default:

                break;
        }
    }

    public static void FirstData()
    {
        PlayerPrefs.SetInt("BootTimes", 0);
        PlayerPrefs.SetFloat("Volume", 0.5f);
        PlayerPrefs.SetFloat("Spin", 1.0f);
        PlayerPrefs.SetFloat("Zoom", 1.0f);
        PlayerPrefs.SetInt("ClearTimes", 0);

        PlayerPrefs.SetInt("BestScore", 0);
        PlayerPrefs.SetInt("BSBoost", 0);
        PlayerPrefs.SetInt("BSFuel", 0);
        PlayerPrefs.SetInt("BSAntenna", 0);
        PlayerPrefs.SetInt("BSLander", 0);

        PlayerPrefs.SetFloat("BestTime", 300.0f);
        PlayerPrefs.SetInt("BSBoost", 0);
        PlayerPrefs.SetInt("BSFuel", 0);
        PlayerPrefs.SetInt("BSAntenna", 0);
        PlayerPrefs.SetInt("BSLander", 0);

        PlayerPrefs.SetInt("ClearBoost", 0);
        PlayerPrefs.SetInt("ClearFuel", 0);
        PlayerPrefs.SetInt("ClearAntenna", 0);
        PlayerPrefs.SetInt("ClearLander", 0);
    }

    public static void InputData()
    {
        InputBootTimes(0, PlayerPrefs.GetInt("BootTimes"));
        InputVolume(0, PlayerPrefs.GetInt("Volume"));
        InputSpin(0, PlayerPrefs.GetInt("Spin"));
        InputZoom(0, PlayerPrefs.GetInt("Zoom"));
        InputClearTimes(0, PlayerPrefs.GetInt("ClearTimes"));
        InputBestScore(0, PlayerPrefs.GetInt("BestScore"));
        InputBSBoost(0, PlayerPrefs.GetInt("BSBoost"));
        InputBSFuel(0, PlayerPrefs.GetInt("BSFuel"));
        InputBSLander(0, PlayerPrefs.GetInt("BSLander"));
        InputBestTime(0, PlayerPrefs.GetFloat("BestTime"));
        InputBTBoost(0, PlayerPrefs.GetInt("BTBoost"));
        InputBTFuel(0, PlayerPrefs.GetInt("BTFuel"));
        InputBTAntenna(0, PlayerPrefs.GetInt("BTAntenna"));
        InputBTLander(0, PlayerPrefs.GetInt("BTLander"));
        InputClearBoost(0, PlayerPrefs.GetInt("ClearBoost"));
        InputClearFuel(0, PlayerPrefs.GetInt("ClearFuel"));
        InputClearAntenna(0, PlayerPrefs.GetInt("ClearAntenna"));
        InputClearLander(0, PlayerPrefs.GetInt("ClearLander"));
    }

    public static void DeleteData()
    {

    }
}
