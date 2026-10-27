using System;
using UnityEngine;
using UnityEngine.InputSystem; 

public class PlayerMovement : MonoBehaviour

{
    float speed = 8f;

    Vector2 move;
    
    public void OnMove(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("Jump");
        }
    }

    public void OnCrouch(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("Crouch");
        }
    }

    public void OnAttackLight(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("Normal Attack");
        }
    }


    private void Update()
    {
        Vector3 m = new Vector3(move.x, 0,0) * speed * Time.deltaTime;
        transform.Translate(m, Space.World);

    }

   
}
