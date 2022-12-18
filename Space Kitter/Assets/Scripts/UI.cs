using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UI : MonoBehaviour
{
    //Trying to get the score from the player movement
    public PlayerMovement _PM;
    public int highScore = 0;

    public GameObject endTrigger;

    public TMP_Text scoreText;
    public TMP_Text highestScore;
    public TMP_Text timer;

    private void Start()
    {
        _PM = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }
}
