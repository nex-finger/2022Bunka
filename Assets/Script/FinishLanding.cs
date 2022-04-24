using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class FinishLanding : MonoBehaviour
{
    public GameObject Rocket;
    private int flag;
    private int count;

    public GameObject Moveobj1;
    public GameObject Moveobj2;
    public GameObject Moveobj3;
    public GameObject Moveobj4;
    public GameObject Canvas;
    public bool Once = true;

    void Judge()
    {
        flag = 0;

        var rigidbody = Rocket.GetComponent<Rigidbody2D>();
        var velocity = rigidbody.velocity;

        Debug.Log(velocity);

        if (velocity == new Vector2(0.0f, 0.0f))
        {
            flag = 1;
        }
    }

    private void LoadResult1()
    {
        SceneManager.LoadScene("Result1");
        Moveobj1.transform.DOLocalMove(new Vector3(-1024, 288, 0), 1)
            .SetEase(Ease.InCubic);
        Moveobj2.transform.DOLocalMove(new Vector3(1024, 96, 0), 1)
                .SetEase(Ease.InCubic);
        Moveobj3.transform.DOLocalMove(new Vector3(-1024, -96, 0), 1)
                .SetEase(Ease.InCubic);
        Moveobj4.transform.DOLocalMove(new Vector3(1024, -288, 0), 1)
                .SetEase(Ease.InCubic);
    }

    // Start is called before the first frame update
    void Start()
    {
        flag = 0;
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //宇宙船の速度が0ならflagを0に
        Judge();

        if (flag == 1)
        {
            //ここにシーンチェンジをよろしくお願いします
            //変移先はResult1

            //シーンチェンジアニメーションに使うオブジェクト
            Moveobj1 = GameObject.Find("expand01");
            Moveobj2 = GameObject.Find("expand02");
            Moveobj3 = GameObject.Find("expand03");
            Moveobj4 = GameObject.Find("expand04");
            Canvas = GameObject.Find("CanvasAnim");
            DontDestroyOnLoad(Canvas);

            if (Once == true)
            {
                Once = false;
                Moveobj1.transform.DOLocalMove(new Vector3(0, 288, 0), 1)
                        .SetEase(Ease.InOutCubic);
                Moveobj2.transform.DOLocalMove(new Vector3(0, 96, 0), 1)
                        .SetEase(Ease.InOutCubic);
                Moveobj3.transform.DOLocalMove(new Vector3(0, -96, 0), 1)
                        .SetEase(Ease.InOutCubic);
                Moveobj4.transform.DOLocalMove(new Vector3(0, -288, 0), 1)
                        .SetEase(Ease.InOutCubic)
                        .OnComplete(LoadResult1);
            }
        }
    }
}