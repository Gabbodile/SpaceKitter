using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Difficulty
{
    Easy, Medium, Hard
}
public class DifficultyChanger : Singleton<DifficultyChanger>
{
    public PlayerMovement _PM;

    public Difficulty difficulty;

    private void Start()
    {
        //_PM = GetComponent<PlayerMovement>();

        _PM = GameObject.Find("Player").GetComponent<PlayerMovement>();

        SetUp();
    }

    void SetUp()
    {
        switch (difficulty)
        {
            case Difficulty.Easy:
                _PM.healthMultipier = 9;
                break;
            case Difficulty.Medium:
                _PM.healthMultipier = 3;
                break;
            case Difficulty.Hard:
                _PM.healthMultipier = 1;
                break;
        }
    }

    public void ChangeDifficulty(int _PM)
    {
        difficulty = (Difficulty)_PM;
        SetUp();
    }
}
