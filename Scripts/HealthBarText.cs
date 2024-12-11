using TMPro;
using UnityEngine;

public class HealthBarText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textMeshProUGUI;

    private Health _health;

    private void Awake()
    {
        _health = GetComponent<Health>();
    }

    public void ShowInfo()
    {
        _textMeshProUGUI.text = $"{_health.HealthPoint}/{_health.MaxHealthPoint}";
    }
}