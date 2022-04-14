using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBGM : MonoBehaviour
{
    public AudioSource Music1;
    public AudioSource Music2;
    public AudioSource Music3;
    public AudioSource Music4;
    public AudioSource Voice1;
    public AudioSource Voice2;
    public AudioSource Voice3;

    public GameObject Script;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(Script);
        DontDestroyOnLoad(Music1);
        DontDestroyOnLoad(Music2);
        DontDestroyOnLoad(Music3);
        DontDestroyOnLoad(Music4);
        DontDestroyOnLoad(Voice1);
        DontDestroyOnLoad(Voice2);
        DontDestroyOnLoad(Voice3);
        //Audio1.Play();
    }

    void StopAudio()
    {
        Music1.Stop();
        Music2.Stop();
        Music3.Stop();
        Music4.Stop();
        Voice1.Stop();
        Voice2.Stop();
        Voice3.Stop();
    }

    void PlayMusic1()
    {
        StopAudio();
        Music1.Play();
    }

    void PlayMusic2()
    {
        StopAudio();
        Music2.Play();
    }

    void PlayMusic3()
    {
        StopAudio();
        Music3.Play();
    }

    void PlayMusic4()
    {
        StopAudio();
        Music4.Play();
    }

    void PlayVoice1()
    {
        StopAudio();
        Voice1.Play();
    }

    void PlayVoice2()
    {
        StopAudio();
        Voice2.Play();
    }

    void PlayVoice3()
    {
        StopAudio();
        Voice3.Play();
    }
}
