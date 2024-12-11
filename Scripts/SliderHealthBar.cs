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
        _healthBar.maxValue = _health.MaxHealthPoint;
        _healthBar.value = _health.HealthPoint;
    }

    public void ShowInfo()
    {
        _healthBar.value = _health.HealthPoint;
    }
}
