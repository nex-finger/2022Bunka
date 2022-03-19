using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestSlider : MonoBehaviour
{

    Slider hpSlider;

    // Use this for initialization
    void Start()
    {

        hpSlider = GetComponent<Slider>();

        float maxHp = 200f;
        float nowHp = 100f;


        //スライダーの最大値の設定
        hpSlider.maxValue = maxHp;

        //スライダーの現在値の設定
        hpSlider.value = nowHp;


    }

    // Update is called once per frame
    void Update()
    {

    }


}