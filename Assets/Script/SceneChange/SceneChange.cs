using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void SCHowtoPlay()
    {
        SceneManager.LoadScene("HowtoPlay");
    }

    public void SCGallery()
    {
        SceneManager.LoadScene("Gallery");
    }

    public void SCGameTitle()
    {
        SceneManager.LoadScene("GameTitle");
    }

    public void SCArcadeStart()
    {
        SceneManager.LoadScene("ArcadeStart");
    }

    public void SCSetting()
    {
        SceneManager.LoadScene("Setting");
    }

    public void SCArcadeLanding()
    {
        SceneManager.LoadScene("ArcadeLanding");
    }
}
