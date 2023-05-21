using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class audio
{
    public string name;

    public bool loop;

    [Range(0,1)]
    public float volume;

    [Range(-3, 3)]
    public float pitch;

    public AudioClip clip;

    [HideInInspector]
    public AudioSource source;
}
