using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{

    public GameObject CountDown;
    public GameObject textTimer;

    public GameObject PlayerControllerRigidBody;

    public bool countDownIsActive;

    bool isCoroutineStarted = false;

    

    void Update()
    {
        if(!isCoroutineStarted) {
            StartCoroutine(CountStart ());
        }
       
    }

    // void OnEnable () {
    //     if(loginScreen.activeInHierarchy == false) {
    //         StartCoroutine(CountStart ());
    //         print("counting");
    //     }
    // }


    public IEnumerator CountStart ()
    {
            isCoroutineStarted = true;
              yield return new WaitForSeconds(0.5f);
            CountDown.GetComponent<Text>().text = "3";
            CountDown.SetActive (true);
            yield return new WaitForSeconds(1);
            CountDown.SetActive(false);
            CountDown.GetComponent<Text>().text = "2";
            CountDown.SetActive(true);
            yield return new WaitForSeconds(1);
            CountDown.SetActive(false);
            CountDown.GetComponent<Text>().text = "1";
            CountDown.SetActive(true);
            yield return new WaitForSeconds(1);
            CountDown.SetActive(false);
            textTimer.SetActive(true);
            PlayerControllerRigidBody.SetActive(true);
  
        
    }
    
}
