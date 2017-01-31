using UnityEngine;
using System.Collections;

public class RotateObjectOnDrag : MonoBehaviour {

    float rotSpeed = 80.0f;
        
	void OnMouseDrag()
    {
        if (MenuManager.isRotatable)
        {
            float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
            float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;

            transform.Rotate(Vector3.up, -rotX);
            transform.Rotate(Vector3.right, rotY);
        }        
    }
}
