using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class RankingUI : MonoBehaviour
{
    // Start is called before the first frame update
    public RankingManager rankingManager;
    public GameObject rankingEntryPrefab;
    public RectTransform rankingContainer;

    public int maxEntriesToShow = 10;

    void Start()
    {
        DisplayRanking();
    }

    public void DisplayRanking()
    {
        foreach (Transform child in rankingContainer)
        {
            Destroy(child.gameObject);
        }

        List<RankingEntry> rankingEntries = rankingManager.GetRankingEntries();
        for (int i = 0; i < maxEntriesToShow; i++)
        {
            GameObject entryObject = Instantiate(rankingEntryPrefab, rankingContainer);
            if (i < rankingEntries.Count)
            {
                RankingEntry entry = rankingEntries[i];
                entryObject.transform.Find("ScoreRanking").GetComponent<Text>().text = entry.scorerank.ToString();
            }
            else
            {
                entryObject.transform.Find("ScoreRanking").GetComponent<Text>().text = "";
            }
        }
    }
}