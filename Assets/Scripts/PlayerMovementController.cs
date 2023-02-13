using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField]
    private PlayerAnimationController animcontroller;

    private float x = 0;
    private float y = 0;
    private float mouseX = 0;

    private bool isRunning = false;
    [SerializeField]
    private CharacterController ccontroller;
    [SerializeField]
    private CameraController cameraController;

    [SerializeField]
    private float speed = 1f;
    [SerializeField]
    private float sideSpeed = 0.5f;

    [SerializeField]
    private float animatedRotationSpeed = 5f;

    private void GetMovementOld()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        isRunning = (Mathf.Abs(y) > 0.1f || Mathf.Abs(x) > 0.1f);
    }
    private void MovePlayer()
    {
        Vector3 movement = Vector3.zero;
        movement += transform.forward * y * Time.deltaTime * speed;
        movement += transform.right * x * Time.deltaTime * sideSpeed;
        ccontroller.Move(movement);
    }

    

    private void GetJumpOld()
    {

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetMovementOld();
        MovePlayer();
        
        animcontroller.Animate(new Vector2(x, y), false,isRunning);
        
       if(isRunning&&!Input.GetMouseButton(1))
        SlowLookAt(cameraController.Forward);
    }

    void SlowLookAt(Vector3 targetVector)
    {
        Vector3 relativePos = targetVector;
        Quaternion toRotation = Quaternion.LookRotation(relativePos);
       
        transform.rotation = Quaternion.Lerp(transform.rotation, toRotation, animatedRotationSpeed * Time.deltaTime);
        
    }
}
