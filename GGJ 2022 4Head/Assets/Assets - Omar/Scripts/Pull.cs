using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pull : MonoBehaviour
{
    private GameObject player;
    private Vector3 playerPos;
    public GameObject pullObstacle;
    private Vector3 obstaclePos;

    [SerializeField] private float pullForceSpeed;

    // Start is called before the first frame update
    void Start()
    {
       player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = player.transform.position;
        obstaclePos = pullObstacle.transform.position;

         player.transform.position = Vector3.Lerp(transform.position, obstaclePos, Time.deltaTime * pullForceSpeed);

        if(Mathf.Abs(obstaclePos.x - playerPos.x) < 0.05){
           
            player.transform.position = obstaclePos;

        }
    }
    
}
