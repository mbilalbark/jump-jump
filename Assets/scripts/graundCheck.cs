using UnityEngine;
using System.Collections;

public class graundCheck : MonoBehaviour
{

    private Player player;

    void Start()
    {
        player = gameObject.GetComponent<Player>();

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        player.IsGrounded = true;

    }
    void OnTriggerStay2D(Collider2D col)
    {
        player.IsGrounded = true;

    }
    void OnTriggerExit2D(Collider2D col)
    {
        player.IsGrounded = false;
    }
   
}

