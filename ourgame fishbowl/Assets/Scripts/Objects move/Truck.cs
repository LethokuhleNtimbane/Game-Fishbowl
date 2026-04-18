using UnityEngine;

public class Truck : MonoBehaviour
{
    [SerializeField] private Animator MoveTruck;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            MoveTruck.SetTrigger("Truck");

        }
    }
}
