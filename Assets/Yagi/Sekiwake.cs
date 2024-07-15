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
    public int _class;
    string _name;

    private void Start()
    {
        score = GetComponent<Score>();
        
    }
    void Update()
    {
        
        if (score.GetScore >= _state1)
        {
            _name = "è\óº";
            text.text = _name;
            _class = 1;
        }
        if (score.GetScore >= _state2)
        {
            _name = "ëOì™";
            text.text = _name;
        }
        if (score.GetScore >= _state3)
        {
            _name = "è¨åã";
            text.text = _name;
            _class = 2;
        }
        if (score.GetScore >= _state4)
        {
            _name = "ä÷òe";
            text.text = _name;
        }
        if (score.GetScore >= _state5)
        {
            _name = "ëÂä÷";
            text.text = _name;
        }
        if (score.GetScore >= _state6)
        {
            _name = "â°çj";
            text.text = _name;
            _class = 3;
        }
    }
    private void OnDisable()
    {
        PlayerPrefs.SetString("ä÷òe", _name);
        PlayerPrefs.Save();
    }
}
