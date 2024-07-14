using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class RecipeGenerator : MonoBehaviour
{
    [Header("レシピの具材が重複するかどうか")]
    [SerializeField]
    bool _enableDuplicate;
    [Header("RecipeImageのPrefabを入れる")]
    [SerializeField]
    GameObject _recipeImage;
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
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            foreach (var go in _recipe)
            {
                Destroy(go, Time.deltaTime);
            }
            RegenerateRecipe();
        }
    }
    void RegenerateRecipe()
    {

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
        var line = "";
        foreach (var s in _recipe)
        {
            line += s.name + ", ";
        }
        Debug.Log(line);
    }
    private void OnTriggerEnter2D(Collider2D collision)
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
        }
        isContains = false;
        Destroy(collision.gameObject);
        if (_recipe.Count == 0)
        {
            Debug.Log("Score gain");
            RegenerateRecipe();
        }
    }
}
