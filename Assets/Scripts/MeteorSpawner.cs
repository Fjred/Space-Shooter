using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject prefab;


    public float nextSpawnTime;
    public float spawnInterval;

    private void Start()
    {
        nextSpawnTime = Time.time;
    }

    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            Spawn();
            nextSpawnTime += spawnInterval;
        }

    }

    void Spawn()
    {
        var pos = transform.position;
        pos.z = Random.Range(-14f, -6f);
        pos.x = Random.Range(5f, 6f);
        var rot = Quaternion.identity;

        Instantiate(prefab, pos, rot);


    }
}
