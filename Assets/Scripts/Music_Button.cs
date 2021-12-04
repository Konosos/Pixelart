using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music_Button : MonoBehaviour
{
    private SFX_Sound sfx_sound;
    [SerializeField] private Slider vol_Slider;
    public GameObject On_Button;
    public GameObject Off_Button;
    private void Start()
    {
        sfx_sound=FindObjectOfType<SFX_Sound>();
        if(sfx_sound.isMuted==0)
        {
            On_Button.SetActive(false);
            Off_Button.SetActive(true);
        }
        else
        {
            On_Button.SetActive(true);
            Off_Button.SetActive(false);
        }
        vol_Slider.value=sfx_sound.ms_Vol;
    }
    
    public void On_Control()
    {
        sfx_sound=FindObjectOfType<SFX_Sound>();
        sfx_sound.isMuted=0;
        sfx_sound.click.volume=sfx_sound.isMuted;
        PlayerPrefs.SetInt("Mute",sfx_sound.isMuted);
        On_Button.SetActive(false);
        Off_Button.SetActive(true);
    }
    public void Off_Control()
    {
        sfx_sound=FindObjectOfType<SFX_Sound>();
        sfx_sound.isMuted=1;
        sfx_sound.click.volume=sfx_sound.isMuted;
        PlayerPrefs.SetInt("Mute",sfx_sound.isMuted);
        On_Button.SetActive(true);
        Off_Button.SetActive(false);
    }
    public void Change_MuS()
    {
        sfx_sound=FindObjectOfType<SFX_Sound>();
        sfx_sound.ms_Vol=vol_Slider.value;
        sfx_sound.BG_music.volume=sfx_sound.ms_Vol;
        PlayerPrefs.SetFloat("Volume",vol_Slider.value);
    }
}
