using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerRigidBodyActive : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject BikeControl;
 
// Use this for initialization

 void Start () {
        BikeControl.GetComponent<PlayerControllerRigidBody>().enabled = true;
        
 }
 


    // Update is called once per frame
    void Update()
    {
        
        
    }

    
    
}
