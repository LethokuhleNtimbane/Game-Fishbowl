using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer volumeSource;
    [SerializeField] private Slider volumeslider;

    private void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume"))
        {
            LoadVolume();
        }
        else
        { 
           setMusicVolume();
        
        }
        setMusicVolume();
    }
    public void setMusicVolume()
    {
        float volume = volumeslider.value;
        volumeSource.SetFloat("MyExposedParam", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("musicVolume", volume);

    }
    public void LoadVolume()
    {
        volumeslider.value = PlayerPrefs.GetFloat("musicVolume");

        setMusicVolume();
    }
}
