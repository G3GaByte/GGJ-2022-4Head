using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightMovement : MonoBehaviour
{   private GameObject player;

    private Rigidbody2D playerRb;

    [SerializeField] private float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");

        playerRb = player.GetComponent<Rigidbody2D>();
        
        playerRb.AddForce(Vector2.right * speed, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    [SerializeField] private float speedLimit;
    void Update()
    {
        

        
    }
}
