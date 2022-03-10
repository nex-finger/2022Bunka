using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SC_Arcade : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("ArcadeSelectDifficulty");
    }
}
