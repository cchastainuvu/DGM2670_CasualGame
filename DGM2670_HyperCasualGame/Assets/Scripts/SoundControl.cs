using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{

    public AudioSource Music;
    public SpriteRenderer Button;
    public SpriteRenderer Button2;

//    public void Start()
//    {
//        Button2 = GetComponent<SpriteRenderer>();
//        Button2.GetComponent<SpriteRenderer>().enabled = false;
//    }
    
    public void Unmute()
    {
        Music = GetComponent<AudioSource>();
        Music.Play();

//        Button = GetComponent<SpriteRenderer>();
//        Button.GetComponent<SpriteRenderer>().enabled = true;
//
//        Button2 = GetComponent<SpriteRenderer>();
//        Button2.GetComponent<SpriteRenderer>().enabled = false;
    }

    public void Mute()
    {
        Music = GetComponent<AudioSource>();
        Music.Stop();
        
//        Button2 = GetComponent<SpriteRenderer>();
//        Button2.GetComponent<SpriteRenderer>().enabled = true;
//
//        Button = GetComponent<SpriteRenderer>();
//        Button.GetComponent<SpriteRenderer>().enabled = false;
    }

}
