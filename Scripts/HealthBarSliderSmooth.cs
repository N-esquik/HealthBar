using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Health))]

public class HealthBarSliderSmooth : MonoBehaviour
{
    [SerializeField] private Slider _healthBar;

    private Health _health;
    private Coroutine _coroutine;
    private WaitForSecondsRealtime _wait;

    private float _interval = 0.0001f; 
    private float _speedMoveSlider = 50f;

    private void Awake()
    {
        _health = GetComponent<Health>();
        _healthBar.maxValue = _health.MaxHealthPoint;
        _healthBar.value = _health.HealthPoint;
    }

    public void ShowInfo()
    {
        StopPreviousCoruotine();
        _coroutine = StartCoroutine(MoveHealthBar());
    }

    private IEnumerator MoveHealthBar()
    {
        _wait = new WaitForSecondsRealtime(_interval);

        while (_health.HealthPoint != _healthBar.value)
        {
            _healthBar.value = Mathf.MoveTowards(_healthBar.value, _health.HealthPoint, _speedMoveSlider * Time.deltaTime);
            yield return _wait;
        }
    }

    private void StopPreviousCoruotine()
    {
        if(_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }
    }
}
