using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraZoom : MonoBehaviour
{
    public float ZoomSpeed = 10f;         // 줌 스피드.
    public float Distance;          // 카메라와의 거리.

    private Vector3 AxisVec;        // 축의 벡터.
    private Transform MainCamera;   // 카메라 컴포넌트.
    private GameObject btn;

    void Start()
    {
        MainCamera = Camera.main.transform;
        btn = GameObject.Find("Canvas").transform.Find("Button").gameObject;
        //btn = GameObject.FindWithTag("Button");
    }

    void Update()
    {
        Zoom();
    }

    // 카메라 줌.
    void Zoom()
    {
        if(Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            Distance += Input.GetAxis("Mouse ScrollWheel") * ZoomSpeed;
            Distance = Mathf.Clamp(Distance, 5f, 10f);

            AxisVec = transform.forward;
            AxisVec *= Distance;
            MainCamera.position = transform.position + AxisVec;

            btn.SetActive(true);
        }
        
        else if(Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            Distance += Input.GetAxis("Mouse ScrollWheel") * ZoomSpeed * -1;
            Distance = Mathf.Clamp(Distance, 5f, 10f);

            AxisVec = transform.forward * -1;
            AxisVec *= Distance;
            MainCamera.position = transform.position + AxisVec;

            btn.SetActive(false);
        }
    }
}
