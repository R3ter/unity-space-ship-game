using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemybullet : MonoBehaviour
{
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, -5);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene("Gameover");
        }
    }
}
