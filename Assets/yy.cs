using UnityEngine;
using System.Collections;

public class yy : MonoBehaviour
{
    //the factor used to slow down time  
    private float slowFactor = 4f;
    //the new time scale  
    private float newTimeScale;

    // Called when this script starts  
    void Start()
    {
        //calculate the new time scale  
        newTimeScale = Time.timeScale / slowFactor;
    }

    // Update is called once per frame  
    void Update()
    {
        
            //if the game is running normally  
            if (Time.timeScale == 1.0f)
            {
                //assign the 'newTimeScale' to the current 'timeScale'  
                Time.timeScale = newTimeScale;
                //proportionally reduce the 'fixedDeltaTime', so that the Rigidbody simulation can react correctly  
                Time.fixedDeltaTime = Time.fixedDeltaTime / slowFactor;
                //The maximum amount of time of a single frame  
                Time.maximumDeltaTime = Time.maximumDeltaTime / slowFactor;
            }
    }
}