using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyshoot : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] float speed;
    Coroutine startfire;
    List<GameObject> bulletslist;

    float minY;

    void Start()
    {
        Camera camera = Camera.main;
        bulletslist = new List<GameObject>();
        minY = camera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y;

    }


    IEnumerator startShooting()
    {
        
            GameObject bullets = Instantiate(bullet, transform.position, Quaternion.identity);
            bullets.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);


            bulletslist.Add(bullets);

            yield return new WaitForSeconds(.2f);
       

    }
    int x;
    void Update()
    {
        x++;
        for (int i = 0; i < bulletslist.Count; ++i)
        {
            if (bulletslist[i] == null)
            {
                continue;
            }
            if (bulletslist[i].transform.position.y < minY)
            {
                Destroy(bulletslist[i]);
                bulletslist.RemoveAt(i);
            }
        }
        if (x > 200)
        {
            x = 0;
            startfire = StartCoroutine(startShooting());
        }
       
    }
}
