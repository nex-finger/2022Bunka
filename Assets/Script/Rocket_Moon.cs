using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket_Moon : MonoBehaviour
{
    Vector2 Moon_place;
    Vector2 Rocket_place;

    // 初速度に関する変数
    public float ini_Speed;
    public float ini_Angle;
    Vector3 ini_vec;

    // 過去２フレームの座標と仮置きの３フレーム目の座標
    float place_1_x, place_1_y, place_2_x, place_2_y;
    float place_3_x_tmp, place_3_y_tmp, place_3_x, place_3_y;

    // 加速指せる向き
    float acc_x, acc_y;

    float Rocket_dis_x, Rocket_dis_y; // 月と地球の距離
    float vec_RE; // xyベクトル
    float Nor_x, Nor_y; // 正規化した座標（ここでは地球）
    float Angle; // 角度
    float Distance_2; // 距離の２乗
    public float Gravity; // 万有引力定数
    // float Earth_mass = 4.0f; // 地球の質量
    float Moon_mass = 2.0f; // 月の質量
    float vec; // ロケットに与える加速度

    // Start is called before the first frame update
    void Start()
    {
        // 月に持たせる初速度
        // 角度をラジアンに変換
        float ini_rad = ini_Angle * Mathf.Deg2Rad;
        // ラジアンから進行方向を設定
        Vector3 direction = new Vector3(Mathf.Cos(ini_rad), Mathf.Sin(ini_rad), 0);
        // 方向に速度を掛け合わせて移動ベクトルを求める
        ini_vec = direction * ini_Speed * Time.deltaTime;

        // 過去フレームの座標を予想
        place_1_x = transform.position.x - ini_vec.x;
        place_1_y = transform.position.y - ini_vec.y;

        // xフレーム目の座標を保存する
        place_2_x = transform.position.x;
        place_2_y = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        // 初速度を考慮する
        if (Time.frameCount == 1)
        {
            transform.position += ini_vec;
        }

        // Moon_place.x, Moon_place.y 地球のx座標, 地球のy座標
        // Rocket_place.x, Rocket_place.y 月のx座標, 月のy座標
        Moon_place = GameObject.Find("Moon_tmp").transform.position;
        Rocket_place = GameObject.Find("Unitychan_Blink_1").transform.position;

        // 月を原点としたときの地球の角度
        Rocket_dis_x = Moon_place.x - Rocket_place.x;
        Rocket_dis_y = Moon_place.y - Rocket_place.y;
        vec_RE = Mathf.Sqrt(Rocket_dis_x * Rocket_dis_x + Rocket_dis_y * Rocket_dis_y);

        Nor_x = Rocket_dis_x / vec_RE;
        Nor_y = Rocket_dis_y / vec_RE;

        Angle = Mathf.Acos(Nor_x) / Mathf.PI;
        if (Nor_y < 0)
        {
            Angle = 2 - Angle;
        }

        // 地球と月の距離の２乗
        Distance_2 = Rocket_dis_x * Rocket_dis_x + Rocket_dis_y * Rocket_dis_y;

        // 月に働く万有引力
        vec = (Gravity * Moon_mass) / (Distance_2);

        // 実際に加速度をxyで出す
        acc_x = vec * Mathf.Cos(Mathf.PI * Angle);
        acc_y = vec * Mathf.Sin(Mathf.PI * Angle);

        // 加速度を考慮しない３フレーム目の座標
        place_3_x_tmp = place_2_x + place_2_x - place_1_x;
        place_3_y_tmp = place_2_y + place_2_y - place_1_y;

        // 考慮します＾＾
        place_3_x = place_3_x_tmp + acc_x;
        place_3_y = place_3_y_tmp + acc_y;

        // 反映させる
        transform.position = new Vector3(place_3_x, place_3_y, 0);

        // １フレームずつ移動させる
        place_1_x = place_2_x;
        place_1_y = place_2_y;
        place_2_x = place_3_x;
        place_2_y = place_3_y;
    }
}
