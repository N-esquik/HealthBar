using UnityEngine;

public abstract class HealthBarInit : MonoBehaviour
{
    private Health _health;

    private void Awake()
    {
        _health = GetComponent<Health>();
    }

    private void OnEnable()
    {
        _health.ValueChang += ShowInfo;
    }

    private void OnDisable()
    {
        _health.ValueChang -= ShowInfo;
    }

    protected abstract void ShowInfo(float currentHealth, float maxHealth);
}
