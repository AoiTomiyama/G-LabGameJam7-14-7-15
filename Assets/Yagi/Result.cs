using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    [SerializeField] Text _scoretext;
    [SerializeField] Text _banduke;
    void Start()
    {
        _scoretext.text = $"体重{PlayerPrefs.GetFloat("score")}キロ";
        _banduke.text = $"番付 : {PlayerPrefs.GetString("関脇")}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
