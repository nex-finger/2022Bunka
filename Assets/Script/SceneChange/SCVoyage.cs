using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class SCVoyage : MonoBehaviour
{
    private int Cash;
    private int Limit;
    private GameObject Moveobj1;
    private GameObject Moveobj2;
    private GameObject Moveobj3;
    private GameObject Moveobj4;
    private GameObject Canvas;

    public void OnClick()
    {
        Moveobj1 = GameObject.Find("expand01");
        Moveobj2 = GameObject.Find("expand02");
        Moveobj3 = GameObject.Find("expand03");
        Moveobj4 = GameObject.Find("expand04");
        Canvas = GameObject.Find("CanvasAnim");
        DontDestroyOnLoad(Canvas);

        Cash = LevelStorage.GetCash();
        Limit = DataStorage.GetLimit();
        if(Cash <= Limit)
        {
            Moveobj1.transform.DOLocalMove(new Vector3(0, 288, 0), 1)
                    .SetEase(Ease.InOutCubic);
            Moveobj2.transform.DOLocalMove(new Vector3(0, 96, 0), 1)
                    .SetEase(Ease.InOutCubic);
            Moveobj3.transform.DOLocalMove(new Vector3(0, -96, 0), 1)
                    .SetEase(Ease.InOutCubic);
            Moveobj4.transform.DOLocalMove(new Vector3(0, -288, 0), 1)
                    .SetEase(Ease.InOutCubic)
                    .OnComplete(LoadVoyage);
        }

    }

    private void LoadVoyage()
    {
        SceneManager.LoadScene("Voyage");
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
