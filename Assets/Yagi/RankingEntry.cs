using System.Collections;
using System;

[Serializable]
public class RankingEntry
{
    public float scorerank;
    // Start is called before the first frame update
    public RankingEntry(float scoreRank)
    {
        this.scorerank = scoreRank;
    }
}
