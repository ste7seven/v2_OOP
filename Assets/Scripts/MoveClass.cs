using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveClass : MonoBehaviour
{
  
        protected float speed;

        public virtual void Move() // Virtuelle Methode, die in Unterklassen �berschrieben werden kann
        {
            // Standardbewegung (k�nnte leer bleiben oder eine Standardimplementierung haben)
        }
    }