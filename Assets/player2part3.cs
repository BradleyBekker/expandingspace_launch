﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2part3 : MonoBehaviour {
    public GameObject rocket;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player2")
        {
            rocket.GetComponent<P2rocket>().part3 = true;
            DestroyObject(gameObject);
        }
    }
}
