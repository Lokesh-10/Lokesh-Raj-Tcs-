﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Enemydstry : MonoBehaviour
{   
 // Use this for initialization
    void Start()
    {

}

// Update is called once per frame
void Update()
{
        
    }
    void OnCollisionEnter(Collision collision)
    {
    if (collision.gameObject.tag == "enemy")
    {
        Destroy(collision.gameObject);
            scorekeeper.Instance.LessAlive(1);
        }
}
}


