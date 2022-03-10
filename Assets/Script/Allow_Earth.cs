using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Allow_Earth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Earth_place;
        Vector3 Rocket_place;

        float Rocket_dis_x, Rocket_dis_y;
        float vec_RE;
        float Nor_x, Nor_y;
        float B_Angle, A_Angle;
        Vector3 F_Angle;

        // Earth_place.x, Earth_place.y 地球のx座標, 地球のy座標
        // Rocket_place.x, Rocket_place.y 月のx座標, 月のy座標
        Earth_place = GameObject.Find("Earth_tmp").transform.position;
        Rocket_place = GameObject.Find("Rocket").transform.position;

        // 月を原点としたときの地球の角度
        Rocket_dis_x = Earth_place.x - Rocket_place.x;
        Rocket_dis_y = Earth_place.y - Rocket_place.y;
        vec_RE = Mathf.Sqrt(Rocket_dis_x * Rocket_dis_x + Rocket_dis_y * Rocket_dis_y);

        Nor_x = Rocket_dis_x / vec_RE;
        Nor_y = Rocket_dis_y / vec_RE;

        B_Angle = Mathf.Acos(Nor_x) / Mathf.PI;
        if (Nor_y < 0)
        {
            B_Angle = 2 - B_Angle;
        }

        A_Angle = B_Angle * 180;

        F_Angle = GameObject.Find("Allow_Earth").transform.localEulerAngles;
        GameObject.Find("Allow_Earth").transform.localEulerAngles = new Vector3(0, 0, A_Angle);
    }
}
