using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarSliderSmooth : HealthBarInit
{
    [SerializeField] private Slider _healthBar;

    private Coroutine _coroutine;
    private WaitForSecondsRealtime _wait;

    private float _interval = 0.0001f; 
    private float _speedMoveSlider = 50f;

    protected override void ShowInfo(float currentHealth, float maxHealth)
    {
        StopPreviousCoruotine();
        _coroutine = StartCoroutine(MoveHealthBar(currentHealth, maxHealth));
    }

    private IEnumerator MoveHealthBar(float currentHealth,float maxHealth)
    {
        _healthBar.maxValue = maxHealth;
        _wait = new WaitForSecondsRealtime(_interval);

        while (currentHealth != _healthBar.value)
        {
            _healthBar.value = Mathf.MoveTowards(_healthBar.value, currentHealth, _speedMoveSlider * Time.deltaTime);
            yield return _wait;
        }
    }

    private void StopPreviousCoruotine()
    {
        if (_coroutine != null)
            StopCoroutine(_coroutine);
    }
}
