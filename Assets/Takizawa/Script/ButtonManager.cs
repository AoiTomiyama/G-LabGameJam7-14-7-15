using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private GameObject _ruleUI;
    [SerializeField] private GameObject _returnUI;
    [SerializeField] private GameObject _actionUI;
    [SerializeField] private GameObject _startUI;
    [SerializeField] private GameObject _credit;
    [SerializeField] private GameObject _creditClose;
    [SerializeField] private GameObject _creditButton;

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
        _startUI.SetActive(false);
        _creditButton.SetActive(false);
    }
    public void OnClickReturn()
    {
        AudioManager.Instance.RunSE(AudioManager.SE.Click);
        _ruleUI.SetActive(false);
        _returnUI.SetActive(false);
        _actionUI.SetActive(true);
        _startUI.SetActive(true);
        _creditButton.SetActive(true);
    }
    public void ShowCredit()
    {
        AudioManager.Instance.RunSE(AudioManager.SE.Click);
        _credit.SetActive(true);
        _creditClose.SetActive(true);
        _actionUI.SetActive(false);
        _startUI.SetActive(false);
        _creditButton.SetActive(false);
    }
    public void HideCredit()
    {
        AudioManager.Instance.RunSE(AudioManager.SE.Click);
        _credit.SetActive(false);
        _creditClose.SetActive(false);
        _actionUI.SetActive(true);
        _startUI.SetActive(true);
        _creditButton.SetActive(true);
    }
}
