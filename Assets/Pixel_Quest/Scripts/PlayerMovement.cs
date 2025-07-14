using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private SpriteRenderer _spriteRenderer;
    public float xMultiplier = 4;
    // Start is called before the first frame update
    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _spriteRenderer = transform.GetChild(0).GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float xMovment = Input.GetAxis("Horizontal");
        if (xMovment > 0)
        {
            _spriteRenderer.flipX = true;
        }
        else
        {
            _spriteRenderer.flipX = false;
        }
            _rigidbody2D.velocity = new Vector2(xMultiplier * xMovment, _rigidbody2D.velocity.y);
        
    }
}
