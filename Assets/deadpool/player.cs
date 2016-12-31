using UnityEngine;
using System.Collections;

public class player: MonoBehaviour
{

    ScoreTable sc = new ScoreTable();
    public float jumpHeight;

    public Rigidbody2D rb;

    public int scorev = 1;
    public ScoreTable scoretable;
    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            print("space key was pressed");
            rb.AddForce(transform.up * jumpHeight);
            scoretable.addScore(scorev);

        }

    }
}
