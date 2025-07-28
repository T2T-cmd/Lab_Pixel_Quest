using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SecondLevel : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    public Transform _respawnPoint;
    private UIController uIController;
    public string nextlevel = "level_23";
    private const string finishTag = "Finish";
    // Start is called before the first frame update
    void Start()
    {

    }
    private void Update()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
     
       
        
        string colTag = collision.tag;
       
        switch (colTag) {

                    case finishTag:
            {
                {
                    SceneManager.LoadScene(nextlevel);
                        break;

                }
            }

        }
    }
}
