using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Game",menuName ="Scriptable Object/Game")]

public class Game : ScriptableObject
{
    // ---------------------------
    // Variables
    // ---------------------------

    [Header("Game Settings")]
    public bool isGameOver = false;
    public float gameDuration;
    public float currentTime;
    public bool activateTimer;
    public int scores;
}
