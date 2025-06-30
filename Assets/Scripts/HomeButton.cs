using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HomeButton : MonoBehaviour
{
    [SerializeField] string homeSceneName = "StartMenu"; // hoặc tên scene chính xác của bạn

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(GoToHome);
    }

    void GoToHome()
    {
        SceneManager.LoadScene(homeSceneName);
    }
}
