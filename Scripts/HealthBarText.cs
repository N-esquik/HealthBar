using TMPro;
using UnityEngine;

public class HealthBarText : HealthBarInit
{
    [SerializeField] private TextMeshProUGUI _textMeshProUGUI;

    protected override void ShowInfo(float currentHealth, float maxHealth)
    {
        _textMeshProUGUI.text = $"{currentHealth}/{maxHealth}";
    }
}