﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SC_GameTitle : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape)) {
            SceneManager.LoadScene("GameTitle");
        }
    }
}
