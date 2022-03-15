using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rocket : MonoBehaviour
{
    Vector2 E_Earth_place;
    Vector2 E_Rocket_place;

    // 初速度に関する変数
    public float E_ini_Speed;
    public float E_ini_Angle;
    Vector3 E_ini_vec;

    // 過去２フレームの座標と仮置きの３フレーム目の座標
    float E_place_1_x, E_place_1_y, E_place_2_x, E_place_2_y;
    float E_place_3_x_tmp, E_place_3_y_tmp, E_place_3_x, E_place_3_y;

    // 加速させる向き
    float E_acc_x, E_acc_y;

    float E_Rocket_dis_x, E_Rocket_dis_y; // 月と地球の距離
    float E_vec_RE; // xyベクトル
    float E_Nor_x, E_Nor_y; // 正規化した座標（ここでは地球）
    float E_Angle; // 角度
    float E_Distance_2; // 距離の２乗
    public float Gravity; // 万有引力定数
    float E_Earth_mass = 16.0f; // 地球の質量
    // float Rocket_mass = 1.0f; // 月の質量
    float E_vec; // ロケットに与える加速度

    Vector2 M_Moon_place;
    Vector2 M_Rocket_place;

    // 初速度に関する変数
    public float M_ini_Speed;
    public float M_ini_Angle;
    Vector3 M_ini_vec;

    // 過去２フレームの座標と仮置きの３フレーム目の座標
    float M_place_1_x, M_place_1_y, M_place_2_x, M_place_2_y;
    float M_place_3_x_tmp, M_place_3_y_tmp, M_place_3_x, M_place_3_y;

    // 加速させる向き
    float M_acc_x, M_acc_y;

    float M_Rocket_dis_x, M_Rocket_dis_y; // 月と地球の距離
    float M_vec_RE; // xyベクトル
    float M_Nor_x, M_Nor_y; // 正規化した座標（ここでは地球）
    float M_Angle; // 角度
    float M_Distance_2; // 距離の２乗
    // float M_Earth_mass = 4.0f; // 地球の質量
    float M_Moon_mass = 4.0f; // 月の質量
    float M_vec; // ロケットに与える加速度

    // 入力による制御
    float RCS_Power;
    float Boost_Power;
    float R_acc_x, R_acc_y;
    Vector3 Rocket_Angle;
    float Rotate_acc;

    public float BoostRange;



    void Reset_Value_Rocket()
    {
        E_Earth_place = new Vector2(0, 0);
        E_Rocket_place = new Vector2(0, 0);
        E_ini_vec = new Vector3(0, 0, 0);

        E_place_1_x = 0;
        E_place_1_y = 0;
        E_place_2_x = 0;
        E_place_2_y = 0;
        E_place_3_x_tmp = 0;
        E_place_3_y_tmp = 0;
        E_place_3_x = 0;
        E_place_3_y = 0;

        E_Rocket_dis_x = 0;
        E_Rocket_dis_y = 0;
        E_vec_RE = 0;
        E_Nor_x = 0;
        E_Nor_y = 0;
        E_Angle = 0;
        E_Distance_2 = 0;

        E_acc_x = 0;
        E_acc_y = 0;
        E_vec = 0;

        E_Earth_place = new Vector2(0, 0);
        E_Rocket_place = new Vector2(0, 0);
        E_ini_vec = new Vector3(0, 0, 0);

        M_place_1_x = 0;
        M_place_1_y = 0;
        M_place_2_x = 0;
        M_place_2_y = 0;
        M_place_3_x_tmp = 0;
        M_place_3_y_tmp = 0;
        // M_place_3_x = 0;
        // M_place_3_y = 0;

        M_Rocket_dis_x = 0;
        M_Rocket_dis_y = 0;
        M_vec_RE = 0;
        M_Nor_x = 0;
        M_Nor_y = 0;
        M_Angle = 0;
        M_Distance_2 = 0;

        M_acc_x = 0;
        M_acc_y = 0;
        M_vec = 0;

        R_acc_x = 0;
        R_acc_y = 0;
        Rocket_Angle = new Vector3(0, 0, 0);
        Rotate_acc = 0;
}

    void RocketComponent()
    {
        int BoostLevel = 1;
        float[] BoostRatio = new float[] {1.05f, 1.20f, 1.50f, 2.00f, 5.00f};

        BoostLevel = LevelStorage.GetBoost();
        Boost_Power = BoostRange * BoostRatio[BoostLevel - 1];

        //Debug.Log(Boost_Power);
    }

    void Earth_setup()
    {
        // 月に持たせる初速度
        // 角度をラジアンに変換
        float E_ini_rad = E_ini_Angle * Mathf.Deg2Rad;
        // ラジアンから進行方向を設定
        Vector3 E_direction = new Vector3(Mathf.Cos(E_ini_rad), Mathf.Sin(E_ini_rad), 0);
        // 方向に速度を掛け合わせて移動ベクトルを求める
        E_ini_vec = E_direction * E_ini_Speed * Time.deltaTime;

        // 過去フレームの座標を予想
        E_place_1_x = transform.position.x - E_ini_vec.x;
        E_place_1_y = transform.position.y - E_ini_vec.y;

        // xフレーム目の座標を保存する
        E_place_2_x = transform.position.x;
        E_place_2_y = transform.position.y;

        // Debug.Log("Earth_setup Success");
    }

    void Moon_setup()
    {
        // 月に持たせる初速度
        // 角度をラジアンに変換
        float M_ini_rad = M_ini_Angle * Mathf.Deg2Rad;
        // ラジアンから進行方向を設定
        Vector3 M_direction = new Vector3(Mathf.Cos(M_ini_rad), Mathf.Sin(M_ini_rad), 0);
        // 方向に速度を掛け合わせて移動ベクトルを求める
        M_ini_vec = M_direction * M_ini_Speed * Time.deltaTime;

        // 過去フレームの座標を予想
        M_place_1_x = transform.position.x - M_ini_vec.x;
        M_place_1_y = transform.position.y - M_ini_vec.y;

        // xフレーム目の座標を保存する
        M_place_2_x = transform.position.x;
        M_place_2_y = transform.position.y;

        // Debug.Log("Moon_setup Success");
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

    void Earth_acc()
    {
        // 初速度を考慮する
        if (Time.frameCount == 1)
        {
            transform.position += E_ini_vec;
        }

        // Earth_place.x, Earth_place.y 地球のx座標, 地球のy座標
        // Rocket_place.x, Rocket_place.y 月のx座標, 月のy座標
        E_Earth_place = GameObject.Find("Earth_tmp").transform.position;
        E_Rocket_place = GameObject.Find("Rocket").transform.position;

        // 月を原点としたときの地球の角度
        E_Rocket_dis_x = E_Earth_place.x - E_Rocket_place.x;
        E_Rocket_dis_y = E_Earth_place.y - E_Rocket_place.y;
        E_vec_RE = Mathf.Sqrt(E_Rocket_dis_x * E_Rocket_dis_x + E_Rocket_dis_y * E_Rocket_dis_y);

        E_Nor_x = E_Rocket_dis_x / E_vec_RE;
        E_Nor_y = E_Rocket_dis_y / E_vec_RE;

        E_Angle = Mathf.Acos(E_Nor_x) / Mathf.PI;
        if (E_Nor_y < 0)
        {
            E_Angle = 2 - E_Angle;
        }

        // 地球と月の距離の２乗
        E_Distance_2 = E_Rocket_dis_x * E_Rocket_dis_x + E_Rocket_dis_y * E_Rocket_dis_y;

        // 月に働く万有引力
        E_vec = (Gravity * E_Earth_mass) / (E_Distance_2);

        // 実際に加速度をxyで出す
        E_acc_x = E_vec * Mathf.Cos(Mathf.PI * E_Angle);
        E_acc_y = E_vec * Mathf.Sin(Mathf.PI * E_Angle);

        // 加速度を考慮しない３フレーム目の座標
        E_place_3_x_tmp = E_place_2_x + E_place_2_x - E_place_1_x;
        E_place_3_y_tmp = E_place_2_y + E_place_2_y - E_place_1_y;

        // 考慮します＾＾
        E_place_3_x = E_place_3_x_tmp + E_acc_x;
        E_place_3_y = E_place_3_y_tmp + E_acc_y;
    }

    void Moon_acc()
    {
        // Moon_place.x, Moon_place.y 地球のx座標, 地球のy座標
        // Rocket_place.x, Rocket_place.y 月のx座標, 月のy座標
        M_Moon_place = GameObject.Find("Moon_tmp").transform.position;
        M_Rocket_place = GameObject.Find("Rocket").transform.position;

        // 月を原点としたときの地球の角度
        M_Rocket_dis_x = M_Moon_place.x - M_Rocket_place.x;
        M_Rocket_dis_y = M_Moon_place.y - M_Rocket_place.y;
        M_vec_RE = Mathf.Sqrt(M_Rocket_dis_x * M_Rocket_dis_x + M_Rocket_dis_y * M_Rocket_dis_y);

        M_Nor_x = M_Rocket_dis_x / M_vec_RE;
        M_Nor_y = M_Rocket_dis_y / M_vec_RE;

        M_Angle = Mathf.Acos(M_Nor_x) / Mathf.PI;
        if (M_Nor_y < 0)
        {
            M_Angle = 2 - M_Angle;
        }

        // 地球と月の距離の２乗
        M_Distance_2 = M_Rocket_dis_x * M_Rocket_dis_x + M_Rocket_dis_y * M_Rocket_dis_y;

        // 月に働く万有引力
        M_vec = (Gravity * M_Moon_mass) / (M_Distance_2);

        // 実際に加速度をxyで出す
        M_acc_x = M_vec * Mathf.Cos(Mathf.PI * M_Angle);
        M_acc_y = M_vec * Mathf.Sin(Mathf.PI * M_Angle);

        // 加速度を考慮しない３フレーム目の座標
        M_place_3_x_tmp = M_place_2_x + M_place_2_x - M_place_1_x;
        M_place_3_y_tmp = M_place_2_y + M_place_2_y - M_place_1_y;
    }

    void Accel_cal()
    {
        // 考慮します＾＾
        E_place_3_x = E_place_3_x_tmp + (E_acc_x + M_acc_x + R_acc_x) * Time.deltaTime;
        E_place_3_y = E_place_3_y_tmp + (E_acc_y + M_acc_y + R_acc_y) * Time.deltaTime;

        // 反映させる
        transform.position = new Vector3(E_place_3_x, E_place_3_y, 0);

        // １フレームずつ移動させる
        E_place_1_x = E_place_2_x;
        E_place_1_y = E_place_2_y;
        E_place_2_x = E_place_3_x;
        E_place_2_y = E_place_3_y;

        // １フレームずつ移動させる
        M_place_1_x = E_place_2_x;
        M_place_1_y = E_place_2_y;
        M_place_2_x = E_place_3_x;
        M_place_2_y = E_place_3_y;
    }

    void SceneChange()
    {
        if(M_vec_RE < 0.5f)
        {
            SceneManager.LoadScene("Landing");
        }

        if(E_vec_RE > 50.0f)
        {
            SceneManager.LoadScene("GameOver1");
        }

        if (E_vec_RE < 0.5f)
        {
            SceneManager.LoadScene("GameOver2");
        }
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

        // Boost_Power = Input_Value.GetBoost();
        // ロケットの性能の更新
        RocketComponent();

        // 地球に関する初期設定
        Earth_setup();
        
        // 月
        Moon_setup();
    }

    // Update is called once per frame
    void Update()
    {
        // 初速度を考慮する
        if (Time.frameCount == 1)
        {
            transform.position += M_ini_vec;
        }

        // ブースターによる制御
        Rocket_Boost();

        // ロケットの回転とSAS
        Rocket_Rotate();

        // 地球がロケットに与える加速度について
        Earth_acc();

        // 月がロケットに与える加速度について
        Moon_acc();

        // 最終的にロケットに与えられる可読度の合計とフレーム遷移による時間の移行
        Accel_cal();

        // シーン変移について
        SceneChange();

        // 初期化
        Reset();
        
    }
}
