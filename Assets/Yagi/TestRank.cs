using UnityEngine;

public class TestRank : MonoBehaviour
{
    public RankingManager rankingManager;
    public RankingUI rankingUI;

    void Start()
    {
        // �T���v���f�[�^��ǉ�
        rankingManager.AddRankingEntry(5000000);
        rankingManager.AddRankingEntry(5000000);
        rankingManager.AddRankingEntry(5000000);


        // UI���X�V���ĕ\��
        rankingUI.DisplayRanking();
    }
}