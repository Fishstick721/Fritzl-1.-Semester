using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Car : MonoBehaviour
{
    public float acceleration;
    public float RotationSpeed;
    public float MaxSpeed;
    public Text txtSpeed;
    Rigidbody rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }


    void Update()
    {
        AddSpeed();
        AddRotation();
        AdjustVelocity();
        txtSpeed.text = "Speed :" + rigid.velocity.magnitude.ToString("0.##") + "KM/H"; 
        

        void AddSpeed()
        {
            if (rigid.velocity.magnitude < MaxSpeed)
            {
                float Inputforward = Input.GetAxis("Vertical");

                rigid.AddForce(transform.forward * acceleration * Inputforward);
            }
        }

        void AddRotation()
        {
            float rotation = Input.GetAxis("Horizontal");
            transform.Rotate(new Vector3(0, rotation * RotationSpeed, 0));
        }

        void AdjustVelocity()
        {
            Vector3 velocity = rigid.velocity;

            float direction = Vector3.Dot(transform.forward, velocity.normalized);

            if (direction > 0)
            {
                velocity = transform.forward * velocity.magnitude;
            }
            if (direction < 0)
            {
                velocity = -transform.forward * velocity.magnitude;
            }
            rigid.velocity = velocity;
        }
    }
    }