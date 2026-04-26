using System;
using UnityEngine;
using UnityEngine.Serialization;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameRuntime gameRuntime;

    private float _countdownTime = 0f;
    private int _countdownDigit = 0;
    
    private void Awake()
    {
        SetState(GameState.MainMenu);
    }


    public void SetState(GameState state)
    {
        gameRuntime.gameState = state;
        
        #region MainMenu state
        ShowMainMenu(gameRuntime.gameState == GameState.MainMenu);
        #endregion

        #region Countdown state
        if (state == GameState.Countdown)
        {
            _countdownTime = 3f;
            _countdownDigit = Mathf.CeilToInt(_countdownTime);

            if (_countdownTime <= 0f)
            {
                SetState(GameState.GameplayDay);
            }
        }
        #endregion
        
        #region Gameplay state
        if (state == GameState.GameplayDay)
        {
            
        }
        #endregion
    }

    private void Update()
    {
        var state = gameRuntime.gameState;
        
        if (state == GameState.Countdown)
        {
            _countdownTime -= Time.deltaTime;
            
        }
    }

    public void ShowMainMenu(bool show)
    {
        // TODO
    }

    public void StartGame()
    {
        SetState(GameState.Countdown);
    }
}
