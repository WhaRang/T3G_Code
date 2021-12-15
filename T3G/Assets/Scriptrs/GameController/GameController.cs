using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance { get; private set; }

    public InputMaster Controls { get; private set; }

    [SerializeField]
    private StateMachine stateMachine;

    [SerializeField]
    private UIController uiController;

    public UIController UIController => uiController;

    [SerializeField]
    private GrabSystem grabSystem;

    public GrabSystem GrabSystem => grabSystem;

    [SerializeField]
    private PlayerMovementController playerMovementController;

    public PlayerMovementController PlayerMovementController => playerMovementController;

    public bool CanPause { get; set; } = false;


    private void Awake()
    {
        if (Instance == null)
            Instance = this;

        if (Controls == null)
            Controls = new InputMaster();

        Controls.StateControl.Pause.performed += _ => PauseGame();
        Controls.StateControl.Resume.performed += _ => ResumeGame();
    }

    private void PauseGame()
    {
        if (!CanPause)
            return;

        stateMachine.ChangeState(new PauseState());
    }

    private void ResumeGame()
    {
        stateMachine.ChangeState(new MainState());
    }

    private void OnEnable()
    {
        Controls.Enable();
    }

    private void OnDisable()
    {
        Controls.Disable();
    }
}
