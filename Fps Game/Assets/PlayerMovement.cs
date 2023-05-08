using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    private Vector3 moveInput;
    public CharacterController characterController;

    public float speed = 10f;
    void Start()
    {
        
    }

    
    void Update()
    {
        characterController.Move(moveInput * speed * Time.deltaTime);
    }

    private void OnMove(InputValue value )
    {
        moveInput = value.Get<Vector3>();
        Debug.Log(moveInput);
    }
}
