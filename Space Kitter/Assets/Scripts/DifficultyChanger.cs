using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Difficulty
{
    Easy, Medium, Hard
}
public class DifficultyChanger : Singleton<DifficultyChanger>
{
    //public Projectile _projectile;
    public PlayerMovement _PM;

    public Difficulty difficulty;

    private void Start()
    {
        //_projectile = GetComponent<Projectile>();
        //_PM = GetComponent<PlayerMovement>();

        _PM = GameObject.Find("Player").GetComponent<PlayerMovement>();

        SetUp();
    }

    void SetUp()
    {
        switch (difficulty)
        {
            case Difficulty.Easy:
                //_projectile.damageMultiplier = 1;
                _PM.health = 9;
                break;
            case Difficulty.Medium:
                //_projectile.damageMultiplier = 3;
                _PM.health = 3;
                break;
            case Difficulty.Hard:
                //_projectile.damageMultiplier = 9;
                _PM.health = 1;
                break;
        }
    }

    public void ChangeDifficulty(int _PM)
    {
        difficulty = (Difficulty)_PM;
        SetUp();
    }
}
