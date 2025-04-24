using UnityEngine;

public class InGameController : MonoBehaviour
{
    [SerializeField] private GameObject inGamePanel;

    public void ActivateInGame()
    {
        inGamePanel.SetActive(true);
    }
}
