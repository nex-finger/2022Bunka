using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SCVoyage : MonoBehaviour
{
    private int Cash;
    private int Limit;

    public void OnClick()
    {
        Cash = LevelStorage.GetCash();
        Limit = DataStorage.GetLimit();
        if(Cash <= Limit)
        {
            SceneManager.LoadScene("Voyage");
        }
    }
}
