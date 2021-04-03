using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BtnClick : MonoBehaviour
{
    private Animator animator;
    //private GameObject = GameObject.Find("GameObject").transform.Find("자식 오브젝트이름").gameObject;
    public void btnClick()
    {
        Debug.Log("Enter");
        animator = GameObject.Find("Fire_Extinguisher").GetComponent<Animator>();
        Debug.Log("Find");
        animator.SetBool("pinMode", true);
        Debug.Log("Set");

        Invoke("next", 1);
    }

    private void next()
    {
        SceneManager.LoadScene("FinishScene");
    }
}
