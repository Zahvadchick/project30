using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : Unit
{
    public override void Die()
    {
        Destroy(gameObject);
    }
    public override void Damage()
    {
        Die();
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Unit unit = collider.GetComponent<Unit>();
        if (unit && unit is men)
        {
            unit.Damage();
        }

    }
    void CheckGround()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 0.32F);
        if (colliders.Length > 1)
            Damage();

    }
    private void Update()
    {
        CheckGround();
    }
}
