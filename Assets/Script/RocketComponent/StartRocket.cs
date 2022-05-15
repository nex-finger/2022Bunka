using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartRocket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DataStorage.InputLimit(1);
        SettingStorage.InputSensi_Zoom(0, 0.1f);
        SettingStorage.InputSensi_Rotate(0, 0.1f);

        DataStorage.SaveData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
