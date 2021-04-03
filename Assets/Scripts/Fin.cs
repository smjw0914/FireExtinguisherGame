using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fin : MonoBehaviour
{
    public ParticleSystem flame;
    public ParticleSystem smoke;
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit = new RaycastHit();
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray.origin, ray.direction, out hit))
            {
                if (hit.collider.gameObject.tag == "ParticleSystem")
                {
                    Debug.Log("particleSystem");

                    Debug.Log("btnUP");

                    flame.Stop();
                    Debug.Log("Flame X");

                    smoke.Stop();
                    Debug.Log("Smoke X");

                    Invoke("finish", 2);
                    //GameObject finished = canvas.transform.Find("Finish").gameObject;
                    //finished.SetActive(true);
                    /*
                    if (Input.GetMouseButtonUp(1))
                    {
                        Debug.Log("btnUP");

                        flame.SetActive(false);
                        Debug.Log("Flame X");

                        smoke.SetActive(false);
                        Debug.Log("Smoke X");

                        GameObject finished = canvas.transform.Find("Finish").gameObject;
                        finished.SetActive(true);
                    }
                    */
                }
            }
        }
        
    }

    public void finish()
    {
        GameObject finished = canvas.transform.Find("Finish").gameObject;
        finished.SetActive(true);

        //Invoke("exitScene", 1);
    }

    public void exitScene()

    {

        //실행을 종료하는 함수 생성

        Application.Quit();

    }
}
