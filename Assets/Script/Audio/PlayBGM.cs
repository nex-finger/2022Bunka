/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBGM : MonoBehaviour
{
    public AudioSource M1;
    public AudioSource M2;
    public AudioSource M3;
    public AudioSource M4;
    public AudioSource V1;
    public AudioSource V2;
    public AudioSource V3;

    public static AudioSource Music1 = M1;
    public static AudioSource Music2;
    public static AudioSource Music3;
    public static AudioSource Music4;
    public static AudioSource Voice1;
    public static AudioSource Voice2;
    public static AudioSource Voice3;

    //Music1 = Find("Beyond").AudioSource;

    public GameObject Script;

    public static void PlayMusic1()
    {
        StopAudio();
        Music1.Play();
    }

    public void PlayMusic2()
    {
        StopAudio();
        Music2.Play();
    }

    public void PlayMusic3()
    {
        StopAudio();
        Music3.Play();
    }

    public void PlayMusic4()
    {
        StopAudio();
        Music4.Play();
    }

    void PlayVoice1()
    {
        StopAudio();
        Voice1.Play();
    }

    public void PlayVoice2()
    {
        StopAudio();
        Voice2.Play();
    }

    public void PlayVoice3()
    {
        StopAudio();
        Voice3.Play();
    }

    public static void StopAudio()
    {
        Music1.Stop();
        Music2.Stop();
        Music3.Stop();
        Music4.Stop();
        Voice1.Stop();
        Voice2.Stop();
        Voice3.Stop();
    }

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

        PlayMusic1();
    }
}
*/