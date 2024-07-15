using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    [SerializeField] RankingManager rankingManager;
    [SerializeField] Text _scoretext;
    [SerializeField] Text _banduke;
    [SerializeField] Sprite[] _rikisi;
    [SerializeField] Sprite[] classbackground;
    [SerializeField] Image _rikisiImage;
    [SerializeField] Image back;
    int _rikisistate;
    
    void Start()
    {
        _rikisistate = PlayerPrefs.GetInt("class");
        _scoretext.text = $"{PlayerPrefs.GetFloat("score")}";
        _banduke.text = $"{PlayerPrefs.GetString("ŠÖ˜e")}";
        rankingManager.AddRankingEntry(PlayerPrefs.GetFloat("score"));
        if (_rikisistate == 1) 
        {
            _rikisiImage.sprite = _rikisi[0];
            back.sprite = classbackground[0];
        }
        if (_rikisistate == 2) 
        {
            _rikisiImage.sprite = _rikisi[1];
            back.sprite = classbackground[1];
        }
        if (_rikisistate == 3) 
        {
            _rikisiImage.sprite = _rikisi[2];
            back.sprite = classbackground[2];
        }

    }

   
}
