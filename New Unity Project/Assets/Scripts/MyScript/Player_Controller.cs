using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{

    Animator m_Animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Interact();
    }
    //void Interact()
    //{


    //    if (Input.GetKeyDown(KeyCode.E))
    //    {
    //        m_Animator.SetTrigger("Activate");
    //    }  
    //}
    //private void OnTriggerEnter(Collider other)
    //{        
    //    //Get the Animator attached to the GameObject you are intending to animate.
    //    m_Animator = other.gameObject.GetComponent<Animator>();
    //}
    //private void OnTriggerExit(Collider other)
    //{
    //    m_Animator.ResetTrigger("Activate");
    //}
}
