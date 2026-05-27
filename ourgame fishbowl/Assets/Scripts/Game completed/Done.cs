using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class Done : MonoBehaviour
{
    public GameObject forwatermeter;
    public GameObject Player;
    public GameObject Camera1;
    public GameObject Camera2;
    public Light2D light2D;
    [SerializeField] private Animator finalanimation;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            finalanimation.SetTrigger("DONE");
            forwatermeter.SetActive(false);
            Player.SetActive(false);
            Camera1.SetActive(false);
            Camera2.SetActive(true);
            light2D.intensity = 1.0f;

        }
    }
    public void thegameisdone()
    {
        SceneManager.LoadScene(0);
    }
}
