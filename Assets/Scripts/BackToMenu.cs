using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    // Hàm gọi khi bấm nút "Back"
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene"); // Đổi tên nếu khác
    }
}
