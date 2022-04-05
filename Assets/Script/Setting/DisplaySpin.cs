using UnityEngine;
using UnityEngine.UI;

public class DisplaySpin : MonoBehaviour
{
    // UI Text指定用
    public Text TextSpin;
    // 表示する変数
    private float spin;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        spin = SettingStorage.GetSensi_Rotate();
        TextSpin.text = string.Format("{0:F2}", spin);
        //Debug.Log(spin);
    }
}