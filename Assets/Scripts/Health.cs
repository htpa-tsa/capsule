using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour {

    //init var
    public int health;
    public int numOfHearts;
    public Image[] hearts; 
    public Sprite fullHeart;
    public Sprite emptyHeart;

    void Update(){
        //health System
        if (health > numOfHearts){
            health = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++){
            if (i < health){
                hearts[i].sprite = fullHeart;
            } else {
                hearts[i].sprite = emptyHeart;
            }

            //Show max heart system with public var
            if (i < numOfHearts){
                hearts[i].enabled = true;
            } else {
                hearts[i].enabled = false;
            }
        }
    }
}