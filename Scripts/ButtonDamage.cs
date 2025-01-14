using UnityEngine;
using UnityEngine.UI;

public class ButtonDamage : ButtonInit
{
    [SerializeField] private Health _health;

    private float _damage = 20f;

    protected override void OnButtonClick()
    {
        _health.TakeDamage(_damage);
    }
}
