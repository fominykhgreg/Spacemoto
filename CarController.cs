﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {
    public int AddSpeed;
    public int MaxSpeed;
    public int MotorTorque = 10000;
    public WheelJoint2D[] Wheels = new WheelJoint2D[2];
    JointMotor2D Motor;
    public int GetAxisRaw;



    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update() {

        

        if (GetAxisRaw > 0 && Motor.motorSpeed > -MaxSpeed)
        {
            Motor.motorSpeed = (Motor.motorSpeed - AddSpeed) -Time.deltaTime;
            Motor.maxMotorTorque = MotorTorque;
            Wheels[0].motor = Motor;
            Wheels[1].motor = Motor;
        }
        else if (GetAxisRaw < 0 && Motor.motorSpeed < MaxSpeed)
        {
            Motor.motorSpeed = (Motor.motorSpeed + AddSpeed) + Time.deltaTime;
            Motor.maxMotorTorque = MotorTorque;
            Wheels[0].motor = Motor;
            Wheels[1].motor = Motor;
        }
        else if (GetAxisRaw == 0)
        {
            if (Motor.motorSpeed > 0)
            {
                Motor.motorSpeed = (Motor.motorSpeed - AddSpeed) - Time.deltaTime;
                Wheels[0].motor = Motor;
                Wheels[1].motor = Motor;
            }
            else if (Motor.motorSpeed < 0)
            {
                Motor.motorSpeed = (Motor.motorSpeed + AddSpeed) + Time.deltaTime;
                Wheels[0].motor = Motor;
                Wheels[1].motor = Motor;
            }
        }
        

    }
    public void Move(int InputAxis)
    {

       GetAxisRaw= InputAxis;

    }

}
