using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeoController : MonoBehaviour
     
{
    private Rigidbody2D rb;
    public int speed = 10;
    public float jumpforce = 4;
    public string nextlevel = "Scene_2";
    public string Win = "Win";
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Debug.Log("Hello Wolrd");
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Death":
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    break;
                }
            case "Finish":
                {
                    SceneManager.LoadScene(nextlevel);
                    break;



                }
            case "GG!":
                {

                    SceneManager.LoadScene(Win);
                    break;
                }

        }

    }
    
         
                // Update is called once per frame

   

    private void Update()
    {

        float xInput = Input.GetAxis("Vertical");
    float yInput = Input.GetAxis("Horizontal");
    rb.velocity = new Vector2(yInput * speed, rb.velocity.y);

        /*
    if (Input.GetKeyDown(KeyCode.W))
    {
        transform.position += new Vector3(0, 1, 0);
    }
    if (Input.GetKeyDown(KeyCode.S))
    {
        transform.position += new Vector3(0, -1, 0);
    }
    if (Input.GetKeyDown(KeyCode.A))
    {
        rb.velocity = new Vector2(-1, rb.velocity.y);
    }
    if (Input.GetKeyDown(KeyCode.D))
    {
        rb.velocity = new Vector2(-1, rb.velocity.y);
    }


            */

        

    }
}




