using UnityEngine;

public class TestRank : MonoBehaviour
{
    public RankingManager rankingManager;
    public RankingUI rankingUI;

    void Start()
    {
        // サンプルデータを追加
        rankingManager.AddRankingEntry(5000000);
        rankingManager.AddRankingEntry(5000000);
        rankingManager.AddRankingEntry(5000000);


        // UIを更新して表示
        rankingUI.DisplayRanking();
    }
}