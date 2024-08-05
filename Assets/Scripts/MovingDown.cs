using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingDown : MonoBehaviour
{
    public static float speed;
    public bool isMoving = true;


    void Start()
    {
     
    }
    
    void Update()
    {
        if(isMoving)
        this.transform.position += new Vector3(0, speed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "DeathZone")
        {
            GetComponent<ClikingBugs>().CheckOnDeathZone();
        }
    }
    
}
