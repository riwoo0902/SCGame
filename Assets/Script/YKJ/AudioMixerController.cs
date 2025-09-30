using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioMixerController
{
    private AudioMixer m_audioMixer;

    private Slider m_MusicMasterSlider;
    private Slider m_MusicSFXSlider;
    private Slider m_MusicBGMSlider;
    public AudioMixerController(AudioMixer audioMixer, Slider MasterSlider, Slider SFXSlider, Slider BGMSlider)
    {
        m_audioMixer = audioMixer;
        m_MusicMasterSlider = MasterSlider;
        m_MusicSFXSlider = SFXSlider;
        m_MusicBGMSlider = BGMSlider;
    }
    public void Initialize()
    {
        #region 이벤트 추가
        m_MusicMasterSlider.onValueChanged.AddListener(SetMasterVolume);
        m_MusicSFXSlider.onValueChanged.AddListener(SetSFXVolume);
        m_MusicBGMSlider.onValueChanged.AddListener(SetBGMVolume);
        #endregion
    }
    public void SetMasterVolume(float volume)
    {
        m_audioMixer.SetFloat("Master", Mathf.Log10(volume) * 20);
    }
    public void SetSFXVolume(float volume)
    {
        m_audioMixer.SetFloat("SFX", Mathf.Log10(volume) * 20);
    }
    public void SetBGMVolume(float volume)
    {
        m_audioMixer.SetFloat("BGM", Mathf.Log10(volume) * 20);
    }
}
