using UnityEngine;
using UnityEngine.UI;

public class DisplayBoost : MonoBehaviour
{
    // UI Text指定用
    public Text TextBoost;
    // 表示する変数
    private int Boost;

    // Use this for initialization
    void Start()
    {
        Boost = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Boost = LevelStorage.GetBoost();
        TextBoost.text = string.Format("{0}", Boost);
    }
}