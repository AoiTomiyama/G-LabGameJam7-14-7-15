using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] Text _text;
    [SerializeField] float _time = 60;

    void Update()
    {
        _time -= Time.deltaTime;
        _text.text = _time.ToString("F0") + "•b";
        if (_time <= 0)
        {
            SceneManager.LoadScene("ResultScene");
        }
    }

    public void RemoveTime(float time)
    {
        _time -= time;
    }
}
