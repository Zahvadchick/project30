using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zhizni : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        men unit = collider.GetComponent<men>();
        if (unit)
        {
            unit.Lives++;
            Destroy(gameObject);
        }
    }
}
