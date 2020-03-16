using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    public Transform target;
    [Range(1f,10f)]
    public float smoothSpeed = .125f;
    public Vector3 offset;
    public float xRange;
    public float yRange;
    private void FixedUpdate()
    {  float rotateHorizontal = Input.GetAxis("Mouse X")*xRange/10;
       float rotateVertical = -Input.GetAxis("Mouse Y")*yRange/10;
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothPosition = Vector3.Slerp(transform.position, desiredPosition, smoothSpeed/100f);
        transform.position = smoothPosition;
        Screen.lockCursor = true;
        if (Input.GetAxis("Mouse X") == 0 && Input.GetAxis("Mouse Y") == 0)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(target.position - transform.position), smoothSpeed / 100f);
        }
        else
        {
            Vector3 rotation = new Vector3(rotateVertical, rotateHorizontal, 0.0f);
            rotation.z = 0f;
            transform.Rotate(rotation);
        }




    }

   

}
