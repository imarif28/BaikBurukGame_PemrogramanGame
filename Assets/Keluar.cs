using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Keluar : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Data.score >= 300)
        {
            SceneManager.LoadScene("GameOver");
        }
        if (Data.score <= -10)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
       
    }
}
