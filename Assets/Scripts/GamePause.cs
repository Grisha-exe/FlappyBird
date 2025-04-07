using UnityEngine;

public static class GamePause
{
    public static bool IsGamePaused { get; private set; }

    public static void PauseGame()
    {
        IsGamePaused = true;
        Object.FindObjectOfType<Bird>().SimulationOff();
    }

    public static void ResumeGame()
    {
        Object.FindObjectOfType<Bird>().SimulationOn();
        IsGamePaused = false;
    }
}
