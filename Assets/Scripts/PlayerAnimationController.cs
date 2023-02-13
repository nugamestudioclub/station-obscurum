using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    [SerializeField]
    private Animator animController;
    [SerializeField]
    private string runningParameter;
    [SerializeField]
    private string runningSpeedParameter;
    [SerializeField]
    private string sideStepSpeedParameter;

    private float runningSpeed;
    private float sideStepSpeed;

    private bool isRunning;
    private bool movementInterrupt = false;
    

    public void Animate(Vector2 movement,bool jump,bool isMoving)
    {
        animController.SetFloat(runningSpeedParameter, movement.y);
        animController.SetBool(runningParameter,isMoving);
        animController.SetFloat(sideStepSpeedParameter, movement.x);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}

public enum PlayerAnimationType {Movement,Action}