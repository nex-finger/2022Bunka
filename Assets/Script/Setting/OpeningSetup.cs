using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningSetup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioListener.volume = 0.1f;
        SettingStorage.InputSensi_Rotate(0, 0.5f);
        SettingStorage.InputSensi_Zoom(0, 0.5f);
    }
}
