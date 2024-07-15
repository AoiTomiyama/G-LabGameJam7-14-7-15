using UnityEngine;

public class NabebutaController : MonoBehaviour
{
    SpriteRenderer _sr;
    Collider2D _collider;
    private void Start()
    {
        _sr = GetComponent<SpriteRenderer>();
        _collider = GetComponent<Collider2D>();
        _sr.enabled = _collider.enabled = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyUp(KeyCode.Space))
        {
            _sr.enabled = _collider.enabled = !_sr.enabled;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<IngredientsFall>(out _))
        {
            Destroy(collision.gameObject);
        }
    }
}
