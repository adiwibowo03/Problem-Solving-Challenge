using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject obj;
    public float radius;
    public float randomPositionX;
    public float randomPositionY;
    // Start is called before the first frame update
    void Start()
    {
        int ran = Random.Range(2, 10);
        for(int i = 0; i < ran; i++)
        {
        randomPositionX = Random.Range(-8f, 8f);
        randomPositionY = Random.Range(-4f, 4f);
        transform.position = new Vector2(randomPositionX, randomPositionY);
        Instantiate(obj, transform.position, Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObject(){
        randomPositionX = Random.Range(-8f, 8f);
        randomPositionY = Random.Range(-4f, 4f);
        transform.position = new Vector2(randomPositionX, randomPositionY);
        Instantiate(obj, transform.position, Quaternion.identity);
    }
}
