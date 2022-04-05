using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//UI系のスクリプトを組むときは以下の追記を忘れずに
using UnityEngine.UI;
 
public class MuteBotton : MonoBehaviour
{
    //Toggle用のフィールド
    public Toggle toggle;
    //[SerializeField] private MonoBehaviour _component;

    public void OnToggleChanged()
    {
        if(toggle.isOn == true)
        {
            GetComponent<AudioListener>().enabled = false;
        }
        else
        {
            GetComponent<AudioListener>().enabled = true;
        }
    }
}