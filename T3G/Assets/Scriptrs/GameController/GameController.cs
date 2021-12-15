using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance { get; private set; }

    public InputMaster Controls { get; private set; }

    [SerializeField]
    private PlayerMovementController playerMovementController;

    public PlayerMovementController PlayerMovementController => playerMovementController;


    private void Awake()
    {
        if (Instance == null)
            Instance = this;

        if (Controls == null)
            Controls = new InputMaster();
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
