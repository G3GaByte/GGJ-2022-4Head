using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pull : MonoBehaviour
{
    public GameObject player;
    private Vector3 playerPos;
    public Vector3 obstaclePos;
    // Start is called before the first frame update
    void Start()
    {
       playerPos = new Vector3(player.transform.position.x, player.transform.position.y,player.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
