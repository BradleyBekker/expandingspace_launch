using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1movement : MonoBehaviour {

    public float speed = 3;             //Floating point variable to store the player's movement speed.
    public float jumpSpeed = 1;
    //private bool _allowMovement = true;

    // variables for the jump mechanic
    public float _gravityFactor = 0.03f;
    public bool _fallDown = true;
    public bool isJumping;
    private bool _constantFall;
    private float _posJump;
    private bool _isOnGround = false;

    private void Awake()
    {
        _posJump = -0.025f;
    }
    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if (_isOnGround)
            {
                GetComponent<Rigidbody2D>().MovePosition( new Vector2( (transform.position.x - speed), transform.position.y ));
            }
            else if (!_isOnGround)
            {
                GetComponent<Rigidbody2D>().MovePosition( new Vector2( (transform.position.x - speed), CalculateJump() ));
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (_isOnGround)
            {
                GetComponent<Rigidbody2D>().MovePosition( new Vector2( (transform.position.x + speed), transform.position.y ));
            }
            else if (!_isOnGround)
            {
                GetComponent<Rigidbody2D>().MovePosition( new Vector2( (transform.position.x + speed), CalculateJump() ));
            }
        }
        
        if (Input.GetKeyDown(KeyCode.W) && _isOnGround)
        {
            if (_isOnGround)
            {
                _posJump = 0.175f;
                _isOnGround = false;
                isJumping = true;
            }
        }

        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D) && !_isOnGround)
        {
            GetComponent<Rigidbody2D>().MovePosition( new Vector2 (transform.position.x, CalculateJump() ));
        }
    }

    private float CalculateJump()
    {
        if (!_fallDown)
        {
            if(_posJump * (1 - _gravityFactor * 1.25) > 0.007 )
            {
                _posJump = _posJump * (1 - _gravityFactor * 1.25f);
            }
            else
            {
                _posJump = -0.007f;
                _fallDown = true;
            }
            return transform.position.y + _posJump;
        }
        else
        {
            
            if (_posJump * (1 - _gravityFactor) > -.07 && !_constantFall)
            {
                _posJump = _posJump * (1 + _gravityFactor);
            }
            else
            {
                _posJump = -.07f;
                _constantFall = true;
            }
            return transform.position.y + _posJump;
        }  
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            _isOnGround = true;
            _fallDown = false;
            isJumping = false;
            _constantFall = false;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        _isOnGround = false;
        if (!isJumping)
        {
            _fallDown = true;
        }
    }
}
