using UnityEngine;

public class PauseState : BaseState
{
    public override void PrepareState()
    {
        base.PrepareState();

        Debug.Log("Pause State");
        Time.timeScale = 0.0f;
    }
}
