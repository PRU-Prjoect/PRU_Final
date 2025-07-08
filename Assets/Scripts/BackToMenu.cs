using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{

    public void ReturnToStartMenu()
    {
        SceneManager.LoadScene("StartScene");
    }
    // Hàm gọi khi bấm nút "Back"
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene"); // Đổi tên nếu khác
    }
}
