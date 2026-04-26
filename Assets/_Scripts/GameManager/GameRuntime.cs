using System;
using UnityEngine;

[CreateAssetMenu(fileName = "GameState", menuName = "Scriptable Objects/GameRuntime")]
public class GameRuntime : ScriptableObject
{
    public GameState gameState;

    public float gameTimeLeft;
}

[Serializable]
public enum GameState
{
    MainMenu,
    Countdown,
    GameplayDay,
    GameplayNight,
    GameOver
}
