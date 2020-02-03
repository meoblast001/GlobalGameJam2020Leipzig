using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComanderVoice : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource randomSound;
    public int randx, randy;

    public AudioClip[] audioSources;
    void Start()
    {
        CallAudio();
    }

    void CallAudio()
    {
        int time = Random.Range(randx, randy);
        Invoke("RandomSoundness", time);
    }

    // Update is called once per frame
    void RandomSoundness()
    {
        randomSound.clip = audioSources[Random.Range(0, audioSources.Length)];
        randomSound.Play();
        
       // if (!randomSound.isPlaying)
        {
            CallAudio();
        }
    }
}
