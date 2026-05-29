using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonDelay : MonoBehaviour
{
    public GameObject eventsystem;

    void Start()
    {
        eventsystem.SetActive (false);
        StartCoroutine(Enable());
    }

    IEnumerator Enable()
    {
        yield return new WaitForSeconds(0.3f);
        eventsystem.SetActive( true);
    }
}