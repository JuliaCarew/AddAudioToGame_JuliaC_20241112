﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public AudioClip playerShoot;
    public AudioClip asteroidExplosion;
    public AudioClip playerDamage;
    public AudioClip playerExplosion;
    public AudioClip BgMusicGameplay;
    public AudioClip BgMusicTitleScreen;

    private AudioSource SFXaudioSource;

    private AudioSource BgMusicAudioSource;

    public void Awake()
    {
        SFXaudioSource = GetComponent<AudioSource>();
        //GameObject child = this.transform.Find("BgMusic").gameObject;
        BgMusicAudioSource = gameObject.transform.Find("BgMusic").gameObject.GetComponent<AudioSource>();


        
        //BgMusicAudioSource.GetComponent<AudioSource>().Play();       
    }



    //called in the PlayerController Script
    public void PlayerShoot()
    {
        SFXaudioSource.PlayOneShot(playerShoot);
        Debug.Log("player Shoot SFX");
    }

    //called in the PlayerController Script
    public void PlayerDamage()
    {
        SFXaudioSource.PlayOneShot(playerDamage);
        Debug.Log("player Damage SFX");
    }

    //called in the PlayerController Script
    public void PlayerExplosion()
    {
        SFXaudioSource.PlayOneShot(playerExplosion);
        Debug.Log("player Explosion SFX");
    }

    //called in the AsteroidDestroy script
    public void AsteroidExplosion()
    {
        SFXaudioSource.PlayOneShot(asteroidExplosion);
        Debug.Log("asteroid Explosion SFX");
    }


    public void BGMusicMainMenu()
    {
        BgMusicAudioSource.clip = BgMusicTitleScreen;
        BgMusicAudioSource.Play();
    }

    public void BGMusicGameplay()
    {
        BgMusicAudioSource.GetComponent<AudioSource>().clip = BgMusicGameplay;
        BgMusicAudioSource.Play();

    }
}
