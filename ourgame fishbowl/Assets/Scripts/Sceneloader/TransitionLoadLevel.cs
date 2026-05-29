using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionLoadLevel : MonoBehaviour
{
    public float transitiontime;
    public Animator transtion;
    public int sceneIndex = 2;

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Level1()
    {
        sceneIndex = 2;
    }
    public void Level2()
    {
        sceneIndex = 3;
    }
    public void Level3()
    {
        sceneIndex = 4;
    }
    public void LoadLevel()
    {
        StartCoroutine(Transitonlevel());

    }
    IEnumerator Transitonlevel()
    {
        transtion.SetTrigger("start");
        

        yield return new WaitForSeconds(transitiontime);
        
        SceneManager.LoadScene(sceneIndex);
    }

}
