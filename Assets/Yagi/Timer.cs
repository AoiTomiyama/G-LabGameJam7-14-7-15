using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] Text _text;
    [SerializeField] float _time = 60;
    
    void Update()
    {
        _time -= Time.deltaTime;
        _text.text = _time.ToString("F0") + "•b";
        if ( _time <= 0 )
        {
            SceneManager.LoadScene("ResultScene");
        }
    }
    
}
