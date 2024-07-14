using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Text _text;
    public float _score = 70;

    private void Update()
    {
        if ( Input.GetKeyDown(KeyCode.S) )
        {
            _score += 10;
        }
        _text.text = _score + "ÉLÉç";
    }

}
