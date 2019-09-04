using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    float movespeed = 10f;

    float maxX;
    float minX;
    float maxY;
    float minY;
    void Start()
    {
        Camera camera = Camera.main;
        maxX = camera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;
        minX = camera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;

        minY = camera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y;
        maxY = camera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;


    }


    void Update()
    {
     
        var movex = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;
       
        transform.position =new Vector2(
            Mathf.Clamp(transform.position.x+movex, minX, maxX)
            , transform.position.y);
            
        var movey = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;
        transform.position = new Vector2(transform.position.x, 
            Mathf.Clamp(transform.position.y + movey, minY, maxY));

    }
}
