using UnityEngine;

public class StartState : BaseState
{
    private float loadingTime = 10.0f;

    public override void PrepareState()
    {
        base.PrepareState();

        Debug.Log("Game is loading");
        GameController.Instance.GrabSystem.SetGrabSystemEnabled(false);
        GameController.Instance.UIController.SetupStartUI();
        Time.timeScale = 0.0f;
    }

    public override void UpdateState()
    {
        base.UpdateState();

        loadingTime -= Time.unscaledDeltaTime;
        if (loadingTime <= 0.0f)
        {
            owner.ChangeState(new MainState());
        }
    }
}
