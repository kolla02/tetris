using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class recordsscript : MonoBehaviour
{

    public Text HighScore1;
    public Text HighScore2;
    public Text HighScore3;

    // Start is called before the first frame update
    void Start()
    {        
        HighScore1.text = "Рекорд №1: " + PlayerPrefs.GetInt("HighScore1").ToString();
        HighScore2.text = "Рекорд №2: " + PlayerPrefs.GetInt("HighScore2").ToString();
        HighScore3.text = "Рекорд №3: " + PlayerPrefs.GetInt("HighScore3").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
