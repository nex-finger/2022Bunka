using UnityEngine;
using UnityEngine.UI;

public class DisplayCashLimit : MonoBehaviour
{
    // UI Text指定用
    public Text TextCashLimit;
    // 表示する変数
    private int CashLimit;

    // Use this for initialization
    void Start()
    {
        CashLimit = DataStorage.GetLimit();
        TextCashLimit.text = string.Format("/ {0}", CashLimit);
    }
}