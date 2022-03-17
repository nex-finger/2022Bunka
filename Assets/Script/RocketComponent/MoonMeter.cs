using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonMeter : MonoBehaviour
{
    public GameObject Item;

    private float LanderLevel;
    private Vector2 RocketPlace, MoonPlace;
    private float red, green, blue, alfa;

    // Start is called before the first frame update
    void Start()
    {
        LanderLevel = LevelStorage.GetLander();

        if (LanderLevel == 1)
        {
            Item.GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //this.GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);

        RocketPlace.x = GameObject.Find("Rocket").transform.position.x;
        RocketPlace.y = GameObject.Find("Rocket").transform.position.y;
        MoonPlace.x = GameObject.Find("Moon_tmp").transform.position.x;
        MoonPlace.y = GameObject.Find("Moon_tmp").transform.position.y;
    }
}