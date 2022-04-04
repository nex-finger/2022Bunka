using UnityEngine;
using UnityEngine.UI;

public class DisplaySoundMaster : MonoBehaviour
{
    // UI Text指定用
    public Text TextVolume;
    // 表示する変数
    private float volume;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        volume = SoundSlider.GetMasterVolume();
        //Debug.Log(volume);
        TextVolume.text = string.Format("{0:F2}", volume);
    }
}