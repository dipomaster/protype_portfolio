using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    Animator m_Animator;
    public GameObject treasure;
    public bool activate;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (activate)
            Interact();        
        Open();
    }
    void Interact()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log(m_Animator.name);
            m_Animator.SetTrigger("Activate");
           
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            activate = true;
         
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            activate = false;
            if (treasure == null)
                m_Animator.enabled = false;
            m_Animator.ResetTrigger("Activate");
        }
    }

    private void Open()

    {
        if(m_Animator.GetBool("Activate"))
        {
            if(treasure!=null)
            treasure.SetActive(true);
           // if (m_Animator.IsInTransition(0) == false)
            //    m_Animator.enabled = false;
        }
    }
   
}
