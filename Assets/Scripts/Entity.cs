using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    protected float speed = 5.0f;

    public virtual void Move() // Virtuelle Methode, die in Unterklassen überschrieben werden kann
    {
        // Standardbewegung (könnte leer bleiben oder eine Standardimplementierung haben)
    }
}