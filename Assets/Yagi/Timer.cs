using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] Text _text;
    [SerializeField] float _time = 60;

    bool _isPlaying = false;

    float _audioTimer = 0;
    void Update()
    {
        _time -= Time.deltaTime;
        _text.text = _time.ToString("F0") + "•b";
        if (_time <= 0)
        {
            AudioManager.Instance.StopSE();
            AudioManager.Instance.RunSE(AudioManager.SE.GameClear);
            SceneManager.LoadScene("ResultScene");
        }
        if ( _time <= 11.6f)
        {
            SE();
        }
    }

    public void RemoveTime(float time)
    {
        _time -= time;
    }
    public void SE()
    {
        _audioTimer += Time.deltaTime;

        if(_audioTimer >= 1.6f)
        {
            AudioManager.Instance.RunSE(AudioManager.SE.Timer);
            _audioTimer = 0;
        }
    }
}
