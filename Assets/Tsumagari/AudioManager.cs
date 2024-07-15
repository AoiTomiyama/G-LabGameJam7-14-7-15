using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager _instance;
    public static AudioManager Instance => _instance;

    [SerializeField] private AudioClip[] _sounds = default;

    private Dictionary<SE, AudioClip> _seDic;

    private AudioSource _audioSource;

    private void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
   private void Start()
    {
        _audioSource = GetComponent<AudioSource>();

        _seDic.Add(SE.Footstep, _sounds[0]);
        _seDic.Add(SE.FallVegetable, _sounds[1]);
        _seDic.Add(SE.Completion, _sounds[2]);
        _seDic.Add(SE.Misstake, _sounds[3]);
        _seDic.Add(SE.Change, _sounds[4]);
        _seDic.Add(SE.GameOver, _sounds[5]);
        _seDic.Add(SE.GameClear, _sounds[6]);
        _seDic.Add(SE.Timer, _sounds[7]);
        _seDic.Add(SE.LevelUp, _sounds[8]);
        _seDic.Add(SE.Click, _sounds[9]);

    }



    public void RunSE(SE se)
    {
        _audioSource.PlayOneShot(_seDic[se]);
    }
    public enum SE
    {
        None ,
        Footstep,
        FallVegetable,
        Completion,
        Misstake,
        Change,
        GameOver,
        GameClear,
        Timer,
        LevelUp,
        Click,
    }
}