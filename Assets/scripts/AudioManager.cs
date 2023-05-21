using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public audio[] sound;

    private void Awake()
    {
        foreach (audio x in sound)
        {
            x.source = gameObject.AddComponent<AudioSource>();
            x.source.volume = x.volume;
            x.source.pitch = x.pitch;
            x.source.clip = x.clip;
            x.source.loop = x.loop;
        }
    }



    public void play(string name)
    {
        audio x = Array.Find(sound, audio => audio.name == name);
        if (x == null)
        {
            Debug.Log("sound not found");
            return;
        }else
        {
            x.source.Play();
            return;
        }
    }

    public void stop(string name)
    {
        audio x = Array.Find(sound, audio => audio.name == name);
        if (x == null)
        {
            Debug.Log("sound not found");
            return;
        }
        else
        {
            x.source.Stop();
            return;
        }
    }



    public void klikSound()
    {
        play("Klik");
    }
    public void klikSound2()
    {
        play("Klik2");
    }
}
