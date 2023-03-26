using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Meteor : MonoBehaviour
{
    public float speed;

    public GameObject meteorPrefab;

    public AudioSource meteorExplosion;

    public int meteors;


    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            meteorExplosion.Play();

            gameObject.transform.position = new Vector3(0, 0, 0);
            for (int i = 0; i < meteors; i++)
            {
                Instantiate(meteorPrefab, transform.position, Quaternion.identity);
            }
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(1);
        }

    }
}
