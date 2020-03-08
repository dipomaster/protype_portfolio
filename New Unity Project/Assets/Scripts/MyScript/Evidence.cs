﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Evidence : MonoBehaviour
{
    public GameManager GM;
    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GM.Score++; 
            Destroy(gameObject);
        }
    }

}
