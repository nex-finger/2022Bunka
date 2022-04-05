using UnityEngine;
using UnityEngine.UI;

public class DisplayZoom : MonoBehaviour
{
    // UI Text指定用
    public Text TextZoom;
    // 表示する変数
    private float zoom;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        zoom = SettingStorage.GetSensi_Zoom();
        TextZoom.text = string.Format("{0:F2}", zoom);
        //Debug.Log(spin);
    }
}