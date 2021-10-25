using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioClip introMusicClip;
    public AudioClip backgroundMusic;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(playMusic());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator playMusic()
    {
        GetComponent<AudioSource>().clip = introMusicClip;
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(introMusicClip.length);
        GetComponent<AudioSource>().clip = backgroundMusic;
        GetComponent<AudioSource>().Play();
        GetComponent<AudioSource>().loop = true;

    }
}
