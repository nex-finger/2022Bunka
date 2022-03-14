using UnityEngine;
using UnityEngine.UI;

public class DisplayFuel : MonoBehaviour
{
    // UI Text指定用
    public Text TextFuel;
    // 表示する変数
    private int Fuel;

    // Use this for initialization
    void Start()
    {
        Fuel = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Fuel = LevelStorage.GetFuel();
        TextFuel.text = string.Format("{0}", Fuel);
    }
}
