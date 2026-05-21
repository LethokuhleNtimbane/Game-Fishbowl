using TMPro;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Spikes : MonoBehaviour
{
    public GameObject youlost;
    public GameObject disapear;
    public GameObject exitbutton;
    public GameObject pausemenu;
    public Light2D light2D;

    public Movement movement;
    public TextMeshProUGUI howlost;
    public Watermeter watermeter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.gameObject.CompareTag("Player"))
        {
            light2D.intensity = 1;
            youlost.SetActive(true);
            pausemenu.SetActive(true);
            disapear.SetActive(false);
            exitbutton.SetActive(false);
            movement.enabled = false;
            watermeter.enabled = false;
            howlost.text = "You were impaled by spikes";
            Audiomanager.instance.PlaySFX(Audiomanager.instance.death);
        }

    }
}
