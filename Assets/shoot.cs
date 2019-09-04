using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] float speed;
    Coroutine startfire;
    List<GameObject> bulletslist;
    
    float maxY;

    void Start()
    {
        Camera camera = Camera.main;
        bulletslist = new List<GameObject>();
        maxY = camera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;

    }


    IEnumerator startShooting()
    {
        while (true)
        {
        GameObject bullets = Instantiate(bullet, transform.position, Quaternion.identity);
        bullets.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);

            
            bulletslist.Add(bullets);

        yield return new WaitForSeconds(.2f);
        }

    }

    void Update()
    {
        for (int i = 0; i < bulletslist.Count; ++i)
        {
            if (bulletslist[i] == null)
            {
                continue;
            }
            if (bulletslist[i].transform.position.y > maxY)
            {
                Destroy(bulletslist[i]);
                bulletslist.RemoveAt(i);
            }
        }
        if (Input.GetButtonDown("Fire1"))
        {
           startfire= StartCoroutine(startShooting());
        }
        if (Input.GetButtonUp("Fire1"))
        {
            StopCoroutine(startfire);
        }
    }
}
