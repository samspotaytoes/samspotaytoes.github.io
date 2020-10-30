using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndTrigger : MonoBehaviour
{
    public GameObject BikeControl;
    public GameObject myCoolTimer;
    public GameObject finalTime; 

    public GameObject Textfield;

    public MeasurementData data;

    private GameObject Text;

    public InputField username;
    public InputField age;

    public Text button1;
    public Text button2;
    public Text button3;

     public Text button4;
    public Text button5;
    public Text button6;
    public Text button7;
    public Text button8;

    public GameObject uiObject;

    public GameObject checkScoreUi;

    void Start () 
    {
     uiObject.SetActive(false);
     checkScoreUi.SetActive(false);
    }
    
   void OnTriggerEnter () 
   {
        var timer = myCoolTimer.GetComponent<MyTimer>();
        var finalTime = myCoolTimer.GetComponent<MyTimer>().myCoolTimer;
        BikeControl.GetComponent<PlayerControllerRigidBody>().enabled = false;  
        timer.timerIsActive = false;

        

        data.username = username.text;
        data.age = age.text;
        data.finalTime = finalTime;

        data.button1 = button1.text;
        data.button2 = button2.text;
        data.button3 = button3.text;
        data.button4 = button4.text;
        data.button5 = button5.text;
        data.button6 = button6.text;
        data.button7 = button7.text;
        data.button8 = button8.text;

        checkScoreUi.SetActive(true);
        print("check score first");
        
        uiObject.SetActive(true);
        print("Play Again Button Appears");
 
        print("Game Over");
        print(finalTime);
        data.LogToServer();
     }
}
