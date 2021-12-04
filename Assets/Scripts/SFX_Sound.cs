using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX_Sound : MonoBehaviour
{
    public AudioSource click;
    public AudioSource BG_music;
    public AudioClip[] bgMs;  
    public static SFX_Sound sfxSound;
    public int isMuted=1;
    
    [Range(0,1)]
    public float ms_Vol=0.3f;

    private void Awake()
    {
        if(sfxSound!=null&&sfxSound!=this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            sfxSound=this;
            DontDestroyOnLoad(this);
        }
    }
    private void Start()
    {
        isMuted=PlayerPrefs.GetInt("Mute");
        ms_Vol=PlayerPrefs.GetFloat("Volume");
        BG_music.volume=ms_Vol;
        click.volume=isMuted;
        if(bgMs!=null&&bgMs.Length>0)
        {
            int AuClipRan=Random.Range(0,bgMs.Length);
            BG_music.clip=bgMs[AuClipRan];
            BG_music.Play();
            
        }
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            click.Play();
        }
        //BG_music.volume=ms_Vol;
    }
    /*public void Mute_Aud()
    {
        isMuted=!isMuted;
        AudioListener.pause=isMuted;
        PlayerPrefs.SetInt("Mute",isMuted ? 1:0);
    }*/
}
