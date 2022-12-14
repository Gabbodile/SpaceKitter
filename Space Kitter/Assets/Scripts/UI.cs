using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UI : MonoBehaviour
{
    
    public PlayerMovement _score;
    public GameObject endTrigger;

    public TMP_Text scoreText;
    public TMP_Text timer;

    private void Start()
    {
        _score = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    public void ScoreText(int _score)
    {
        scoreText.text = "Score: " + _score;
    }
    
}
