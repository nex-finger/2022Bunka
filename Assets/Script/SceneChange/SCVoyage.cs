using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SCVoyage : MonoBehaviour
{
    private int Cash;

    public void OnClick()
    {
        Cash = LevelStorage.GetCash();
        if(Cash <= 3000)
        {
            SceneManager.LoadScene("Voyage");
        }
    }
}
