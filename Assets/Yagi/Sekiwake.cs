using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sekiwake : MonoBehaviour
{
    [SerializeField] Text text;
     Score score;
    [SerializeField] int _state1;
    [SerializeField] int _state2;
    [SerializeField] int _state3;
    [SerializeField] int _state4;
    [SerializeField] int _state5;
    [SerializeField] int _state6;

    private void Start()
    {
        score = GetComponent<Score>();
        
    }
    void Update()
    {
        
        if (score._score > _state1)
        {
            text.text = "�\��";
        }
        if (score._score > _state2)
        {
            text.text = "�O��";
        }
        if (score._score > _state3)
        {
            text.text = "����";
        }
        if (score._score > _state4)
        {
            text.text = "�֘e";
        }
        if (score._score > _state5)
        {
            text.text = "���";
        }
        if (score._score > _state6)
        {
            text.text = "���j";
        }
    }
}
