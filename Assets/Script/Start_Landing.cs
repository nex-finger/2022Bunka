using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Start_Landing : MonoBehaviour
{
    //InputFieldに入力されたものを受け取る。受け取る時の形式はInputField
    public float Boost_Power;
    public float RCS_Power;
    public float Moon_Speed;

    InputField text_Boost;
    InputField text_RCS;
    InputField text_Moon;

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
        text_RCS = GameObject.Find("InputField_RCS").GetComponent<InputField>();
        text_Moon = GameObject.Find("InputField_Moon").GetComponent<InputField>();

        float Boost_Power = float.Parse(text_Boost.text);
        float RCS_Power = float.Parse(text_RCS.text);
        float Moon_Speed = float.Parse(text_Moon.text);

        GameObject hoge = GameObject.FindGameObjectWithTag("hujisawa");

        hoge.GetComponent<tmp_1>().Boost_Power = Boost_Power;
        hoge.GetComponent<tmp_1>().RCS_Power = RCS_Power;
        hoge.GetComponent<tmp_1>().Moon_Speed = Moon_Speed;

        SceneManager.LoadScene("Landing");
    }
}