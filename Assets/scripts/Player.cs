using UnityEngine;
using System.Collections;

public class Player: MonoBehaviour {



    public float jumpHeight;
    public GameObject deadpool;
    public Rigidbody2D rb;
    public int scorev = 1;

    public ScoreTable scoretable;
   
    public  bool IsGrounded;
    // Use this for initialization

    void Awake()
    {
        

        rb = GetComponent<Rigidbody2D>();

    }
    
        // Update is called once per frame
        void Update()
    {
      
        if (Input.GetKeyDown("space") && IsGrounded)
        {

            print("space key was pressed");

            rb.AddForce(Vector2.up * jumpHeight);
            scoretable.addScore(scorev);
        }   


      }
        
    }

