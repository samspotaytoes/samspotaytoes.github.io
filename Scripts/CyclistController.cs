﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyclistController : MonoBehaviour
{

    public Animator anim;
    private bool isTurning;

    void Update() {
        anim.SetFloat("vertical", Input.GetAxis("Vertical"));
        anim.SetFloat("horizontal", Input.GetAxis("Horizontal"));        
    }

//  private string moveInputAxis = "Vertical";
//  private string turnInputAxis = "Horizontal";

//  public float rotationRate = 360;
//  public float moveSpeed = 2;


//  void Update()
//  {
//      float moveAxis = Input.GetAxis(moveInputAxis);
//      float turnAxis = Input.GetAxis(turnInputAxis);

//      ApplyInput(moveAxis, turnAxis);
//  }

//  private void ApplyInput(float moveInput,
//                         float turnInput)
//  {
//     Move(moveInput);
//     Turn(turnInput);   
//  }
 
//  private void Move(float input)
//  {
//      transform.Translate(Vector3.forward * input * moveSpeed);
//  }

//  private void Turn(float input)
//  {
//      transform.Rotate(0, input * rotationRate * Time.deltaTime, 0);
//  }

   
}
