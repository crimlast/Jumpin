using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public ObstacleGenerator gen;
    // Start is called before the first frame update
    void Start()
    {
        gen.GenerateObstacleWithGap();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * gen.currentSpeed * Time.deltaTime);

        GameObject ob = this.gameObject;
        //destroy this object after 20 seconds
        Destroy(ob, 20);
    }

    private void OnCollisionEnter2D(Collision2D col){
 
    }
}
