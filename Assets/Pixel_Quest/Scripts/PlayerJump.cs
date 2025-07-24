using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    public float jumpForce = 10;
    public float fallForce;
    public Transform feetCollider;
    public LayerMask groundMask;
    private bool _waterCheck;
    private bool _groundCheck;
    private Vector2 _gravityVector;

    // Start is called before the first frame update
    void Start()
    {
        _gravityVector = new Vector2(0, -Physics2D.gravity.y);
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _groundCheck = Physics2D.OverlapCapsule(feetCollider.position, new Vector2(3, 0.00f), CapsuleDirection2D.Horizontal, 0, groundMask);
        if (Input.GetKeyDown(KeyCode.Space) && (_groundCheck || _waterCheck))
        {
            _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, jumpForce);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Water")
        {
            _waterCheck = true;
        }
        if(_rigidbody2D.velocity.y < 0)

            if ((_rigidbody2D.velocity.y < 0 && !_waterCheck))
        {
            _rigidbody2D.velocity -= _gravityVector *  (fallForce * Time.deltaTime);
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Water")
        {
            _waterCheck = false;
        }

    }
}
