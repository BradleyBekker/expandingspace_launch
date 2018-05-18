using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1movement : MonoBehaviour {
    public float speed = 3;             //Floating point variable to store the player's movement speed.
    public float jumpHeight = 4;
    private bool _allowMovement = true;
    private bool _isonground = true;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D) && _allowMovement)
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed, Space.World);

        }
        if (Input.GetKey(KeyCode.A) && _allowMovement)
        {
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
<<<<<<< HEAD:ExpandingSpace/Assets/Scripts/P1movement.cs
        if (collision.gameObject.tag == "ground") { _isonground = true; }
=======
        if (collision.gameObject.tag == "ground") { isonground = true; }
>>>>>>> 4204e6b5d704e5de12acbf919b35df0eef923563:Assets/scripts/P1movement.cs
    }
}
