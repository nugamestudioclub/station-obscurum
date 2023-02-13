using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    private float mouseX = 0;
    private float mouseY;
    [SerializeField]
    private Camera cam;
    [SerializeField]
    private Transform target;

    private Vector3 offset;

    private Vector3 forward= Vector3.zero;
    public Vector3 Forward { get { return this.forward; } }

    private float originalDist = 0;
    private float newDist = 0;
    [SerializeField]
    private bool isChild = false;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetMouseLook();
        //if(target!=null&&!isChild)
        //transform.position = target.transform.position+offset;
        forward = new Vector3(cam.transform.forward.x, target.transform.forward.y, cam.transform.forward.z);

    }
    private void GetMouseLook()
    {
        //mouseX = Input.GetAxis("Mouse X");
        //mouseY = Input.GetAxis("Mouse Y");
    
        //transform.Rotate(0, mouseX * Time.deltaTime * 180f, 0);
        //cam.transform.parent.parent.transform.Rotate(mouseY * Time.deltaTime * 180f, 0, 0);

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }


}
