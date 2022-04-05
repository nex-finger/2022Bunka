using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingRocket : MonoBehaviour
{
    private float Rotate_acc;
    private Vector3 Rocket_Angle;
    private float SensiSpin;
    private float SensiSAS;

    // Start is called before the first frame update
    void Start()
    {
        Rocket_Angle = new Vector3(0, 0, 0);
        Rotate_acc = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        SensiSpin = 0.05f * SettingStorage.GetSensi_Rotate();
        SensiSAS = 0.3f * SensiSpin;

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
}
