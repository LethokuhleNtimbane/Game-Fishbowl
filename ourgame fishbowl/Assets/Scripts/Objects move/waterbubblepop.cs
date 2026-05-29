using UnityEngine;

public class waterbubblepop : MonoBehaviour
{    
    [SerializeField] private Animator waterbubble;
    [SerializeField] private Watermeter watermeter;
    public GameObject glow;
    public GameObject orb1;
    public GameObject orb2;
    public GameObject orb3;
    public GameObject orb4;

    private bool popped = false;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DisableObjects()
    {
        orb1.SetActive(false);
        orb2.SetActive(false);
        orb3.SetActive(false);
        glow.SetActive(false);
        orb4 .SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {  
        if (popped) return;

        if (other.CompareTag("Player"))
        {
           Audiomanager.instance.PlaySFX(Audiomanager.instance.hitbubble);
            popped = true;
            waterbubble.SetTrigger("pop");


            watermeter.FullRefill();

        }
    }
}
