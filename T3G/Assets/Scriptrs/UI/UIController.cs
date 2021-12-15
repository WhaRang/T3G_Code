using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private Image panel;

    [SerializeField]
    private Text stateText;

    [SerializeField]
    private Image middleDot;

    public void SetupPauseUI()
    {
        middleDot.gameObject.SetActive(false);
        panel.gameObject.SetActive(true);
        stateText.gameObject.SetActive(true);
        stateText.text = "Game is paused";
    }

    public void SetupMainUI()
    {
        middleDot.gameObject.SetActive(true);
        panel.gameObject.SetActive(false);
        stateText.gameObject.SetActive(false);
    }

    public void SetupStartUI()
    {
        panel.gameObject.SetActive(true);
        stateText.gameObject.SetActive(true);
        middleDot.gameObject.SetActive(false);
        stateText.text = "Game is launching...";
    }
}
