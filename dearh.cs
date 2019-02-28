using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dearh : MonoBehaviour
  
{
    // Start is called before the first frame update
    [SerializeField]
    private Transform target;

    public GameObject fastMenu;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Unit unit = collider.GetComponent<Unit>();
        if (unit is men)
        {
            (unit as men).Smept();
            Time.timeScale = 0;
            fastMenu.SetActive(true);
        }
        if (!(unit is men))
            unit.Die();
    }
}
