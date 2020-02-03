using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComanderVoice : MonoBehaviour
{
    public AudioSource randomSound;
    public int randx, randy;

    public AudioClip[] audioSources;

    // Start is called before the first frame update
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
        if (!this.randomSound.isPlaying) {
            randomSound.clip = audioSources[Random.Range(0, audioSources.Length)];
            randomSound.Play();
        }
        
        CallAudio();
    }
}
