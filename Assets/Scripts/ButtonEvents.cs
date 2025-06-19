using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonEvents : MonoBehaviour
{
    public void OnContinueClicked()
    {
        // TODO: load latest save
        // SceneManager.LoadScene("GameScene");
        Debug.Log("Continue button clicked");
    }

    public void OnNewGameClicked()
    {
        // TODO: load the first game level
        // SceneManager.LoadScene("GameScene");
        Debug.Log("new game button clicked");
    }

    public void OnSettingsClicked()
    {
        // TODO: load latest save
        // SceneManager.LoadScene("GameScene");
        Debug.Log("settings button clicked");
    }
}