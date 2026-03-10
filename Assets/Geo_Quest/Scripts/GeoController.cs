using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GeoController : MonoBehaviour
{
    //Player movement
    private Rigidbody2D rb2d;
    public int ySpeed = 5;
    public int xSpeed = 5;

    //Player color changer
    private SpriteRenderer sr;

    //Level changer
    public string nextLevel;

    //Start is called once when script is first activated
    void Start()
    {
        //Player movement
        rb2d = GetComponent<Rigidbody2D>();

        //Player color
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Player movement
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        rb2d.velocity = new Vector2(xInput * xSpeed, yInput * ySpeed);

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            sr.material.color = new Color32(255, 0, 0, 255);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            sr.material.color = new Color32(0, 255, 0, 255);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            sr.material.color = new Color32(0, 0, 255, 255); ;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Death":
            {
                string thisScene = SceneManager.GetActiveScene().name;
                SceneManager.LoadScene(thisScene);
                break;
            }
            case "Finish":
            {
                    SceneManager.LoadScene(nextLevel);
                    break;
            }
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {

    }
    private void OnTriggerExit2D(Collider2D collision)
    {

    }
}
