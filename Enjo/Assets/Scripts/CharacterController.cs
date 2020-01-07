using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterController : MonoBehaviour
{
    private float InputX, InputZ, Speed;
    private Camera Cam;
    private CharacterController Character_Controller;

    private Vector3 DisiredMoveDirection;

    [Range(0.001f, 1f)]
    [SerializeField] float RotationSpeed = 0.3f;
    [SerializeField] float AllowRotation;
    // Start is called before the first frame update
    void Start()
    {
        Character_Controller = GetComponent<CharacterController>();
        Cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        InputX = Input.GetAxis("Horizontal");
        InputZ = Input.GetAxis("Vertical");

        InputDecider();
    }
    void InputDecider()
    {
        Speed = new Vector2(InputX, InputZ).sqrMagnitude;

        if (Speed > AllowRotation)
        {
            RotationManager();
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
}
https://www.youtube.com/watch?v=9rB5TxxbwUU