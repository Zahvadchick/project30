using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lives : MonoBehaviour
{
    private Transform[] hearts = new Transform[5];
    [SerializeField]
    private men charekter;
    // Start is called before the first frame update
    void Start()
    {
       charekter= FindObjectOfType<men>();
        for (int i = 0; i < hearts.Length; i++)
        {
            hearts[i] = transform.GetChild(i);
        }
        Refresh();
    }
    void Awake()
    {
        charekter = FindObjectOfType<men>();
        for (int i = 0; i < hearts.Length; i++)
        {
            hearts[i] = transform.GetChild(i);
        }
        Refresh();
    }
    public void Refresh()

    {
        for (int i = 0; i <hearts.Length; i++)
        {
            if (i < (charekter as men).Lives)
                hearts[i].gameObject.SetActive(true);
            else
                hearts[i].gameObject.SetActive(false);
        }
    }
}
