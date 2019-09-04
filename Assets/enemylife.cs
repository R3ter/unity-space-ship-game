using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemylife : MonoBehaviour
{
    [SerializeField] public int life ;
    [SerializeField] GameObject explode;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "bullet")
        {
            Destroy(collision.gameObject);
            StartCoroutine(getshot());

        }

    }
    IEnumerator getshot()
    {
        life = life - 3;
        
        yield return new WaitForSeconds(.2f);
    }
        private void Update()
    {
        if (life<=0)
        {
            Destroy(gameObject);
            Instantiate(explode, transform.position, Quaternion.identity);
        }
    }
}
