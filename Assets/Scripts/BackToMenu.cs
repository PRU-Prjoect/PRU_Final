using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public void ReturnToStartMenu()
    {
        SceneManager.LoadScene("StartScene");
    }
}
