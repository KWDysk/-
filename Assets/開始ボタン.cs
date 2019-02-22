using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class 開始ボタン : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void GameStart()
    {
        GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("game");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
