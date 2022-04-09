using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//UI系のスクリプトを組むときは以下の追記を忘れずに
using UnityEngine.UI;

public class DeleteSaveData : MonoBehaviour
{
    //Toggle用のフィールド
    public Toggle toggle;
    //[SerializeField] private MonoBehaviour _component;

    public void OnToggleChanged()
    {
        if (toggle.isOn == true)
        {
            DataStorage.FirstData();
            Debug.Log("データを初期化しました");
        }
    }
}
