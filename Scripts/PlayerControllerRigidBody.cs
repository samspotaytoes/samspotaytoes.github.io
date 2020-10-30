using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerRigidBody : MonoBehaviour
{
   
 private string moveInputAxis = "Vertical";
 private string turnInputAxis = "Horizontal";

 public float rotationRate = 180;
 public float moveSpeed = 1100;
 
 public GameObject BikeControl;

private Rigidbody rb;

private void Awake()
{
    rb = this.GetComponent<Rigidbody>();
}
 void FixedUpdate()
 {
     float moveAxis = Input.GetAxis(moveInputAxis);
     float turnAxis = Input.GetAxis(turnInputAxis);

     ApplyInput(moveAxis, turnAxis);
 }

 private void ApplyInput(float moveInput,
                        float turnInput)
 {
    Move(moveInput);
    Turn(turnInput);   
 }
 
 private void Move(float input)
 {
     rb.AddForce(transform.forward * input * moveSpeed, ForceMode.Force);
 }

 private void Turn(float input)
 {
     transform.Rotate(0, input * rotationRate * Time.fixedDeltaTime, 0);
 }

   
}
