using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public GameObject player;
    public float weight;
    // Start is called before the first frame update
    private void Start()
    {
       // player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            //player.GetComponent<Player_Controller>().baseScale += new Vector3(0.2f, 0.2f, 0.2f);
            //player.GetComponent<Rigidbody>().mass += weight;
            //player.GetComponent<Player_Controller>().exit = true;
            Destroy(gameObject);
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        
    }
}
