using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    public Transform _respawnPoint;
    private UIController uIController;
    public int _playerLife = 3;
    private float _maxHealth = 3.0f;
    public int _playerCoin = 0;
       
    public string nextlevel = "level_2";
    private const string deathTag = "Death";
    private const string healthTag = "Health";
    private const string coinTag = "Coin";
    private const string respawnTag = "Respawn";
    private const string finishTag = "Finish";
    private const string respawnColPoint = "Point";
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        uIController = GameObject.FindAnyObjectByType<UIController>();
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
                    uIController.heartImageUpdate(_playerLife / _maxHealth);    
                    if (_playerLife < 0)
                    {
                        string sceneName= SceneManager.GetActiveScene().name;
                        SceneManager.LoadScene(nextlevel);
                    }
                    return;
                }

            case healthTag:
                {
                    if (_playerLife == 3) { return; }
                    _playerLife++;
                    uIController.heartImageUpdate(_playerLife / _maxHealth);
                    Destroy(collision.gameObject);
                    return;
                }
            case coinTag:
                {

                    _playerCoin++;
                    uIController.cointextUpdate(_playerCoin);
                    Destroy(collision.gameObject);
                    return;
                }
            case finishTag:
                {
                    SceneManager.LoadScene(nextlevel);
                        return;
                   
                }
        }
    }
}

        
    


