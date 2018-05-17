using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p2movement : MonoBehaviour {

    public float speed = 7;             //Floating point variable to store the player's movement speed.
    public float jumpHeight = 50;
    private bool allowMovement = true;
    private bool isonground = true;

    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.RightArrow) && allowMovement)
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed, Space.World);

        }
        if (Input.GetKey(KeyCode.LeftArrow) && allowMovement)
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed, Space.World);

        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && isonground)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
            isonground = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.collider.name);
        if (collision.gameObject.tag == "ground") { isonground = true; }
    }
}

