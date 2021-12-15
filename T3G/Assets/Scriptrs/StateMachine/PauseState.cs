using UnityEngine;

public class PauseState : BaseState
{
    public override void PrepareState()
    {
        base.PrepareState();

        GameController.Instance.CanPause = false;
        GameController.Instance.GrabSystem.SetGrabSystemEnabled(false);

        GameController.Instance.UIController.SetupPauseUI();

        Debug.Log("Pause State");
        Time.timeScale = 0.0f;
    }
}
