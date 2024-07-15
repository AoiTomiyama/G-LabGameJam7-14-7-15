using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private GameObject _ruleUI;
    [SerializeField] private GameObject _returnUI;
    [SerializeField]private GameObject _actionUI;
    AudioSource _audiosourse;
    // Start is called before the first frame update
    void Start()
    {
        
       
    }

    public void push()
    {
        AudioManager.Instance.RunSE(AudioManager.SE.Click);
        SceneManager.LoadScene("GameScene");
    }
    public void OnRoadRankingScene()
    {
        AudioManager.Instance.RunSE(AudioManager.SE.Click);
        SceneManager.LoadScene("RankingScene");
    }
    public void OnRoadTitleScene()
    {
        AudioManager.Instance.RunSE(AudioManager.SE.Click); 
        SceneManager.LoadScene("TitleScene");
    }
    public void OnClickRuleActive()
    {
        AudioManager.Instance.RunSE(AudioManager.SE.Click);
        _ruleUI.SetActive(true);
        _returnUI.SetActive(true);
        _actionUI.SetActive(false);
    }
    public void OnClickReturn()
    {
        AudioManager.Instance.RunSE(AudioManager.SE.Click); 
        _ruleUI.SetActive(false);
        _returnUI.SetActive(false);
        _actionUI.SetActive(true);
    }
   

}
