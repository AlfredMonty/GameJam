using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chests : Collectables
{
    public Sprite emptyChest;
    public float pesos = 0f; 
    public float pesosGiven = 0f;
    public int randMin = 1; 
    public int randMax = 10; 
    // public float pesoReward = 0f; 


    protected override void OnCollect() {
        if (!collected) {
            collected = true; 
            GetComponent<SpriteRenderer>().sprite = emptyChest; 
            pesosGiven = Random.Range(randMin, randMax);
            print("Granted " + pesosGiven + " peso(s) | " + "Owned " + pesos + " peso(s)");
            pesos = pesos + pesosGiven;
        }
        else {
            print("The chest is empty | " + "Owned " + pesos + " peso(s)");
        }
          
    }
}
