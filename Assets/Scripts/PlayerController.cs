using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Entity
{
    private bool isGameOver = false;

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter Trigger");
        if(other.gameObject.CompareTag("Car"))
        {
            GameOver(); // ABSTRACTION
        }
    }

    public override void Move() // INHERITANCE
    {
        float speed = 5.0f;

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }

    private void Update()
    {
        Move();
    }

    void GameOver()
    {
        isGameOver = true;
        Debug.Log("Game Over!");
        // Hier kannst du weitere GameOver-Logik hinzufügen, z.B. den Hund stoppen oder Autos nicht mehr spawnen
    }

}
