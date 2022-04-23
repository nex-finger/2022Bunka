using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class Animation : MonoBehaviour
{
    public GameObject Moveobj1;
    public GameObject Moveobj2;
    public GameObject Moveobj3;
    public GameObject Moveobj4;
    public GameObject Canvas;

    //ボタンを押したときアニメーションする
    public void SCArcadeLanding()
    {
        DontDestroyOnLoad(Canvas);
        Moveobj1.transform.DOLocalMove(new Vector3(0, 288, 0), 1)
                .SetEase(Ease.InOutCubic);
        Moveobj2.transform.DOLocalMove(new Vector3(0, 96, 0), 1)
                .SetEase(Ease.InOutCubic);
        Moveobj3.transform.DOLocalMove(new Vector3(0, -96, 0), 1)
                .SetEase(Ease.InOutCubic);
        Moveobj4.transform.DOLocalMove(new Vector3(0, -288, 0), 1)
                .SetEase(Ease.InOutCubic)
                .OnComplete(LoadArcadeLanding);
    }
    //シーンを変更してその後にアニメ―ション
    private void LoadArcadeLanding()
    {
        SceneManager.LoadScene("ArcadeLanding");
        Moveobj1.transform.DOLocalMove(new Vector3(-1024, 288, 0), 1)
                .SetEase(Ease.InCubic);
        Moveobj2.transform.DOLocalMove(new Vector3(1024, 96, 0), 1)
                .SetEase(Ease.InCubic);
        Moveobj3.transform.DOLocalMove(new Vector3(-1024, -96, 0), 1)
                .SetEase(Ease.InCubic);
        Moveobj4.transform.DOLocalMove(new Vector3(1024, -288, 0), 1)
                .SetEase(Ease.InCubic);
    }

    public void SCLeaderBoard()
    {
        DontDestroyOnLoad(Canvas);
        Moveobj1.transform.DOLocalMove(new Vector3(0, 288, 0), 1)
                .SetEase(Ease.InOutCubic);
        Moveobj2.transform.DOLocalMove(new Vector3(0, 96, 0), 1)
                .SetEase(Ease.InOutCubic);
        Moveobj3.transform.DOLocalMove(new Vector3(0, -96, 0), 1)
                .SetEase(Ease.InOutCubic);
        Moveobj4.transform.DOLocalMove(new Vector3(0, -288, 0), 1)
                .SetEase(Ease.InOutCubic)
                .OnComplete(LoadLeaderBoard);
    }
    private void LoadLeaderBoard()
    {
        SceneManager.LoadScene("LeaderBoard");
        Moveobj1.transform.DOLocalMove(new Vector3(-1024, 288, 0), 1)
                .SetEase(Ease.InCubic);
        Moveobj2.transform.DOLocalMove(new Vector3(1024, 96, 0), 1)
                .SetEase(Ease.InCubic);
        Moveobj3.transform.DOLocalMove(new Vector3(-1024, -96, 0), 1)
                .SetEase(Ease.InCubic);
        Moveobj4.transform.DOLocalMove(new Vector3(1024, -288, 0), 1)
                .SetEase(Ease.InCubic)
                .OnComplete(DestroyCanvas);
    }

    public void SCGallery()
    {
        DontDestroyOnLoad(Canvas);
        Moveobj1.transform.DOLocalMove(new Vector3(0, 288, 0), 1)
                .SetEase(Ease.InOutCubic);
        Moveobj2.transform.DOLocalMove(new Vector3(0, 96, 0), 1)
                .SetEase(Ease.InOutCubic);
        Moveobj3.transform.DOLocalMove(new Vector3(0, -96, 0), 1)
                .SetEase(Ease.InOutCubic);
        Moveobj4.transform.DOLocalMove(new Vector3(0, -288, 0), 1)
                .SetEase(Ease.InOutCubic)
                .OnComplete(LoadGallery);
    }
    private void LoadGallery()
    {
        SceneManager.LoadScene("Gallery");
        Moveobj1.transform.DOLocalMove(new Vector3(-1024, 288, 0), 1)
            .SetEase(Ease.InCubic);
        Moveobj2.transform.DOLocalMove(new Vector3(1024, 96, 0), 1)
                .SetEase(Ease.InCubic);
        Moveobj3.transform.DOLocalMove(new Vector3(-1024, -96, 0), 1)
                .SetEase(Ease.InCubic);
        Moveobj4.transform.DOLocalMove(new Vector3(1024, -288, 0), 1)
                .SetEase(Ease.InCubic)
                .OnComplete(DestroyCanvas);
    }

    public void SCSetting()
    {
        DontDestroyOnLoad(Canvas);
        Moveobj1.transform.DOLocalMove(new Vector3(0, 288, 0), 1)
                .SetEase(Ease.InOutCubic);
        Moveobj2.transform.DOLocalMove(new Vector3(0, 96, 0), 1)
                .SetEase(Ease.InOutCubic);
        Moveobj3.transform.DOLocalMove(new Vector3(0, -96, 0), 1)
                .SetEase(Ease.InOutCubic);
        Moveobj4.transform.DOLocalMove(new Vector3(0, -288, 0), 1)
                .SetEase(Ease.InOutCubic)
                .OnComplete(LoadSetting);
    }
    private void LoadSetting()
    {
        SceneManager.LoadScene("Setting");
        Moveobj1.transform.DOLocalMove(new Vector3(-1024, 288, 0), 1)
                .SetEase(Ease.InCubic);
        Moveobj2.transform.DOLocalMove(new Vector3(1024, 96, 0), 1)
                .SetEase(Ease.InCubic);
        Moveobj3.transform.DOLocalMove(new Vector3(-1024, -96, 0), 1)
                .SetEase(Ease.InCubic);
        Moveobj4.transform.DOLocalMove(new Vector3(1024, -288, 0), 1)
                .SetEase(Ease.InCubic)
                .OnComplete(DestroyCanvas);
    }

    public void SCHowtoPlay()
    {
        Moveobj1 = GameObject.Find("expand01");
        Moveobj2 = GameObject.Find("expand02");
        Moveobj3 = GameObject.Find("expand03");
        Moveobj4 = GameObject.Find("expand04");
        Canvas = GameObject.Find("CanvasAnim");
        DontDestroyOnLoad(Canvas);
        Moveobj1.transform.DOLocalMove(new Vector3(0, 288, 0), 1)
                .SetEase(Ease.InOutCubic);
        Moveobj2.transform.DOLocalMove(new Vector3(0, 96, 0), 1)
                .SetEase(Ease.InOutCubic);
        Moveobj3.transform.DOLocalMove(new Vector3(0, -96, 0), 1)
                .SetEase(Ease.InOutCubic);
        Moveobj4.transform.DOLocalMove(new Vector3(0, -288, 0), 1)
                .SetEase(Ease.InOutCubic)
                .OnComplete(LoadHowtoPlay);
    }
    private void LoadHowtoPlay()
    {
        SceneManager.LoadScene("HowtoPlay");
        Moveobj1.transform.DOLocalMove(new Vector3(-1024, 288, 0), 1)
            .SetEase(Ease.InCubic);
        Moveobj2.transform.DOLocalMove(new Vector3(1024, 96, 0), 1)
                .SetEase(Ease.InCubic);
        Moveobj3.transform.DOLocalMove(new Vector3(-1024, -96, 0), 1)
                .SetEase(Ease.InCubic);
        Moveobj4.transform.DOLocalMove(new Vector3(1024, -288, 0), 1)
                .SetEase(Ease.InCubic);
    }

    public void OnClickExitButton()
    {
        Moveobj1.transform.DOLocalMove(new Vector3(0, 288, 0), 1)
                .SetEase(Ease.InOutCubic);
        Moveobj2.transform.DOLocalMove(new Vector3(0, 96, 0), 1)
                .SetEase(Ease.InOutCubic);
        Moveobj3.transform.DOLocalMove(new Vector3(0, -96, 0), 1)
                .SetEase(Ease.InOutCubic);
        Moveobj4.transform.DOLocalMove(new Vector3(0, -288, 0), 1)
                .SetEase(Ease.InOutCubic)
                .OnComplete(QuitApp);
    }

    private void QuitApp()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    private void DestroyCanvas()
    {
        Destroy(Canvas);
    }

}
