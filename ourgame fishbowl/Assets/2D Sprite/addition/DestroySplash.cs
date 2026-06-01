using UnityEngine;

using UnityEngine.Video;

public class DestroySplash : MonoBehaviour
{
    void Start()
    {
        VideoPlayer vp = GetComponent<VideoPlayer>();

        if (vp != null)
        {
            Destroy(gameObject, (float)vp.length);
        }
    }
}
