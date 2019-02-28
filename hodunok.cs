using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class hodunok : Monster
{
    // Start is called before the first frame update
    [SerializeField]
    public float speed = 3.0F;

    private Vector3 direction;

    private SpriteRenderer sprite;
    void Start()
    {
        sprite = GetComponentInChildren<SpriteRenderer>();
        direction = -transform.right;
    }

    // Update is called once per frame
    void Update()
    {
        CheckGround();
        Move();
    }
    public  void CheckGround()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position+transform.up*0.0F, 0.25F);
        if (colliders.Length > 1)
            Damage();
    }
    private void Move()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position+transform.right*0.45F*direction.x,0.21F);
        if (colliders.Length > 0 && colliders.All(x => !x.GetComponent<men>()))
        {
            direction *= -1.0F;
            sprite.flipX = direction.x > 0.0F;
        }
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, speed * Time.deltaTime);
    }
}
