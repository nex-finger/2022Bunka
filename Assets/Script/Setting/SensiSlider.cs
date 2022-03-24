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

    public static float GetMasterVolume()
    {
        return m_Slider.value;
    }

    void Awake()
    {
        m_Slider = GetComponent<Slider>();
        m_Slider.value = GetMasterVolume();
    }

    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }
}
