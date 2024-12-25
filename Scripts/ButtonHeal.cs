using UnityEngine;
using UnityEngine.UI;

public class ButtonHeal : ButtonInit
{
    [SerializeField] private Health _health;

    private float _healthRegen = 20f;

    protected override void OnButtonClick()
    {
        _health.TakeHeal(_healthRegen);
    }
}
