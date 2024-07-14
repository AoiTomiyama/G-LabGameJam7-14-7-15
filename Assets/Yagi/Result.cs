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
        _scoretext.text = $"ëÃèd{PlayerPrefs.GetFloat("score")}ÉLÉç";
        _banduke.text = $"î‘ït : {PlayerPrefs.GetString("ä÷òe")}";
        rankingManager.AddRankingEntry(PlayerPrefs.GetFloat("score"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
