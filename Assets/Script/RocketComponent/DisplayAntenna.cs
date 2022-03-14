using UnityEngine;
using UnityEngine.UI;

public class DisplayAntenna : MonoBehaviour
{
    // UI Text指定用
    public Text TextAntenna;
    // 表示する変数
    private int Antenna;

    // Use this for initialization
    void Start()
    {
        Antenna = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Antenna = LevelStorage.GetAntenna();
        TextAntenna.text = string.Format("{0}", Antenna);
    }
}