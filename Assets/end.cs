using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class end : MonoBehaviour
{
    /// <summary>
    /// クリア画面に移動するすくりぷと
    /// </summary>
    GameObject timerText;
    float time = 60.0f;
    float startTime;



    // Start is called before the first frame update
    void Start()
    {
        ///文字表示
        this.timerText = GameObject.Find("Time");
        startTime = Time.time;
    }



    // Update is called once per frame
    void Update()
    {
        ///制限時間
        this.time -= Time.deltaTime;
        this.timerText.GetComponent<Text>().text = time.ToString("F1");
        if (Time.time - startTime > 60.0f)
        {
            SceneManager.LoadScene("ggame");
        }
    }
    
}
