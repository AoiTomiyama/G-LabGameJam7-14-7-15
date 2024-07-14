using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RankingManager : MonoBehaviour
{
    private List<RankingEntry> rankingEntries;
    void Awake()
    {
        RankingLoad(); 
    }

    public void AddRankingEntry(float scorerank)
    {
        RankingEntry newEntry = new RankingEntry(scorerank);
        rankingEntries.Add(newEntry);
        SaveRanking();
    }

    public List<RankingEntry> GetRankingEntries()
    {
        rankingEntries.Sort((x, y) => y.scorerank.CompareTo(x.scorerank));
        return rankingEntries;
    }
    private void RankingLoad()
    {
        string json = PlayerPrefs.GetString("RankingData", "");
        if (!string.IsNullOrEmpty(json))
        {
            RankingList rankingList = JsonUtility.FromJson<RankingList>(json);
            rankingEntries = rankingList.rankingEntries;
        }
        else
        {
            rankingEntries = new List<RankingEntry>();
        }
    }
    private void SaveRanking()
    {
        rankingEntries.Sort((x, y) => y.scorerank.CompareTo(x.scorerank)); // スコアでソート
        RankingList rankingList = new RankingList { rankingEntries = rankingEntries };
        string json = JsonUtility.ToJson(rankingList);
        PlayerPrefs.SetString("RankingData", json);
        PlayerPrefs.Save();
    }

    [Serializable]
    private class RankingList
    {
        public List<RankingEntry> rankingEntries;
    }
}
