using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    [SerializeField] RankingManager rankingManager;
    [SerializeField] Text _scoretext;
    [SerializeField] Text _banduke;
    void Start()
    {
        _scoretext.text = $"�̏d{PlayerPrefs.GetFloat("score")}�L��";
        _banduke.text = $"�ԕt : {PlayerPrefs.GetString("�֘e")}";
        rankingManager.AddRankingEntry(PlayerPrefs.GetFloat("score"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
