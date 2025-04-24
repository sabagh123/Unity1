using UnityEngine;

public class StartMenuController : MonoBehaviour
{
    [SerializeField] private GameObject startMenuPanel;
    
    public void DeactivateStartMenu()
    {
        startMenuPanel.SetActive(false);
    }
    
}
