using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SC_ExitGame : MonoBehaviour
{
    public void OnClickExitButton() {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape)) {
            SceneManager.LoadScene("GameTitle");
        }
    }
}
