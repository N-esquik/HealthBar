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

    private void OnEnable()
    {
        _health.OnValueChanged += ShowInfo;
    }

    private void OnDisable()
    {
        _health.OnValueChanged -= ShowInfo;
    }

    private void ShowInfo(float currentHealth,float maxHealth)
    {
        _healthBar.maxValue = maxHealth;
        _healthBar.value = currentHealth;
    }
}
