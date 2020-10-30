using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public InputField username;
    public InputField age;

    public Button Submit;

    private InputField inputField;

    public Text finalText;

    public GameObject ready;
    public GameObject loginScreen;

   public MeasurementData data;
    

    void Start() {
       ready.GetComponent<Countdown>().enabled = false;
    }

    void Update() {
        if(Input.GetKey (KeyCode.Return )) {
            ready.GetComponent<Countdown>().enabled = true;
            loginScreen.SetActive(false);
            print(username.text);
            print(age.text);
        }
    }

    
   public void onClick() {
       ready.GetComponent<Countdown>().enabled = true;
       loginScreen.SetActive(false);
       print(username.text);
       print(age.text);
   }
}
