using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump: MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    public float jumpforce = 10;
    public Transform feetCollider;
    public LayerMask groundMask;


    // Start is called before the first frame update
    void Start()
    {
       _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        bool groundCheck = Physics2D.OverlapCapsule(feetCollider.position, new Vector2(1, 0.00f), CapsuleDirection2D.Horizontal, 0, groundMask);
        if (Input.GetKeyDown(KeyCode.Space) && groundCheck)
        {
            _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, jumpforce); 
        }
    }
}
