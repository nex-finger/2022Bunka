using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UIを使うとき追加

public class CanvasTest : MonoBehaviour
{
    [SerializeField] private CanvasGroup a;//CanvasGroup型の変数aを宣言　あとでCanvasGroupをアタッチする

    void Start()
    {
        a.alpha = 0.5f;//変数aのalpha値を変更
    }
}