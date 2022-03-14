using UnityEngine;
using UnityEngine.UI;

public class DisplayCash : MonoBehaviour
{
    // UI Text指定用
    public Text TextCash;
    // 表示する変数
    private int Cash;

    // Use this for initialization
    void Start()
    {
        Cash = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Cash = LevelStorage.GetCash();
        TextCash.text = string.Format("{0}", Cash);

        if(Cash > 3000)
        {
            TextCash.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
        }
        else if(Cash <= 3000)
        {
            TextCash.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        }
    }
}