using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayAgainButton : MonoBehaviour
{
    public string sceneToLoad = "GameScene"; // Đổi tên scene thật sự nếu khác

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(PlayAgain);
    }

    void PlayAgain()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
