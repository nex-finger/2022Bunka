using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelStorage : MonoBehaviour
{
    public Text label;

    public static int BoostLevel;
    public static int FuelLevel;
    public static int AntennaLevel;
    public static int LanderLevel;

    public static int GetBoost()
    {
        return BoostLevel;
    }
    public static int GetFuel()
    {
        return FuelLevel;
    }
    public static int GetAntenna()
    {
        return AntennaLevel;
    }
    public static int GetLander()
    {
        return LanderLevel;
    }

    public int BoostLimit;
    public int FuelLimit;
    public int AntennaLimit;
    public int LanderLimit;

    private int[] CostBoost = new int[] {200, 300, 500, 700};
    private int[] CostFuel = new int[] {100, 250, 400, 700};
    private int[] CostAntenna = new int[] {150, 400, 200, 400};
    private int[] CostLander = new int[] {350, 200, 250, 200};

    public static int TotalCash;
    public static int GetCash()
    {
        return TotalCash;
    }

    public static float TotalTime;
    public static float GetTotalTime(int a)
    {
        if(a == 0)
        {
            TotalTime += Time.deltaTime;
        }
        else
        {
            TotalTime = 0.0f;
        }

        return TotalTime;
    }

    void Start()
    {
        BoostLevel = 1;
        FuelLevel = 1;
        AntennaLevel = 1;
        LanderLevel = 1;

        TotalCash = 0;
        TotalTime = 0.0f;
    }

    // 数値を増やすボタンのOn Click()に指定
    public void BoostUp()
    {
        // UpdateLabel()内で分岐をすると、表示とcountの値がずれてしまうので、移行して条件も少し変更
        if (BoostLevel < BoostLimit)
        {
            BoostLevel++;
            TotalCash += CostBoost[BoostLevel - 2];
        }
    }

    // 数値を減らすボタンのOn Click()に指定
    public void BoostDown()
    {
        if (BoostLevel != 1)
        {
            BoostLevel--;
            TotalCash -= CostBoost[BoostLevel - 1];
        }
    }

    public void FuelUp()
    {
        // UpdateLabel()内で分岐をすると、表示とcountの値がずれてしまうので、移行して条件も少し変更
        if (FuelLevel < FuelLimit)
        {
            FuelLevel++;
            TotalCash += CostFuel[FuelLevel - 2];
        }
    }

    // 数値を減らすボタンのOn Click()に指定
    public void FuelDown()
    {
        if (FuelLevel != 1)
        {
            FuelLevel--;
            TotalCash -= CostFuel[FuelLevel - 1];
        }
    }

    public void AntennaUp()
    {
        // UpdateLabel()内で分岐をすると、表示とcountの値がずれてしまうので、移行して条件も少し変更
        if (AntennaLevel < AntennaLimit)
        {
            AntennaLevel++;
            TotalCash += CostAntenna[AntennaLevel - 2];
        }
    }

    // 数値を減らすボタンのOn Click()に指定
    public void AntennaDown()
    {
        if (AntennaLevel != 1)
        {
            AntennaLevel--;
            TotalCash -= CostAntenna[AntennaLevel - 1];
        }
    }

    public void LanderUp()
    {
        // UpdateLabel()内で分岐をすると、表示とcountの値がずれてしまうので、移行して条件も少し変更
        if (LanderLevel < LanderLimit)
        {
            LanderLevel++;
            TotalCash += CostLander[LanderLevel - 2];
        }
    }

    // 数値を減らすボタンのOn Click()に指定
    public void LanderDown()
    {
        if (LanderLevel != 1)
        {
            LanderLevel--;
            TotalCash -= CostLander[LanderLevel - 1];
        }
    }
}