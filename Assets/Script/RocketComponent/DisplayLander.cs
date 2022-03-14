using UnityEngine;
using UnityEngine.UI;

public class DisplayLander : MonoBehaviour
{
    // UI Text指定用
    public Text TextLander;
    // 表示する変数
    private int Lander;

    // Use this for initialization
    void Start()
    {
        Lander = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Lander = LevelStorage.GetLander();
        TextLander.text = string.Format("{0}", Lander);
    }
}