using UnityEngine;
using UnityEngine.UI;

public class DisplayCashLimit : MonoBehaviour
{
    // UI Text指定用
    public Text TextCashLimit;
    // 表示する変数
    public int CashLimit;

    // Use this for initialization
    void Start()
    {
        TextCashLimit.text = string.Format("/ {0}", CashLimit);
    }
}