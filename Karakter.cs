﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karakter
{
    private string name;
    private int health;
    private int damage;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
        }
    }
    public int Damage
    {
        get
        {
            return damage;
        }
        set
        {
            damage = value;
        }
    }
    public  void MoveLeft()
    {
        Debug.Log("Gerak ke kiri");
    }
    public void MoveRighrt()
    {
        Debug.LogFormat("Gerak ke kanan");
    }
    public void Jump()
    {
        Debug.Log("Loncat");
    }
    public void Attack()
    {
        Debug.Log("Serang");
    }
}
