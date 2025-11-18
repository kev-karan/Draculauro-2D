using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour
{
    [SerializeField] private Button startButton;

    private void OnEnable()
    {
        startButton.onClick.AddListener(GameRestart);
    }

    private void GameRestart()
    {
        SceneManager.LoadScene("Fase-1");
    }
}
