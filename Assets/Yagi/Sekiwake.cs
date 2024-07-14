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
            text.text = "è\óº";
        }
        if (score._score > _state2)
        {
            text.text = "ëOì™";
        }
        if (score._score > _state3)
        {
            text.text = "è¨åã";
        }
        if (score._score > _state4)
        {
            text.text = "ä÷òe";
        }
        if (score._score > _state5)
        {
            text.text = "ëÂä÷";
        }
        if (score._score > _state6)
        {
            text.text = "â°çj";
        }
    }
}
