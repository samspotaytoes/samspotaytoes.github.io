using System.Collections;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using System;

public class MeasurementData : MonoBehaviour
{
    private const string SERVER_ENDPOINT = "https://jfq9bact9g.execute-api.us-west-1.amazonaws.com/which-road/playthrough";

    // public GameObject myCoolTimer;

    
    private InputField inputField;

    private Text text;
 
    public string username;
    public string age;

    public float finalTime;
    
    public string button1;
    public string button2;
    public string button3;
    public string button4;
    public string button5;
    public string button6;
    public string button7;
    public string button8;

    private bool sent = false;

    
    public void setUsername(string value)
    {   
        username = value;
        print(username);
        
    }

    public void setAge(string value)
    {
        age = value;
        print(age);
    }

    public void setButton1(string value)
    {
        button1 = value;
        print(button1);
    }

     public void setButton2(string value)
    {
        button2 = value;
        print(button2);
    }

     public void setButton3(string value)
    {
        button3 = value;
        print("short road");
    }

     public void setButton4(string value)
    {
        button4 = value;
        print("short road");
    }

     public void setButton5(string value)
    {
        button5 = value;
        print("short road");
    }

     public void setButton6(string value)
    {
        button6 = value;
        print("short road");
    }

     public void setButton7(string value)
    {
        button7 = value;
        print("short road");
    }

     public void setButton8(string value)
    {
        button8 = value;
        print("short road");
    }
    
    public void setfinalTime(float value) {
            finalTime = value;
            print(finalTime);
    }

    IEnumerator SendLogRequest()
    {
        var req = new UnityWebRequest(SERVER_ENDPOINT, "POST");
        var data = Encoding.UTF8.GetBytes(JsonUtility.ToJson(this));
        print(JsonUtility.ToJson(this));
        req.uploadHandler = new UploadHandlerRaw(data);
        req.downloadHandler = new DownloadHandlerBuffer();
        req.SetRequestHeader("Content-Type", "application/json");
        yield return req.SendWebRequest();
        if (req.isNetworkError)
        {
            print(req.error);
        } 
        print(req.downloadHandler.text);
    }

    public void LogToServer()
    { if(sent) return; 
        sent = true;
        StartCoroutine(SendLogRequest());
    }

}





















