using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Off_On_Music : MonoBehaviour
{
    public AudioMixerGroup Mixer;
    private bool indicator = false;

    public void OnMouseDown()
    {
        if (!indicator)
        {
            Mixer.audioMixer.SetFloat("MusicVolume", 0.0f);
            indicator = true;
        }
        else
        {
            Mixer.audioMixer.SetFloat("MusicVolume", -80.0f);
            indicator = false;

           
        }
    }
}
