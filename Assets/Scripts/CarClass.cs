using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class CarClass : MoveClass
{
    public override void Move()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);


    }

    public void Update()
    {
        Move();
    }

    public class AutoSpeed : MonoBehaviour
    {
        private float speed = 5f; // Encapsulated speed variable

        public float Speed // Getter and Setter for speed
        {
            get { return speed; }
            set { speed = Mathf.Clamp(value, 0f, 10f); } // Optional: Limit the speed to a certain range
        }
    }
}
