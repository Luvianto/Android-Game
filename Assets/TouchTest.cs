using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTest : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount == 0){
            return;
        }

        var touch = Input.GetTouch(0);
        switch(touch.phase){
            case TouchPhase.Began:
                Debug.Log("Touch Began");
                break;
            case TouchPhase.Moved:
                Debug.Log("Touch Moved");
                break;
            case TouchPhase.Stationary:
                Debug.Log("Touch Stationary");
                break;
            case TouchPhase.Ended:
                Debug.Log("Touch Ended");
                break;
            case TouchPhase.Canceled:
                Debug.Log("Touch cancel");
                break;
        }
    }
}
