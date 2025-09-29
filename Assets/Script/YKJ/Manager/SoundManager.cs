using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using Random = UnityEngine.Random;

[Serializable]
public class BGMData
{
    public string name;
    public string Setting;
    public AudioClip audio;
}
[Serializable]
public class SFXData
{
    public string name;
    public string Setting;
    public AudioClip audio;
}
public class SoundManager : MonoBehaviour, IManager
{
    #region 슬라이더 And 믹서
    [SerializeField] float DefultBGMPitch = 1;
    [SerializeField] float DefultSFXPitch = 1;
    [SerializeField] private AudioMixer m_audioMixer;
    [SerializeField] private Slider m_MusicMasterSlider;
    [SerializeField] private Slider m_MusicSFXSlider;
    [SerializeField] private Slider m_MusicBGMSlider;
    #endregion

    #region
    [SerializeField] AudioSource BGM;
    [SerializeField] AudioSource SFX;
    #endregion
    GameManager _gameManager;
    AudioMixerController audioMixerController;

    public List<BGMData> BGMDatas = new();
    public List<SFXData> SFXDatas = new();
    Dictionary<string, BGMData> BGMsound = new();
    Dictionary<string, SFXData> SFXsound = new();
    public void Init(GameManager gameManager)
    {
        _gameManager = gameManager;
    }
    public void Initialize()
    {
        audioMixerController = new AudioMixerController(m_audioMixer, m_MusicMasterSlider, m_MusicSFXSlider, m_MusicBGMSlider);
        audioMixerController.Initialize();
    }
    public void Init()
    {
        foreach (var sound in BGMDatas)
        {
            BGMsound.Add(sound.name, sound);
        }
        foreach (var sound in SFXDatas)
        {
            SFXsound.Add(sound.name, sound);
        }
    }
    public AudioClip GetSFX(string name)
    {
        if (SFXsound[name] != null)
        {
            return SFXsound[name].audio;
        }
        Debug.LogWarning("이름에 해당하는 오디오 클립이 존재하지 않습니다");
        return null;
    }
    public AudioClip GetBGM(string name)
    {
        if (BGMsound[name] != null)
        {
            return BGMsound[name].audio;
        }
        Debug.LogWarning("이름에 해당하는 오디오 클립이 존재하지 않습니다");
        return null;
    }
    public void StartSFX(string name, float RandomPitch = 0)
    {
        if (SFXsound[name] != null)
            SFX.clip = SFXsound[name].audio;
        else
        {
            Debug.LogError($"찾으려는 오디오가 존재하지않습니다{RandomPitch}");
            return;
        }
        SFX.pitch = Random.Range(-RandomPitch, RandomPitch) + DefultSFXPitch;
        SFX.Play();
    }
    public void StartBGM(string name, float RandomPitch = 0)
    {
        if (BGMsound[name] != null)
            BGM.clip = BGMsound[name].audio;
        else
        {
            Debug.LogError($"찾으려는 오디오가 존재하지않습니다{RandomPitch}");
            return;
        }

        BGM.pitch = Random.Range(-RandomPitch, RandomPitch) + DefultBGMPitch;
        BGM.Play();
    }
    public void SetSFXPitch(int pitch)
    {
        if (Mathf.Abs(pitch) > 3)
        {
            Debug.LogError($"설정 하려는 피치값이 한계값을 넘었습니다 {pitch}");
            return;
        }
        else
            SFX.pitch = pitch;
    }
    public void SetBGMPitch(int pitch)
    {
        if (Mathf.Abs(pitch) > 3)
        {
            Debug.LogError($"설정 하려는 피치값이 한계값을 넘었습니다 {pitch}");
            return;
        }
        else
            BGM.pitch = pitch;
    }
}
