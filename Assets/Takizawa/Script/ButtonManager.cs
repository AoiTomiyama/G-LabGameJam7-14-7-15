using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private GameObject _ruleUI;
    [SerializeField] private GameObject _returnUI;
    AudioSource _audiosourse;
    // Start is called before the first frame update
    void Start()
    {
       // this.GetComponent<Button>().onClick.AddListener(push);
       
    }

    public void push()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void OnRoadRankingScene()
    {
        SceneManager.LoadScene("RankingScene");
    }
    public void OnRoadTitleScene()
    {
        SceneManager.LoadScene("TitleScene");
    }
    public void OnClickRuleActive()
    {
        _ruleUI.SetActive(true);
        _returnUI.SetActive(true);
    }
    public void OnClickReturn()
    {
        _ruleUI.SetActive(false);
        _returnUI.SetActive(false);
    }
   

}
