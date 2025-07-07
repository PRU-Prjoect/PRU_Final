using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CharacterShopUI : MonoBehaviour
{
    [System.Serializable]
    public class CharacterData
    {
        public string name;
        public Sprite image;
        public int cost;
    }

    [Header("Data")]
    public CharacterData[] characters;

    [Header("Prefabs & UI")]
    public GameObject characterItemPrefab;
    public Transform contentPanel; 
    public TextMeshProUGUI coinText;

    private int playerCoins;

    void Start()
    {
        playerCoins = PlayerPrefs.GetInt("Coin", 0);
        UpdateCoinUI();
        GenerateShop();
    }

    void GenerateShop()
    {
        for (int i = 0; i < characters.Length; i++)
        {
            int index = i;

            GameObject item = Instantiate(characterItemPrefab, contentPanel);


            item.transform.Find("NameText").GetComponent<TextMeshProUGUI>().text = characters[i].name;
            item.transform.Find("CharacterImage").GetComponent<Image>().sprite = characters[i].image;
            item.transform.Find("CostText").GetComponent<TextMeshProUGUI>().text = "Cost: " + characters[i].cost;

            Button button = item.transform.Find("BuyButton").GetComponent<Button>();
            Debug.Log(button);
            TextMeshProUGUI buttonText = button.GetComponentInChildren<TextMeshProUGUI>();

            bool isUnlocked = PlayerPrefs.GetInt("CharacterUnlocked_" + index, 0) == 1;

            if (isUnlocked)
            {
                buttonText.text = "Select";
            }
            else
            {
                buttonText.text = "Buy";
            }

            button.onClick.AddListener(() => HandleButton(index, buttonText));
        }
    }

    void HandleButton(int index, TextMeshProUGUI buttonText)
    {

        MessagePopup popup = FindFirstObjectByType<MessagePopup>();

        bool isUnlocked = PlayerPrefs.GetInt("CharacterUnlocked_" + index, 0) == 1;

        if (isUnlocked)
        {
            PlayerPrefs.SetInt("SelectedCharacter", index);
            popup.ShowMessage("Selected: " + characters[index].name);
            return;
        }

        if (playerCoins >= characters[index].cost)
        {
            playerCoins -= characters[index].cost;
            PlayerPrefs.SetInt("Coin", playerCoins);
            PlayerPrefs.SetInt("CharacterUnlocked_" + index, 1);
            PlayerPrefs.SetInt("SelectedCharacter", index);

            UpdateCoinUI();
            buttonText.text = "Select";
            popup.ShowMessage("Purchased successfully: " + characters[index].name);
        }
        else
        {
            popup.ShowMessage("Not enough coins");
        }
    }

    void UpdateCoinUI()
    {
        if (coinText != null)
        {
            coinText.text = playerCoins.ToString();
        }
    }
}
