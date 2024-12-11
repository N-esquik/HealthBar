using UnityEngine;
using UnityEngine.UI;

public class ButtonDamage : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private Health _health;

    private float _damage = 20f;

    private void OnEnable()
    {
        _button.onClick.AddListener(Damage);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(Damage);
    }

    private void Damage()
    {
        _health.TakeDamage(_damage);
    }
}
