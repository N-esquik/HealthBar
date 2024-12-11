using UnityEngine;
using UnityEngine.UI;

public class ButtonHealth : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private Health _health;

    private float _healthRegen = 20f;

    private void OnEnable()
    {
        _button.onClick.AddListener(Health);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(Health);
    }

    private void Health()
    {
        _health.HealthRegen(_healthRegen);
    }
}
