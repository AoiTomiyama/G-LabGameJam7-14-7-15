using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [Header("�~�炷�H�ނ̃��X�g")]
    [SerializeField]
    private GameObject[] _ingredientsArray;
    public GameObject[] IngredientsArray { get => _ingredientsArray; }

    [Header("�~���Ă���C���^�[�o���̎���")]
    [Header("�Œ�l")]
    [SerializeField]
    private float _intervalTimeMin;
    [Header("�ő�l")]
    [SerializeField]
    private float _intervalTimeMax;
    private float _currentInterval;
    private float _timer;
    [Header("�~�炷���x")]
    [SerializeField]
    private float _fallSpeed;
    private float _colliderX;
    private void Start()
    {
        _colliderX = GetComponent<BoxCollider2D>().size.x;
        _currentInterval = Random.Range(_intervalTimeMin, _intervalTimeMax);
    }
    void Update()
    {
        if (_timer > _currentInterval)
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
        _currentInterval = Random.Range(_intervalTimeMin, _intervalTimeMax);
    }
}
