﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2movement : MonoBehaviour {

    public float speed = 7;             //Floating point variable to store the player's movement speed.
    public float jumpHeight = 50;
    private bool _allowMovement = true;
    private bool _isonground = true;

    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.RightArrow) && _allowMovement)
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed, Space.World);

        }
        if (Input.GetKey(KeyCode.LeftArrow) && _allowMovement)
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed, Space.World);

        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && _isonground)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
            _isonground = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground") { _isonground = true; }
    }
}

