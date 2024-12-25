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

    private void OnEnable()
    {
        _health.OnValueChanged += ShowInfo;
    }

    private void OnDisable()
    {
        _health.OnValueChanged -= ShowInfo;
    }

    private void ShowInfo(float currentHealth, float maxHealth)
    {
        _textMeshProUGUI.text = $"{currentHealth}/{maxHealth}";
    }
}