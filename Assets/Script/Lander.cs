using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class Lander : MonoBehaviour
{
    private float LandingPower;
    public float RandomRange;
    public float BoostRange;
    private int BoostLevel;
    private Rigidbody2D _rigidbody2D;
    private Vector3 _reset;
    [SerializeField] private Vector3 _acceleration;

    private void Awake()
    {
        _rigidbody2D = this.GetComponent<Rigidbody2D>();

        float StartRandom;

        float StartAngle = Random.Range(0, 360);
        GameObject.Find("Rocket").transform.localEulerAngles = Rocket_Angle;

        StartRandom = Random.Range(-RandomRange, RandomRange);

        Vector3 StartForce = new Vector3(StartRandom, 0.0f, 0.0f);  // 力を設定
        _rigidbody2D.AddForce(StartForce, ForceMode2D.Impulse);
    }

    // 入力による制御
    float RCS_Power;
    float Boost_Power;
    float R_acc_x, R_acc_y;
    Vector3 Rocket_Angle;
    float Rotate_acc;
    float Rocket_x, Rocket_y;
    Vector3 Boost_acc;

    float VecX, VecY;

    void Reset_Value_Rocket()
    {
        Rocket_Angle = new Vector3(0, 0, 0);
        Rotate_acc = 0;

        SensiSpin = 0.02f * PlayerPrefs.GetFloat("Spin");
        SensiSAS = 0.3f * SensiSpin;
    }

    void RocketComponent()
    {
        int BoostLevel = 1;
        float[] BoostRatio = new float[] { 1.05f, 1.20f, 1.50f, 2.00f, 5.00f };

        BoostLevel = LevelStorage.GetBoost();
        LandingPower = BoostRange * BoostRatio[BoostLevel - 1];
        //LandingPower = 5.0f;

        //Debug.Log(LandingPower);
    }

    void Rocket_Boost()
    {
        if (Input.GetMouseButton(2))
        {
            Rocket_Angle = GameObject.Find("Rocket").transform.localEulerAngles;

            // 角度をラジアンに変換
            float Angle = Rocket_Angle.z * Mathf.Deg2Rad;
            // ラジアンから進行方向を設定
            Boost_acc = new Vector3(Mathf.Cos(Angle), Mathf.Sin(Angle), 0);
            //Boost_acc.x = LandingPower * Boost_acc.x;
            //Boost_acc.y = LandingPower * Boost_acc.y;

            _rigidbody2D.AddForce(Boost_acc, ForceMode2D.Force);
        }
    }

    private float SensiSpin;
    private float SensiSAS;

    void Rocket_Rotate()
    {
        // スタビライズする
        if (Rotate_acc > 0)
        {
            if (Rotate_acc < SensiSAS)
            {
                Rotate_acc = 0;
            }
            Rotate_acc -= SensiSAS;
        }
        else if (Rotate_acc < 0)
        {
            if (Rotate_acc > SensiSAS)
            {
                Rotate_acc = 0;
            }
            Rotate_acc += SensiSAS;
        }

        // z軸（２次元座標では回転軸はひとつしかないため）の回転の取得する
        Rocket_Angle = GameObject.Find("Rocket").transform.localEulerAngles;

        // クリックによる加速度の増減
        if (Input.GetMouseButton(0))
        {
            Rotate_acc += SensiSpin;
        }

        if (Input.GetMouseButton(1))
        {
            Rotate_acc -= SensiSpin;
        }

        // 1フレームで回転する量を代入
        // transform.localEulerAngles.z = new Vector3(0, 0, Rocket_Angle + Rotate_acc);

        Rocket_Angle.z += Rotate_acc;
        GameObject.Find("Rocket").transform.localEulerAngles = Rocket_Angle;
    }

    void LayrUpdate()
    {
        _reset = new Vector3(0, 0, 0);
        _rigidbody2D.AddForce(_reset, ForceMode2D.Force);
    }

    // Start is called before the first frame update
    void Start()
    {
        // 変数のリセット
        Reset_Value_Rocket();

        //Boost_Power = Input_Value.Boost_Power;
        //RCS_Power = Input_Value.RCS_Power;

        //GameObject hoge = GameObject.FindGameObjectWithTag("hujisawa");

        //Boost_Power = hoge.GetComponent<tmp_1>().Boost_Power;

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
    }
}
