using UnityEngine;
using UnityEngine.UI;

public class SliderHealthBar : HealthBarInit
{
    [SerializeField] private Slider _healthBar;

    protected override void ShowInfo(float currentHealth,float maxHealth)
    {
        _healthBar.maxValue = maxHealth;
        _healthBar.value = currentHealth;
    }
}
