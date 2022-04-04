using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//UI系のスクリプトを組むときは以下の追記を忘れずに
using UnityEngine.UI;
 
public class MuteBotton : MonoBehaviour
{
    //Toggle用のフィールド
    public Toggle toggle;

    public void OnToggleChanged()
    {
        if(toggle.isOn == true)
        {
            SettingStorage.InputVolume(0, 0.0f);
            AudioListener.volume = 0.0f;
        }
        else
        {
            SettingStorage.InputVolume(2, 0.0f);
            AudioListener.volume = 0.5f;
        }
    }
}