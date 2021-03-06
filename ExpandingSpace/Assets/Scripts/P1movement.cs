﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1movement : MonoBehaviour
{

    public float speed = 3;             //Floating point variable to store the player's movement speed.
    public float jumpHeight = 4;
    private bool _allowMovement = true;
    private bool _isonground = true;

    [SerializeField] private GameObject playerrocket;

    [SerializeField] private GameObject part1;
    [SerializeField] private GameObject part2;
    [SerializeField] private GameObject part3;
    Animator anim;

    // Update is called once per frame
    private void Start()
    {
        anim = GetComponent<Animator>();

    }
    void Update()
    {
        anim.SetFloat("speed", 0);

        if (Input.GetKeyDown(KeyCode.B))
        {
            Death();
        }
        if (Input.GetKey(KeyCode.D) && _allowMovement)
        {
            transform.localScale = new Vector3(1, 1, 1);
            anim.SetFloat("speed", 1);
            transform.Translate(Vector2.right * Time.deltaTime * speed, Space.World);

        }
        if (Input.GetKey(KeyCode.A) && _allowMovement)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            anim.SetFloat("speed", 1);
            transform.Translate(Vector2.left * Time.deltaTime * speed, Space.World);

        }
        if (Input.GetKeyDown(KeyCode.W) && _isonground)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
            _isonground = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground") { _isonground = true; }
    }




    private void Death()
    {
        Vector2 spawn = new Vector2(1.82f, 0.25f);
        Vector3 item1spawn = new Vector3(transform.position.x + 5, transform.position.y, transform.position.z);
        Vector3 item2spawn = new Vector3(transform.position.x + -5, transform.position.y, transform.position.z);
        Vector3 item3spawn = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        if (playerrocket.GetComponent<P1rocket>().part1 == true)
        {
            playerrocket.GetComponent<P1rocket>().part1 = false;
            Instantiate(part1, item1spawn, Quaternion.identity);

        }
        if (playerrocket.GetComponent<P1rocket>().part2 == true)
        {
            playerrocket.GetComponent<P1rocket>().part2 = false;
            Instantiate(part2, item2spawn, Quaternion.identity);

        }
        if (playerrocket.GetComponent<P1rocket>().part3 == true)
        {
            playerrocket.GetComponent<P1rocket>().part3 = false;
            Instantiate(part3, item3spawn, Quaternion.identity);

        }
        transform.position = spawn;

    }
}