using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePoin : MonoBehaviour
{
    public float score;
    public Text scoreUI;
    public Text scoreCurent;
    public GameObject lose;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)){
         Application.LoadLevel(0);
         Time.timeScale = 1;
         }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("box"))
        {
            score += 1;
            scoreUI.text = score.ToString();
            scoreCurent.text = score.ToString();
            Destroy(collision.gameObject);
        }
        else if (collision.CompareTag("spike"))
        {
            lose.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
