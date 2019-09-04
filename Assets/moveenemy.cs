using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveenemy : MonoBehaviour
{
    List<Transform> paths;
    confi config;

    int pathnumber = 0;

    public void setconfig(confi config)
    {
        this.config = config;
    }

    void Start()
    {
        paths = config.Getmoves();
        transform.position = paths[0].position;
    }

    void Update()
    {


        if (transform.position.x == paths[pathnumber].position.x && transform.position.y == paths[pathnumber].position.y)
        {
            if (pathnumber + 1 < paths.Count)
                pathnumber = pathnumber + 1;
            else
                pathnumber = 0;
        }

        transform.position =  Vector2.MoveTowards(transform.position, paths[pathnumber].position,Time.deltaTime*2);

    }
}
