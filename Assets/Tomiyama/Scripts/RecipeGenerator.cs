using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeGenerator : MonoBehaviour
{
    [Header("���V�s�̋�ނ��d�����邩�ǂ���")]
    [SerializeField]
    bool _enableDuplicate;
    [Header("RecipeImage��Prefab������")]
    [SerializeField]
    GameObject _recipeImage;
    [Header("���s�����Ƃ��Ɍ��炷�b��")]
    [SerializeField]
    float _removeSecond;
    [Header("���������Ƃ��ɑ��₷�d��")]
    [SerializeField]
    float _addScore;
    [Header("�������̃G�t�F�N�g")]
    [SerializeField]
    GameObject _successEffect;
    [Header("���s���̃G�t�F�N�g")]
    [SerializeField]
    GameObject _mistakeEffect;
    List<Sprite> _ingredients = new List<Sprite>();
    List<GameObject> _recipe = new List<GameObject>();
    private void Start()
    {
        foreach (var item in FindObjectOfType<Generator>().GetComponent<Generator>().IngredientsArray)
        {
            _ingredients.Add(item.GetComponent<SpriteRenderer>().sprite);
        }
        RegenerateRecipe();
    }
    void RegenerateRecipe()
    {
        AudioManager.Instance.RunSE(AudioManager.SE.Change);
        if (_recipe.Count > 0)
        {
            foreach (var go in _recipe)
            {
                Destroy(go);
            }
        }
        _recipe.Clear();
        if (_enableDuplicate)
        {
            while (_recipe.Count < 3)
            {
                var go = Instantiate(_recipeImage, FindObjectOfType<HorizontalLayoutGroup>().transform);
                go.GetComponent<Image>().sprite = _ingredients[Random.Range(0, _ingredients.Count)];
                _recipe.Add(go);
            }
        }
        else
        {
            var spriteList = new List<Sprite>();
            var currentRecipe = new List<GameObject>();
            while (currentRecipe.Count < 3)
            {
                int r = Random.Range(0, _ingredients.Count);
                var spr = _ingredients[r];
                if (!spriteList.Contains(spr))
                {
                    var go = Instantiate(_recipeImage, FindObjectOfType<HorizontalLayoutGroup>().transform);
                    go.GetComponent<Image>().sprite = spr;
                    currentRecipe.Add(go);
                    spriteList.Add(spr);
                }
            }
            _recipe = currentRecipe;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (LayerMask.LayerToName(collision.gameObject.layer) == "Vegetable")
        {
            var spr = collision.gameObject.GetComponent<SpriteRenderer>().sprite;
            bool isContains = false;
            foreach (var go in _recipe)
            {
                if (go.GetComponent<Image>().sprite == spr)
                {
                    _recipe.Remove(go);
                    Destroy(go);
                    isContains = true;
                    break;
                }
            }
            if (!isContains)
            {
                Debug.Log("Reduce Time");
                Instantiate(_mistakeEffect, transform.position, Quaternion.identity, transform);
                FindObjectOfType<Timer>().GetComponent<Timer>().RemoveTime(_removeSecond);
                AudioManager.Instance.RunSE(AudioManager.SE.Misstake);
                RegenerateRecipe();
            }
            isContains = false;
            Destroy(collision.gameObject);
            if (_recipe.Count == 0)
            {
                Debug.Log("Score gain");
                Instantiate(_successEffect, transform.position, Quaternion.identity, transform);
                FindObjectOfType<Score>().GetComponent<Score>().AddScore(_addScore); 
                AudioManager.Instance.RunSE(AudioManager.SE.Completion);
                RegenerateRecipe();
            }
        }
    }
}
