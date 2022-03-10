using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    public float Ratio;
    private float Limit;
    float MouseWheel;

    Transform tf; //Main CameraのTransform
    Camera cam; //Main CameraのCamera

    // Start is called before the first frame update
    void Start()
    {
        tf = this.gameObject.GetComponent<Transform>(); //Main CameraのTransformを取得する。
        cam = this.gameObject.GetComponent<Camera>(); //Main CameraのCameraを取得する。

        Limit = Input_Value.GetLimit();
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
        }
    }
}