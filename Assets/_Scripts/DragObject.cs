using UnityEngine;
using System.Collections;

public class DragObject : MonoBehaviour {

    private Vector3 screenPoint;
    private Vector3 offset;
    
    void OnMouseDown()
    {
        if (!MenuManager.isRotatable)
        {
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        }
    }

    void OnMouseDrag()
    {
        if (!MenuManager.isRotatable)
        {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            transform.position = curPosition;
        }        
    }

    //   float distance = 2.0f;

    //   void OnMouseDrag()
    //   {
    //       Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
    //       Vector3 objectPosition = Camera.main.WorldToScreenPoint(mousePosition);
    //       transform.position = objectPosition;
    //   }


}
