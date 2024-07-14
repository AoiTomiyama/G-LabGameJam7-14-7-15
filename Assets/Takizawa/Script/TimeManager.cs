using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [SerializeField] public float Timer = 60;
    public Text TimerText;
    public Text TitleText;
    public GameObject RankingWindow;

    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        TimerText.text = ((int)Timer).ToString();

        if (Timer <= 0)
        {

            enabled = false;
            this.Timer = 0;
            SceneManager.LoadScene("ResultScene");

        }
    }
}
