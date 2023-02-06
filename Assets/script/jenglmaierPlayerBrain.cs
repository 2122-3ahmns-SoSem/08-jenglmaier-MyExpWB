using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class jenglmaierPlayerBrain : MonoBehaviour
{
    public float health = 100f;
    public float maxHealth = 100f;
    public TextMeshProUGUI scoreboard;
    public Rigidbody rb;
    public string forwardKey;
    public string backKey;
    public string leftKey;
    public string rightKey;
    public string jumpKey;
    //public GameObject scoreboard;
   

    public float jumpForce = 500;
    public Vector3 forwardForce;
    public Vector3 sideForce;

    
    void Update()
    {

        if (Input.GetKey(forwardKey))
        {
            rb.AddRelativeForce(forwardForce);
        }
        if (Input.GetKey(backKey))
        {
            rb.AddRelativeForce(-forwardForce);
        }
        if (Input.GetKey(leftKey))
        {
            rb.AddRelativeForce(sideForce);
        }
        if (Input.GetKey(rightKey))
        {
            rb.AddRelativeForce(-sideForce);
        }
        if (Input.GetKeyDown(jumpKey))
        {
            rb.AddRelativeForce(new Vector3(0, jumpForce, 0));
        }

        if (health == 100)
        {
            Debug.Log("Du hast gewonnen!");
        }



    }

    // private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("Mein Spieler kolidiert mit etwas!");
    //      Debug.Log("bombe");
    //
    //      if (collision.gameObject.tag == "bombe")
    //      {
    //           health = health - 10;
    //      }
    //
    //      if (collision.gameObject.tag == "Gift")
    //     {
    //          health = health + 30;
    //      }
    //
    //       if (collision.gameObject.tag == "Gift1")
    //     {
    //          health = health + 20;
    //      }
    //
    //      if (collision.gameObject.tag == "Gift2")
    //      {
    //          health = health + 10;
    //      }
    // }


    private List<(string tag, int change)> collisions = new List<(string, int)>
    {
    ("bombe", -10),
    ("Gift", 30),
    ("Gift1", 20),
    ("Gift2", 10),
    };

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Mein Spieler kolidiert mit etwas!");
        Debug.Log("bombe");

        foreach ((string tag, int change) in collisions)
        {
            if (collision.gameObject.tag == tag)
            {
                health = health + change;
            }
        }
    }
}



