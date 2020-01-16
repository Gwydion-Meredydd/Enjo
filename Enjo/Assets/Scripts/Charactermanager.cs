
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class Charactermanager : MonoBehaviour
{
    private float InputX, InputZ, InputSprint, Speed, OriginalSpeed;
    private Camera Cam;
    private CharacterController character_Controller;

    private Vector3 DisiredMoveDirection;

    [SerializeField] Animator CharacterAnimator;
    [Range(0.001f, 1f)]
    [SerializeField] float RotationSpeed = 0.3f;
    [SerializeField] float AllowRotation = 0.1f;
    [SerializeField] float movementSpeed = 4f;
    [SerializeField] float SprintSpeed = 3f;
    [SerializeField] float JumpSpeed = 5f;
    [SerializeField] float gravity;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        CharacterAnimator = gameObject.GetComponent<Animator>();
        character_Controller = GetComponent<CharacterController>();
        Cam = Camera.main;
        OriginalSpeed = movementSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        InputX = Input.GetAxis("Horizontal");
        InputZ = Input.GetAxis("Vertical");
        InputSprint = Input.GetAxis("Fire3");

        InputDecider();
        MovementManger();
    }
    void InputDecider()
    {
        Speed = new Vector2(InputX, InputZ).sqrMagnitude;
        if (InputSprint == 1) 
        {
            movementSpeed = SprintSpeed;
        }
        else 
        {
            movementSpeed = OriginalSpeed;
        }
        if (Speed > AllowRotation)
        {
            RotationManager();
        }
        else 
        {
            DisiredMoveDirection = Vector3.zero;
        }
    }
    void RotationManager()
    {
        var forward = Cam.transform.forward;
        var right = Cam.transform.right;

        forward.y = 0;
        right.y = 0;

        forward.Normalize();
        right.Normalize();

        DisiredMoveDirection = forward * InputZ + right * InputX;

        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(DisiredMoveDirection), RotationSpeed);
    }
    void MovementManger() 
    {
        gravity -= 2.5f * Time.deltaTime;
        CharacterAnimator.SetFloat("X_Input", Speed);
        Vector3 moveDirection = DisiredMoveDirection * (movementSpeed * Time.deltaTime);
        moveDirection = new Vector3(moveDirection.x, gravity, moveDirection.z);
        character_Controller.Move(moveDirection);
        if (character_Controller.isGrounded) 
        {
            //gravity = 0;
            if (Input.GetButtonDown("Jump"))
            {
                gravity = JumpSpeed;
                CharacterAnimator.SetBool("Jump", true);
            }
            else if (character_Controller.isGrounded)
            {
                gravity = (gravity / Time.deltaTime);
                if (gravity < 0)
                {
                    gravity = 0;
                }
                CharacterAnimator.SetBool("Jump", false);
            }
        }
    }
}
