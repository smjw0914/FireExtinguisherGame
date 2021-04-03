using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireExtinguisher_Drag : MonoBehaviour
{

    public float rotSpeed = 100.0f;
    void Start()
    {
        Debug.Log("1");
        transform.position = new Vector3(215, -277, 13);
        Debug.Log("2");
        transform.localEulerAngles = new Vector3(-90, 180, - 90);

        transform.localScale += new Vector3(100, 100, 80);
    }

    void Update()
    {
        OnMouseDrag();
       // transform.localScale = new Vector3(100, 100, 100);
    }

    void OnMouseDrag()
    {
        if (Input.GetMouseButton(0))
        {
            float rotX = Input.GetAxis("Mouse X") * rotSpeed * Time.deltaTime;
            float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Time.deltaTime;
   
            transform.Rotate(Vector3.back * rotX);
           // transform.Rotate(Vector3.up * rotY);
            
        }
    }

}
