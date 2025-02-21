using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public Action<Vector2> OnMoveInput;
    private void Update()
    {
        CheckJumpInput();
        CheckMovementInput();
        CheckSprintInput();
        CheckCrouchInput();
        CheckChangePOVInput();
        CheckClimbInput();
        CheckGlideInput();
        CheckCancelClimbGlideInput();
        CheckPunchInput();
        CheckMainMenuInput();
    }

    
    private void CheckJumpInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Jump");
        }
    }

    private void CheckMovementInput()
    {
        float verticalAxis = Input.GetAxis("Vertical");
        float horizontalAxis = Input.GetAxis("Horizontal");
        
        Vector2 inputAxis = new Vector2(horizontalAxis, verticalAxis);
        if (OnMoveInput != null)
        {
            OnMoveInput(inputAxis);
        }
    }

    private void CheckSprintInput()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Debug.Log("Sprinting");
        }
    }

    private void CheckCrouchInput()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            Debug.Log("Crouching");
        }
    }

    private void CheckChangePOVInput()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Changing POV Camera");
        }
    }

    private void CheckClimbInput()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Climbing");
        }
    }

    private void CheckGlideInput()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log("Gliding");
        }
    }

    private void CheckCancelClimbGlideInput()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("Cancel Climb/Glide");
        }
    }

    private void CheckPunchInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Punching");
        }
    }

    private void CheckMainMenuInput()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Opening Main Menu");
        }
    }

    

}
