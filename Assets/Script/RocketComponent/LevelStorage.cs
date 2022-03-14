using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public Text label;
    public int count;

    void Start()
    {
        count = 2;
        UpdateLabel();
    }

    // 数値を増やすボタンのOn Click()に指定
    public void Click1()
    {
        // UpdateLabel()内で分岐をすると、表示とcountの値がずれてしまうので、移行して条件も少し変更
        if (count < 30)
        {
            count++;
        }
        UpdateLabel();
    }

    // 数値を減らすボタンのOn Click()に指定
    public void Click2()
    {
        if (count > 2)
        {
            count--;
        }
        UpdateLabel();
    }

    void UpdateLabel()
    {
        label.text = count + "人";
    }
}