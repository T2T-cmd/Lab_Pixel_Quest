using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAn : MonoBehaviour
{
    private Animator _animator;
    private Rigidbody2D _rigidbody2D;
    // Start is called before the first frame update
    private void Start()
    {
        _animator = GetComponent<Animator>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (_rigidbody2D.velocity.x != 0)
        {
            _animator.SetBool("IsWalking", true);
        }
        else
        {
            _animator.SetBool("IsWalking", false);
        }


    }
}
