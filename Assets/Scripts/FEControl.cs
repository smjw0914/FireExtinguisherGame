using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FEControl : MonoBehaviour
{

    //GetComponent<ParticleSystem>().Play();
    ParticleSystem particles;


    // Start is called before the first frame update
    void Start()
    {
        particles = GetComponentInChildren<ParticleSystem>();
        particles.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            //Debug.Log("Right Mouse Button Clicked");
            particles.Play();

        }

        if (Input.GetMouseButtonUp(1))
        {
            //Debug.Log("Right Mouse Button Released");
            particles.Stop();
        }
    }
}
