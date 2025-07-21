using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    public Transform _respawnPoint;
    public int _playerLife = 3;
    public int _playerCoin = 0;
    private const string deathTag = "Death";
    private const string healthTag = "Health";
    private const string coinTag = "Coin";
    private const string respawnTag = "Respawn";
    private const string respawnColPoint = "Point";
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        string colTag = collision.tag;
        switch (colTag)
        {
            case deathTag:
                {
                    _rigidbody2D.velocity = Vector2.zero;
                    transform.position = _respawnPoint.position;
                    _playerLife--;
                    return;
                }

            case healthTag:
                {

                    _playerLife++;
                    Destroy(collision.gameObject);
                    return;
                }
            case coinTag:
                {

                    _playerCoin++;
                    Destroy(collision.gameObject);
                    return;
                }
            case respawnTag:
                {

                    _respawnPoint = collision.gameObject.transform.FindChild(respawnColPoint).transform;
                    return;
                }
        }
    }
}

        
    


