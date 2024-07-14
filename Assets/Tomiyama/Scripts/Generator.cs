using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [Header("降らす食材のリスト")]
    [SerializeField]
    private GameObject[] _ingredientsArray;

    [Header("降ってくるインターバルの時間")]
    [SerializeField]
    private float _intervalTime;
    private float _timer;
    [Header("降らす速度")]
    [SerializeField]
    private float _fallSpeed;
    private float _colliderX;
    private void Start()
    {
        _colliderX = GetComponent<BoxCollider2D>().size.x;
    }
    void Update()
    {
        if (_timer > _intervalTime)
        {
            Generate();
            _timer = 0;
        }
        else
        {
            _timer += Time.deltaTime;
        }
    }
    void Generate()
    {
        float randomX = Random.Range(this.transform.position.x - _colliderX / 2, this.transform.position.x + _colliderX / 2);
        var scr = Instantiate(_ingredientsArray[Random.Range(0, _ingredientsArray.Length)], new Vector2(randomX, this.transform.position.y), Quaternion.identity).GetComponent<IngredientsFall>();
        scr.Speed = _fallSpeed;
    }
}
