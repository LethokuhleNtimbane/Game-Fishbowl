using TMPro;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class acid : MonoBehaviour
{
    public GameObject youlost;
    public GameObject disapear;
    public GameObject exitbutton;
    public GameObject pausemenu;
    public Light2D light2D;

    public Movement movement;
    public waterPush WaterPush;
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
            WaterPush.enabled = false;
            disapear.SetActive(false);
            exitbutton.SetActive(false);
            movement.enabled = false;
            watermeter.enabled = false;
            howlost.text = "You died in a pool of acid";
            Audiomanager.instance.PlaySFX(Audiomanager.instance.death);
        }

    }
}
