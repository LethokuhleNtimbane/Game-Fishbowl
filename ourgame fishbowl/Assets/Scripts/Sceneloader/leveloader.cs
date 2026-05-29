using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;             
using UnityEngine.UI;
using TMPro;


public class leveloader : MonoBehaviour
{
    public int sceneIndex = 2;
    
    /*public GameObject loadingscreen;
    public Slider slider;
    public TextMeshProUGUI progresstext;
    public Animator animator;
    
    public float transitiontime = 2f;
    

   
    public void Triggeranimation()
    {
        animator.SetTrigger("play");
    }*/
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

 
    

   /* IEnumerator LoadAsynchronously (int sceneIndex)
    {
      

        yield return new WaitForSeconds(transitiontime);
      
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        loadingscreen.SetActive(true);

        while (operation.isDone == false)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);

            slider.value = progress;
            progresstext.text = progress * 100f + "%";
            


            yield return null;
        }
    }*/

   
}

