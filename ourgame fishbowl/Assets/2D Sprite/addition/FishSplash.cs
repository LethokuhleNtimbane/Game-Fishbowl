using UnityEngine;

public class FishSplash : MonoBehaviour
{
    public GameObject splashPrefab;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Water"))
        {
            Instantiate(
                splashPrefab,
                transform.position,
                Quaternion.identity
            );
        }
    }
}