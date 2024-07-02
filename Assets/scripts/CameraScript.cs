using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public SpriteRenderer Background;
    // Start is called before the first frame update
    void Start()
    {
        float OrthographicSize = Background.size.x * Screen.height / Screen.width * 0.5f;

        Camera.main.orthographicSize = OrthographicSize;
        float screenRatio = (float)Screen.width / (float)Screen.height;
        float targetRatio = Background.bounds.size.x / Background.bounds.size.y;

        if (screenRatio >= targetRatio)
        {
            Camera.main.orthographicSize = Background.bounds.size.y / 2;
        }
        else
        {
            float differenceInSize = targetRatio / screenRatio;
            Camera.main.orthographicSize = Background.bounds.size.y / 2 * differenceInSize;
        }
    }

   
}
