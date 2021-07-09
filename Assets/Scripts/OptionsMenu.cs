using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    private Toggle invertYAxis;
    public Slider BGMSlider;
    public Slider SFXSlider;
    private float initialVolumeBGM;
    private float initialVolumeSFX;

    void Start()
    {
        transform.Find("ApplyButton").gameObject.GetComponent<Button>().onClick.AddListener(Apply);
        invertYAxis = transform.Find("InvertYToggle").gameObject.GetComponent<Toggle>();
        if (PlayerPrefs.HasKey("InvertYToggle"))
            invertYAxis.isOn = PlayerPrefs.GetInt("InvertYToggle") == 0 ? false : true;
        SetBGMSlider();
        SetSFXSlider();
    }
    public void Back()
    {
        SetBGMVolume(initialVolumeBGM);
        if (PlayerPrefs.HasKey("previous-scene"))
            SceneManager.LoadScene(PlayerPrefs.GetString("previous-scene"));        
    }

    public void Apply()
    {
        if (invertYAxis.isOn)
            PlayerPrefs.SetInt("InvertYToggle", 1);
        else
            PlayerPrefs.SetInt("InvertYToggle", 0);
            PlayerPrefs.SetFloat("dbBGMVolume", LinearToDecibel(BGMSlider.value));
            PlayerPrefs.SetFloat("dbSFXVolume", LinearToDecibel(SFXSlider.value));
        if (PlayerPrefs.HasKey("previous-scene"))
            SceneManager.LoadScene(PlayerPrefs.GetString("previous-scene"));
    }

    public void SetBGMVolume(float linearVulome)
    {
        float dbVolume = LinearToDecibel(linearVulome);
        audioMixer.SetFloat("BGMVolume", dbVolume);
    }

    public void SetBGMSlider()
    {
        float dbVolume;
        audioMixer.GetFloat("BGMVolume", out dbVolume);
        float linearVolume = DecibelToLinear(dbVolume);
        BGMSlider.value = linearVolume;
        initialVolumeBGM = linearVolume;
    }

    public void SetSFXVolume(float linearVulome)
    {
        float dbVolume = LinearToDecibel(linearVulome);
        audioMixer.SetFloat("SFXVolume", dbVolume);
    }

    public void SetSFXSlider()
    {
        float dbVolume;
        audioMixer.GetFloat("SFXVolume", out dbVolume);
        float linearVolume = DecibelToLinear(dbVolume);
        SFXSlider.value = linearVolume;
        initialVolumeSFX = linearVolume;
    }

    private float LinearToDecibel(float linear)
    {
        float dB;
        
        if (linear != 0)
            dB = 20.0f * Mathf.Log10(linear);
        else
            dB = -144.0f;
        
        return dB;
    }

     private float DecibelToLinear(float dB)
     {
         float linear = Mathf.Pow(10.0f, dB/20.0f);
 
         return linear;
     }
}
