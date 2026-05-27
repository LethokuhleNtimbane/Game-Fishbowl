using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Audiomanager : MonoBehaviour
{
    public static Audiomanager instance;
    public static bool SFXOn = true;

    public AudioSource audioSource;
    public AudioSource SFXSound;
   
    public AudioClip death;
    public AudioClip jump;
    public AudioClip click;
    public AudioClip won;
    public AudioClip hitbubble;
    public AudioClip hitthefloor;
    public AudioClip background;
    public AudioClip splash;


    // Start is called once before the first execution of Update after the MonoBehaviour is created



    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);

        }

        SFXOn = PlayerPrefs.GetInt("SFX", 1) == 1;
    }
    private void Start()
    {
        audioSource.clip = background;
        audioSource.Play();
       
    }
    public void PlaySFX(AudioClip clip)
    {
        if (!SFXOn) return;

        SFXSound.PlayOneShot(clip);
    }

}