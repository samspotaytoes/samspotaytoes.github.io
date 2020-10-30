using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
   [SerializeField]
   GameObject Door;
   


   void OnTriggerEnter(Collider col)
   {
       Door.transform.position += new Vector3(0, 10, 0);
   }
}
