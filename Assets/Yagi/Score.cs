using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Text _text;
    [Header("開始時のスコア")]
    [SerializeField]
    private float _score = 70;
    public float GetScore { get => _score; }
    private void Start()
    {
        _text.text = $"{_score}kg";
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            _score += 10;
        }
    }

    public void AddScore(float score)
    {
        _score += score;
        _text.text = $"{_score}kg";
    }

    private void OnDisable()
    {
        PlayerPrefs.SetFloat("score", _score);
        PlayerPrefs.Save();
    }
}
