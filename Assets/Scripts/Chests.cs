using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chests : Collidables
{
    public float pesos = 0f; 
    public float pesosGiven = 0f;
    // public float pesoReward = 0f; 


    protected override void onCollide(Collider2D coll) {

        if (pesosGiven == 0) {
            pesosGiven = Random.Range(1, 10);
            print("Granted " + pesosGiven + " peso(s) | " + "Owned " + pesos + " peso(s)");
            pesos = pesos + pesosGiven;
        }
        else {
            print("The chest is empty");
        }
          
    }
}
