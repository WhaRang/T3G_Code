using UnityEngine;

public class MainState : BaseState
{
    public override void PrepareState()
    {
        base.PrepareState();

        GameController.Instance.CanPause = true;
        GameController.Instance.GrabSystem.SetGrabSystemEnabled(true);
        GameController.Instance.UIController.SetupMainUI();

        Debug.Log("Main State");
        Time.timeScale = 1.0f;
    }

    public override void UpdateState()
    {
        base.UpdateState();

        GameController.Instance.PlayerMovementController.UpdateController();
    }
}
