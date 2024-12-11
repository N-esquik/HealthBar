using UnityEngine;

[RequireComponent(typeof(HealthBarText))]
[RequireComponent(typeof(SliderHealthBar))]
[RequireComponent (typeof(HealthBarSliderSmooth))]

public class Health : MonoBehaviour
{
    private HealthBarText _healthBarText;
    private SliderHealthBar _sliderHealthBar;
    private HealthBarSliderSmooth _sliderSmooth;

    private float _healthPoint = 100f;
    private float _maxHealthPoint = 100f;

    public float HealthPoint => _healthPoint;
    public float MaxHealthPoint => _maxHealthPoint;

    public bool IsDead => _healthPoint <= 0;

    private void Awake()
    {
        _healthBarText = GetComponent<HealthBarText>();
        _sliderHealthBar = GetComponent<SliderHealthBar>();
        _sliderSmooth = GetComponent<HealthBarSliderSmooth>();
    }

    public void HealthRegen(float healthRegen)
    {
        if (_healthPoint > 0)
        {
            _healthPoint += healthRegen;
            _healthPoint = Mathf.Clamp(_healthPoint, 0f, _maxHealthPoint);
            ShowInfoHealthBar();
        }
    }

    public void TakeDamage(float damage)
    {
        _healthPoint -= damage;
        _healthPoint = Mathf.Clamp(_healthPoint, 0f, _maxHealthPoint);
        ShowInfoHealthBar();
    }

    private void ShowInfoHealthBar()
    {
        _healthBarText.ShowInfo();
        _sliderHealthBar.ShowInfo();
        _sliderSmooth.ShowInfo();
    }
}
