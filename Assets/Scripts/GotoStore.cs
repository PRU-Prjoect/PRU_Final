using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoStore : MonoBehaviour
{
    public void LoadStoreScene()
    {
        SceneManager.LoadScene("StoreScene");
    }
}
