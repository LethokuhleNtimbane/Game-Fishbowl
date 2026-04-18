using UnityEngine;

public class Movestuff : MonoBehaviour
{
    [SerializeField] private Animator skateboard;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

        skateboard.SetTrigger("Moveskate");

        }
    }
}
