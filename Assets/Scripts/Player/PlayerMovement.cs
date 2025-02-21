using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float _walkSpeed;
    
    [SerializeField]
    private InputManager _input;

    [SerializeField]
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        _input.OnMoveInput += Move;
    }

    private void OnDestroy()
    {
        _input.OnMoveInput -= Move;
    }

    private void Move(Vector2 movement)
    {
        if (movement.magnitude >= 0.1)
        {
            float rotationAngle = Mathf.Atan2(movement.y, movement.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, rotationAngle, 0f);
            Vector3 movementVector = new Vector3(movement.x, 0, movement.y);
            _rigidbody.AddForce(movementVector * _walkSpeed * Time.deltaTime);
            Debug.Log(movementVector);    
        }
    }
    /*https://youtu.be/ZRUHPq0xr3g?list=PLl_bUNTjdjcKBpY9s-576UZscBl3lhfKD&t=515*/
}
