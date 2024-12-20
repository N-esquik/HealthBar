using TMPro;
using UnityEngine;

[RequireComponent(typeof(Health))]

public class HealthBarText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textMeshProUGUI;

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

    private void ShowInfo(float currentHealth, float maxHealth)
    {
        _textMeshProUGUI.text = $"{currentHealth}/{maxHealth}";
    }
}