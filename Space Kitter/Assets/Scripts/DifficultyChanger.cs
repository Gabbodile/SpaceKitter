using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Difficulty
{
    Easy, Medium, Hard
}
public class DifficultyChanger : MonoBehaviour
{
    public Projectile _projectile;

    public Difficulty difficulty;

    private void Start()
    {
        _projectile = GetComponent<Projectile>();
        SetUp();
    }

    void SetUp()
    {
        switch (difficulty)
        {
            case Difficulty.Easy:
                _projectile.damageMultiplier = 1;
                break;
            case Difficulty.Medium:
                _projectile.damageMultiplier = 3;
                break;
            case Difficulty.Hard:
                _projectile.damageMultiplier = 9;
                break;
        }
    }

    public void ChangeDifficulty(int _projectile)
    {
        difficulty = (Difficulty)_projectile;
        SetUp();
    }
}
