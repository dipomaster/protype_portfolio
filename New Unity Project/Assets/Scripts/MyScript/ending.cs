using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ending : MonoBehaviour
{
    public GameObject endPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        endPanel.SetActive(true);
    }
}
