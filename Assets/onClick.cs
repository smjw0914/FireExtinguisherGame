using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class onClick : MonoBehaviour
{

    private Animator animator;

    public void btnClick()
    {
        animator = GameObject.Find("FireExtinguisher").GetComponent<Animator>();
        animator.SetBool("pinMode", true);
    }

}
