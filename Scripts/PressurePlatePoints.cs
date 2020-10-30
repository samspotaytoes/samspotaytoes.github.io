using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PressurePlatePoints : MonoBehaviour
{
    // public float myCoolTimer;
     [SerializeField]
     GameObject myCoolTimer;
    //   GameObject textTimer;
    
    
      
    void OnTriggerEnter (Collider coll) {
        myCoolTimer.GetComponent<MyTimer>().myCoolTimer -= 500;
        print("Ouch!");
    }
    
}

   


