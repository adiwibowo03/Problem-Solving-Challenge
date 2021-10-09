using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnP8 : MonoBehaviour
{
    public GameObject obj;
    //RadiusSpawn
    public float radius;
    //RandomPosition
    private float randomPositionX;
    private float randomPositionY;

    // Start is called before the first frame update
    void Start()
    {
      InvokeRepeating("SpawnObject", 0f, 3f);
      
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
