using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Text _text;
    private float _score = 70;
    public float GetScore { get => _score; }
    private void Start()
    {
        _text.text = $"{_score} ÉLÉç";
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
        _text.text = $"{_score} ÉLÉç";
    }
}
