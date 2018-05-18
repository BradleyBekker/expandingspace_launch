using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1movement : MonoBehaviour {
    public float speed = 3;             //Floating point variable to store the player's movement speed.
    public float jumpHeight = 4;
    private bool allowMovement = true;
    private bool isonground = true;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D) && allowMovement)
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed, Space.World);

        }
        if (Input.GetKey(KeyCode.A) && allowMovement)
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed, Space.World);

        }
        if (Input.GetKeyDown(KeyCode.W) && isonground)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
            isonground = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground") { isonground = true; }
    }
}
