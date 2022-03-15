using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMoon : MonoBehaviour
{
    private float time;
    private Vector2 MoonPosition;

    // Start is called before the first frame update
    void Start()
    {
        time = Random.Range(0.0f, 80.0f);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time > 80.0f)
        {
            time -= 80.0f;
        }

        MoonPosition.x = 15.0f * Mathf.Sin((360.0f / 80.0f) * time * Mathf.Deg2Rad);
        MoonPosition.y = 15.0f * Mathf.Cos((360.0f / 80.0f) * time * Mathf.Deg2Rad);

        GameObject.Find("Moon_tmp").transform.position = new Vector3(MoonPosition.x, MoonPosition.y, 0);

        //Debug.Log(MoonPosition.x);
    }
}
