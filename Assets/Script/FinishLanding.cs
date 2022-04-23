/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class FinishLanding : MonoBehaviour
{
    public GameObject Rocket;
    private Vector3 pos;
    private Vector3 pos_p;
    private Vector3 pos_pp;
    private int flag;
    private int count;

    public GameObject Moveobj1;
    public GameObject Moveobj2;
    public GameObject Moveobj3;
    public GameObject Moveobj4;
    public GameObject Canvas;

    void Judge()
    {
        float vel1;
        float vel2;

        flag = 0;

        vel1 = (pos_p.x - pos.x) * (pos_p.x - pos.x) + (pos_p.y - pos.y) * (pos_p.y - pos.y);
        vel2 = (pos_pp.x - pos_p.x) * (pos_pp.x - pos_p.x) + (pos_pp.y - pos_p.y) * (pos_pp.y - pos_p.y);

        if (vel1 == 0.0f && vel2 == 0.0f)
        {
            flag = 1;
        }
    }

    public void SC()
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
                .OnComplete(LS);
    }
    //シーンを変更してその後にアニメ―ション
    private void LS()
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
        pos = new Vector3(0.0f, 0.0f, 0.0f);
        pos_p = new Vector3(1.0f, 1.0f, 1.0f);
        pos_pp = new Vector3(2.0f, 2.0f, 2.0f);

        flag = 0;
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        pos.x = Rocket.transform.position.x;
        pos.y = Rocket.transform.position.y;

        Judge();

        if(flag == 1)
        {
            SC();
        }

        count++;
        if(count == 5)
        {
            count = 0;
            pos_p = new Vector3(pos.x, pos.y, 0.0f);
            pos_pp = new Vector3(pos_p.x, pos_p.y, 0.0f);
        }
    }
}*/

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
        }
    }
}