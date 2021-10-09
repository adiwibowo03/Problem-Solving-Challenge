using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpike : MonoBehaviour
{
    public GameObject spike;
    public float waktuMinimal, waktuMaximal;
    public float posminimal, posmaximal;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MunculSpike());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator MunculSpike()
    {
        Instantiate(spike, transform.position + Vector3.right * Random.Range(posminimal, posmaximal), Quaternion.identity);
        yield return new WaitForSeconds(Random.Range(waktuMinimal, waktuMaximal));
        StartCoroutine(MunculSpike());
    }
}
