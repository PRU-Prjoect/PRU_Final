using UnityEngine;
using TMPro;

public class CoinUI : MonoBehaviour
{
    public TextMeshProUGUI coinDisplay;

    void Start()
    {
        coinDisplay.text = "0";
    }

    public void UpdateCoin(int amount)
    {
        coinDisplay.text =  amount.ToString();
    }
}
