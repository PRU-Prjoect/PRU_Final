using UnityEngine;
using TMPro;
using System.Collections;

public class MessagePopup : MonoBehaviour
{
    public GameObject panel;
    public TextMeshProUGUI messageText;
    public float displayTime = 2f;

    public void ShowMessage(string message)
    {
        StopAllCoroutines();
        panel.SetActive(true);
        messageText.text = message;
        StartCoroutine(HideAfterTime());
    }

    IEnumerator HideAfterTime()
    {
        yield return new WaitForSeconds(displayTime);
        panel.SetActive(false);
    }
}
