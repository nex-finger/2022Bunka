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
    public GameObject CanvasAnim;

    public void Anim1()
    {
        DontDestroyOnLoad(CanvasAnim);
        Moveobj1.transform.DOLocalMove(new Vector3(0, 288, 0), 1)
                .OnComplete(SCArcadeLanding)
                .SetEase(Ease.InOutCubic);
        Moveobj2.transform.DOLocalMove(new Vector3(0, 96, 0), 1)
                .SetEase(Ease.InOutCubic);
        Moveobj3.transform.DOLocalMove(new Vector3(0, -96, 0), 1)
                .SetEase(Ease.InOutCubic);
        Moveobj4.transform.DOLocalMove(new Vector3(0, -288, 0), 1)
                .SetEase(Ease.InOutCubic);
    }

    private void SCArcadeLanding()
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
}
