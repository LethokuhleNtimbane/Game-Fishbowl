using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;             
using UnityEngine.UI;
using TMPro;


public class leveloader : MonoBehaviour
{
    public int sceneIndex = 2;
    
   
    public Animator animator;
    
    public float transitiontime = 2f;
    

   
    public void Triggeranimation()
    {
        animator.SetTrigger("play");
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

        SceneManager.LoadScene(sceneIndex);
             
    }
    public void BackToMain()
    {
        SceneManager.LoadScene(1);
    }

    public void loadwithtransition()
    {
        LoadLevelT();
    }



    IEnumerator LoadLevelT()
    {
      if (sceneIndex == 2)
        {
            animator.SetTrigger("Level1");

            yield return new WaitForSeconds(transitiontime);

            SceneManager.LoadScene(sceneIndex);
        }
        if (sceneIndex == 3)
        {
            animator.SetTrigger("Level2");

            yield return new WaitForSeconds(transitiontime);

            SceneManager.LoadScene(sceneIndex);
        }
        if (sceneIndex == 4)
        {
            animator.SetTrigger("Level3");

            yield return new WaitForSeconds(transitiontime);

            SceneManager.LoadScene(sceneIndex);
        }
    }

   
}

