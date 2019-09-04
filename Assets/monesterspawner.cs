using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class monesterspawner : MonoBehaviour
{
    [SerializeField] List<confi> config;
    List<GameObject> enemies;
    int wavenumber=0;
    void Start()
    {
        enemies = new List<GameObject>();
        var wave = config[wavenumber];
        StartCoroutine(spawnenemies(wave));
    }
    IEnumerator spawnenemies(confi wave)
    {
        for(int i=0; i < wave.Getenemycount(); i++)
        {
       GameObject enemy= Instantiate(
            wave.Getenemy(), 
            wave.Getmoves()[wavenumber].transform.position,
            Quaternion.identity
            );
        enemy.GetComponent<moveenemy>().setconfig(wave);

            enemies.Add(enemy);

        yield return new WaitForSeconds(wave.Gettimetowait());
        }
    }

    void Update()
    {
        for(int i=0; i < enemies.Count; i++)
        {
            if (enemies[i]==null)
            {
                enemies.RemoveAt(i);
            }
        }
        if (enemies.Count == 0)
        {

            if (config.Count-1 > wavenumber)
            {
            wavenumber = wavenumber + 1;
                
                var wave = config[wavenumber];
                StartCoroutine(spawnenemies(wave));
            }
            else
            {
                SceneManager.LoadScene("you won");
            }
        }
    }
}
