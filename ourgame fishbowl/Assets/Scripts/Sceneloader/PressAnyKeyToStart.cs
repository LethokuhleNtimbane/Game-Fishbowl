using UnityEngine;
using UnityEngine.SceneManagement;

public class PressAnyKeyToStart : MonoBehaviour
{
  private bool KeyPressed = false;
    public int KeyCode;

    private void Update()
    {
        if (!KeyPressed && Input.anyKeyDown)
        {
            KeyPressed = true;
            SceneManager.LoadScene(KeyCode);
            Audiomanager.instance.PlaySFX(Audiomanager.instance.click);
        }
    }
}
