using UnityEngine;

public class waterPush : MonoBehaviour
{
    public float driftspeed;
    public Rigidbody2D Player;
    public bool inwater;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (inwater == true)
        {
            Player.linearVelocity += Vector2.right * driftspeed * Time.deltaTime;
        }

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
          inwater = true;
        }
    

    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            {
              inwater = false;
        }
       
    }
}
