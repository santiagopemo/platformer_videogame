using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MasterMixerManager : MonoBehaviour
{
    public AudioMixer masterMixer;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("dbBGMVolume"))
        {
            masterMixer.SetFloat("BGMVolume", PlayerPrefs.GetFloat("dbBGMVolume"));
        }
            
        if (PlayerPrefs.HasKey("dbSFXVolume"))
        {
            masterMixer.SetFloat("SFXVolume", PlayerPrefs.GetFloat("dbSFXVolume"));
        }
    }
}
