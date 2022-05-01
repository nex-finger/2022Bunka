using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//Sliderを使用するために必要

[RequireComponent(typeof(Slider))]

public class SensiSlider : MonoBehaviour
{

    public static Slider m_Slider;//音量調整用スライダー

    [SerializeField]
    bool m_isInput;//キー入力で調整バーを動かせるようにするか
    [SerializeField]

    void Awake()
    {
        m_Slider = GetComponent<Slider>();
        m_Slider.value = SettingStorage.GetSensi_Zoom();
    }

    void Update()
    {
        SettingStorage.InputSensi_Zoom(0, m_Slider.value);
        //Debug.Log(m_Slider.value);
    }
}
