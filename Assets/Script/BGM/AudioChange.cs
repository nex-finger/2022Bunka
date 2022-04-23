using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioChange : MonoBehaviour
{
    //AudoClipの配列、clipsを宣言します。
    public AudioClip[] clips;
    //AudioSource型の変数audiosを宣言します。
    AudioSource audios;

    void Start()
    {
        //GetComponenntoでAudioSourceコンポーネントにアクセスして
        //変数audiosで参照します。
        audios = GetComponent<AudioSource>();

    }

    //Button1がクリックされた時の処理
    public void SBClick()
    {
        //配列変数clipのインデックスが０のAudioのファイルを再生します。
        audios.clip = clips[0];
        audios.Play();
    }

    //Button2がクリックされた時の処理
    public void GNClick()
    {
        //配列変数clipのインデックスが１のAudioのファイルを再生します。
        audios.clip = clips[1];
        audios.Play();
    }

    //Button3がクリックされた時の処理
    public void CrClick()
    {
        //配列変数clipのインデックスが２のAudioのファイルを再生します。
        audios.clip = clips[2];
        audios.Play();
    }

    public void BeClick()
    {
        //配列変数clipのインデックスが3のAudioのファイルを再生します。
        audios.clip = clips[3];
        audios.Play();
    }

}