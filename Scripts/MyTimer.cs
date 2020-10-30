using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyTimer : MonoBehaviour
{

    public float myCoolTimer = 1000;
    private Text timerText;
    public bool timerIsActive = true;
    public MeasurementData data;

    private bool finished;
    
    


    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
   {
            if (timerIsActive)
        {
            myCoolTimer -= Time.deltaTime;
            timerText.text = myCoolTimer.ToString("$ "+"0");
       
            if (myCoolTimer <= 0)
            {
                myCoolTimer = 0;
                timerIsActive = false;
            }
        }
        
    }
    
}

    
