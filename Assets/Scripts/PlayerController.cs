using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MoveClass
{

    public override void Move()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }
    public class MovePlayer : MoveClass
    {
        private void Update()
        {
            Move();
        }

    }
}

