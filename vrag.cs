﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vrag : Unit
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Unit unit = collider.GetComponent<Unit>();
        if (unit && unit is men)
        {
            unit.Damage();
        }
        
    }
    public override void Damage()
    {
        Destroy(gameObject);
    }
}
