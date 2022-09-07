using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
     
    }
     
     private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "GameOver")
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
