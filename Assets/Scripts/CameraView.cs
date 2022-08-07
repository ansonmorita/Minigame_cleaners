using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraView : MonoBehaviour
{
    public RotationAxes axesMouse = RotationAxes.MouseXAndY;
    public float sensitivityMouse = 5f;
 
    // Limit Y axis rotation
    public float minimumY = -45f;
    public float maximumY = 45f;

    float rotationY = 0f;
    
    public enum RotationAxes
    {
        MouseXAndY = 0,
        MouseX = 1,
        MouseY = 2
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        // Prevent rigidbody affect rotation
        if (GetComponent<Rigidbody>()) 
        {
            GetComponent<Rigidbody> ().freezeRotation = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (axesMouse == RotationAxes.MouseXAndY) 
        {
            float rotationX = transform.localEulerAngles.y + Input.GetAxis ("Mouse X") * sensitivityMouse;
            rotationY += Input.GetAxis ("Mouse Y") * sensitivityMouse;
            rotationY = Mathf.Clamp (rotationY, minimumY, maximumY);

            transform.localEulerAngles = new Vector3 (-rotationY, rotationX, 0);
        } 
        else if (axesMouse == RotationAxes.MouseX) 
        {
            transform.Rotate (0, Input.GetAxis ("Mouse X") * sensitivityMouse, 0);
        } 
        else 
        {
            rotationY += Input.GetAxis ("Mouse Y") * sensitivityMouse;
            rotationY = Mathf.Clamp (rotationY, minimumY, maximumY);

            transform.localEulerAngles = new Vector3 (-rotationY, transform.localEulerAngles.y, 0);
        }
    }
}
