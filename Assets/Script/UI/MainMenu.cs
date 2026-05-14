using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    [Header("Scene Settings")]
    [SerializeField] private string playSceneName = "Game";

    [Header("UI")]
    [SerializeField] private TMP_Text highestScoreText;

    private void Start()
    {
        DisplayHighestScore();
    }

    private void DisplayHighestScore()
    {
        if (highestScoreText != null)
        {
            int highestScore = PlayerPrefs.GetInt("HighestScore", 0);
            highestScoreText.text = $"Highest Score: {highestScore}";
            Debug.Log($"Main Menu - Highest Score: {highestScore}");
        }
    }

    // =========================
    // PLAY GAME
    // =========================
    public void PlayGame()
    {
        if (string.IsNullOrEmpty(playSceneName))
        {
            Debug.LogWarning("Scene name belum diisi.");
            return;
        }

        SceneManager.LoadScene(playSceneName);
    }

    // =========================
    // EXIT GAME
    // =========================
    public void ExitGame()
    {
        Debug.Log("Keluar dari game...");

        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}