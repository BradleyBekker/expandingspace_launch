using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1movement : MonoBehaviour {

    public float speed = 3;             //Floating point variable to store the player's movement speed.
<<<<<<< HEAD
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
=======
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
>>>>>>> fd43d9a267f8cf26a4be53c8591f5c8a5f10bafe
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
<<<<<<< HEAD
        if (Input.GetKey(KeyCode.D) && _allowMovement)
        {
            transform.localScale = new Vector3(1, 1, 1);
            anim.SetFloat("speed", 1);
            transform.Translate(Vector2.right * Time.deltaTime * speed, Space.World);
=======
>>>>>>> fd43d9a267f8cf26a4be53c8591f5c8a5f10bafe

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
<<<<<<< HEAD
            transform.localScale = new Vector3(-1, 1, 1);
            anim.SetFloat("speed", 1);
            transform.Translate(Vector2.left * Time.deltaTime * speed, Space.World);

=======
            if (_isOnGround)
            {
                _posJump = 0.175f;
                _isOnGround = false;
                isJumping = true;
            }
>>>>>>> fd43d9a267f8cf26a4be53c8591f5c8a5f10bafe
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
