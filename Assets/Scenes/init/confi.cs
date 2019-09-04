using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="enemy config")]
public class confi : ScriptableObject
{
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject paths;

    [SerializeField] int enemyspeed=1;
    [SerializeField] float timetowait=1;
    [SerializeField] int enemycount = 1;
    [SerializeField] int life = 10;

    public GameObject Getenemy() { return enemy; }
    public List<Transform> Getmoves() {
        var points = new List<Transform>();
        foreach(Transform point in paths.transform)
        {
            points.Add(point);
        }
        return points;
    }
    public int Getenemyspeed() { return enemyspeed; }
    public int getlife() { return life; }
    public float Gettimetowait() { return timetowait; }
    public int Getenemycount() { return enemycount; }



}
