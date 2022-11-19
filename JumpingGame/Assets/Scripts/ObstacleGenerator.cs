using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject obs;
    public GameObject obs1;

    public float minSpeed;
    public float maxSpeed;
    public float currentSpeed;

    bool waiting;
    // Start is called before the first frame update
    void Start()
    {
        waiting = true;
        currentSpeed = minSpeed;
        GenerateObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        if(currentSpeed < maxSpeed){
            currentSpeed += .0000015f;
        }
    }

    void GenerateObstacle()
    {
        int rand = Random.Range(0,2);
        if(rand == 0){
            GameObject obstacle = Instantiate(obs, transform.position, transform.rotation);
            obstacle.GetComponent<Obstacle>().gen = this;
        }else if(rand == 1){
            GameObject obstacle = Instantiate(obs1, transform.position, transform.rotation);
            obstacle.GetComponent<Obstacle>().gen = this;
        }
        
    }

    public void GenerateObstacleWithGap(){
        float wait = Random.Range(3f, 5.2f);
        Invoke("GenerateObstacle", wait);
        waiting = true;
    }

}
