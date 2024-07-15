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
            _name = "�\��";
            text.text = _name;
            _class = 1;
        }
        if (score.GetScore >= _state2)
        {
            _name = "�O��";
            text.text = _name;
        }
        if (score.GetScore >= _state3)
        {
            _name = "����";
            text.text = _name;
            _class = 2;
        }
        if (score.GetScore >= _state4)
        {
            _name = "�֘e";
            text.text = _name;
        }
        if (score.GetScore >= _state5)
        {
            _name = "���";
            text.text = _name;
        }
        if (score.GetScore >= _state6)
        {
            _name = "���j";
            text.text = _name;
            _class = 3;
        }
    }
    private void OnDisable()
    {
        PlayerPrefs.SetString("�֘e", _name);
        PlayerPrefs.Save();
    }
}
