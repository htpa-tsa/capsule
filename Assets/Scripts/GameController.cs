using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : Singleton<GameController>{

    protected GameController() { }

    private int mHealth = 100;

    public void SetDamage(int damage)
    {
        mHealth -= damage;

        if(mHealth <= 0)
        {
            mHealth = 0;
        }
    }

    public int Health
    {
        get { return mHealth; }
    }
}
