using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10f;
    public Transform player;
    public bool inAir;
    public float raxis;

    bool right;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        right = true;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = Vector3.zero;

        if (Input.GetKey(KeyCode.W) )
        {
            move.y += 1;

            raxis = 30f;
            while (inAir == true)
            {
                raxis = raxis - 1;
                player.rotation = Quaternion.Euler(0f, 0f, raxis);
            }
         
        }
        if (Input.GetKey(KeyCode.D) )
        {
            move.x += 1;
            player.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.A) )
        {
            move.x -= 1;
            player.rotation = Quaternion.Euler(0f, 0f, 0f);
        }

        transform.position += move.normalized * speed * Time.deltaTime;
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        inAir = false;
    }

    private void OnCollisionExit(Collision collision)
    {
        inAir = true;
    }





}
