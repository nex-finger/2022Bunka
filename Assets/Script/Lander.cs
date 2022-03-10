using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lander : MonoBehaviour
{
    // 入力による制御
    float RCS_Power;
    float Boost_Power;
    float R_acc_x, R_acc_y;
    Vector3 Rocket_Angle;
    float Rotate_acc;
    float Rocket_x, Rocket_y;

    void Reset_Value_Rocket()
    {
        R_acc_x = 0;
        R_acc_y = 0;
        Rocket_Angle = new Vector3(0, 0, 0);
        Rotate_acc = 0;
    }

    void Rocket_Boost()
    {
        if (Input.GetKey("space") || Input.GetMouseButton(2))
        {
            Rocket_Angle = GameObject.Find("Rocket").transform.localEulerAngles;

            // 角度をラジアンに変換
            float Angle = Rocket_Angle.z * Mathf.Deg2Rad;
            // ラジアンから進行方向を設定
            Vector3 Boost_acc = new Vector3(Mathf.Cos(Angle), Mathf.Sin(Angle), 0);
            Boost_acc.x = Boost_acc.x * Boost_Power;
            Boost_acc.y = Boost_acc.y * Boost_Power;

            R_acc_x += Boost_acc.x;
            R_acc_y += Boost_acc.y;

            Boost_acc.x = 0;
            Boost_acc.y = 0;
        }
    }

    void Rocket_Rotate()
    {
        // スタビライズする
        if (Rotate_acc > 0)
        {
            if (Rotate_acc < 0.01f)
            {
                Rotate_acc = 0;
            }
            Rotate_acc -= 0.01f;
        }
        else if (Rotate_acc < 0)
        {
            if (Rotate_acc > 0.01f)
            {
                Rotate_acc = 0;
            }
            Rotate_acc += 0.01f;
        }

        // z軸（２次元座標では回転軸はひとつしかないため）の回転の取得する
        Rocket_Angle = GameObject.Find("Rocket").transform.localEulerAngles;

        // クリックによる加速度の増減
        if (Input.GetMouseButton(0))
        {
            Rotate_acc += 0.03f;
        }

        if (Input.GetMouseButton(1))
        {
            Rotate_acc -= 0.03f;
        }

        // 1フレームで回転する量を代入
        // transform.localEulerAngles.z = new Vector3(0, 0, Rocket_Angle + Rotate_acc);

        Rocket_Angle.z += Rotate_acc;
        GameObject.Find("Rocket").transform.localEulerAngles = Rocket_Angle;
    }

    void Accel_cal()
    {
        // 考慮します＾＾
        Rocket_x += R_acc_x * Time.deltaTime;
        Rocket_y += R_acc_y * Time.deltaTime;

        // 反映させる
        transform.position = new Vector3(Rocket_x, Rocket_y, 0);
    }

    void Reset()
    {
        // 加速度の初期化
        R_acc_x = 0.0f;
        R_acc_y = 0.0f;
    }

    // Start is called before the first frame update
    void Start()
    {
        // 変数のリセット
        Reset_Value_Rocket();

        //Boost_Power = Input_Value.Boost_Power;
        //RCS_Power = Input_Value.RCS_Power;

        GameObject hoge = GameObject.FindGameObjectWithTag("hujisawa");

        Boost_Power = hoge.GetComponent<tmp_1>().Boost_Power;

        // Debug.Log(Boost_Power);
        // Debug.Log(RCS_Power);
    }

    // Update is called once per frame
    void Update()
    {
        // ブースターによる制御
        Rocket_Boost();

        // ロケットの回転とSAS
        Rocket_Rotate();

        // 最終的にロケットに与えられる可読度の合計とフレーム遷移による時間の移行
        Accel_cal();

        // 初期化
        Reset();

    }
}
