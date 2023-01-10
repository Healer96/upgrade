using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float moveSpeed;
    public int patrolDestination;
    public SpriteRenderer sprite;
    void Update()
    {
        if (patrolDestination == 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, patrolPoints[0].position, moveSpeed * Time.deltaTime);
            if (Mathf.Abs(transform.position.x - patrolPoints[0].position.x) < .2f)
            {
                sprite.flipX = false;
                patrolDestination = 1;
            }
        }
        else if (patrolDestination == 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, patrolPoints[1].position, moveSpeed * Time.deltaTime);
            if (Mathf.Abs(transform.position.x - patrolPoints[1].position.x) < .2f)
            {
                sprite.flipX = true;
                patrolDestination = 0;
            }
        }
    }
}
