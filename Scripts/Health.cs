using System;
using UnityEngine;

[RequireComponent(typeof(HealthBarText))]
[RequireComponent(typeof(SliderHealthBar))]
[RequireComponent(typeof(HealthBarSliderSmooth))]

public class Health : MonoBehaviour
{
    private float _currentHealth = 100f;
    private float _maxHealth = 100f;

    public float CurrentHealth => _currentHealth;
    public float MaxHealth => _maxHealth;

    public bool IsDead => _currentHealth <= 0;

    public Action<float, float> OnHealthChanged;

    public void TakeHeal(float amountHeal)
    {
        if (IsDead) return;

        _currentHealth += amountHeal;
        _currentHealth = Mathf.Clamp(_currentHealth, 0f, _maxHealth);
        NotifyHealthChanged();
    }

    public void TakeDamage(float damage)
    {
        if (IsDead) return;

        _currentHealth -= damage;
        _currentHealth = Mathf.Clamp(_currentHealth, 0f, _maxHealth);
        NotifyHealthChanged();
    }

    private void NotifyHealthChanged()
    {
        OnHealthChanged?.Invoke(_currentHealth, _maxHealth);
    }
}
