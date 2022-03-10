using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Input_Value : MonoBehaviour
{
    //InputFieldに入力されたものを受け取る。受け取る時の形式はInputField
    public float Boost_Power;
    //public float RCS_Power;
    public float Moon_Speed;

    InputField text_Boost;
    //InputField text_RCS;
    InputField text_Moon;
    InputField text_Limit;

    //シーン間で保存される変数
    public static float SaveBoost = 0;
    public static float GetBoost()
    {
        return SaveBoost;
    }

    public static float SaveMoon = 0;
    public static float GetMoon()
    {
        return SaveMoon;
    }

    public static float SaveLimit = 0;
    public static float GetLimit()
    {
        return SaveLimit;
    }

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
        //Textコンポーネントの取得は最初の一度だけでいいので、Start内で行う
        text_Boost = GameObject.Find("InputField_Boost").GetComponent<InputField>();
        //text_RCS = GameObject.Find("InputField_RCS").GetComponent<InputField>();
        text_Moon = GameObject.Find("InputField_Moon").GetComponent<InputField>();
        text_Limit = GameObject.Find("InputField_Limit").GetComponent<InputField>();

        SaveBoost = float.Parse(text_Boost.text);
        //RCS_Power = float.Parse(text_RCS.text);
        SaveMoon = float.Parse(text_Moon.text);
        SaveLimit = float.Parse(text_Limit.text);

        SceneManager.LoadScene("Voyage");
    }
}