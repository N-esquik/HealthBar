using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Health))]

public class SliderHealthBar : MonoBehaviour
{
    [SerializeField] private Slider _healthBar;

    private Health _health;

    private void Awake()
    {
        _health = GetComponent<Health>();
    }

    private void Start()
    {
        _health.OnHealthChanged += ShowInfo;
    }

    private void OnDestroy()
    {
        if (_health != null)
            _health.OnHealthChanged -= ShowInfo;
    }

    private void ShowInfo(float currentHealth,float maxHealth)
    {
        _healthBar.maxValue = maxHealth;
        _healthBar.value = currentHealth;
    }
}
