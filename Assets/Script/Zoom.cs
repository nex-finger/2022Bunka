using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    private float Ratio;
    private float Limit;
    private float MouseWheel;
    private int AntennaLevel;

    Transform tf; //Main CameraのTransform
    Camera cam; //Main CameraのCamera

    // Start is called before the first frame update
    void Start()
    {
        tf = this.gameObject.GetComponent<Transform>(); //Main CameraのTransformを取得する。
        cam = this.gameObject.GetComponent<Camera>(); //Main CameraのCameraを取得する。

        Ratio = SettingStorage.GetSensi_Zoom();
        Ratio = 1.0f + (0.1f * Ratio);

        float[] CameraLevel = new float[] { 2.0f, 3.0f, 3.0f, 4.0f, 4.0f };
        AntennaLevel = LevelStorage.GetAntenna();

        Limit = CameraLevel[AntennaLevel - 1];
    }

    // Update is called once per frame
    void Update()
    {
        MouseWheel = Input.GetAxis("Mouse ScrollWheel"); //Iキーが押されていれば
        if (MouseWheel > 0)
        {
            cam.orthographicSize = cam.orthographicSize * Ratio; //ズームアウト。
            if (cam.orthographicSize > Limit)
            {
                cam.orthographicSize = Limit;
            }
        }
        else if (MouseWheel < 0)
        {
            cam.orthographicSize = cam.orthographicSize * (1 / Ratio); //ズームイン。
            if (cam.orthographicSize < 0.5f)
            {
                cam.orthographicSize = 0.5f;
            }
        }

        //Debug.Log(cam.orthographicSize);
    }
}