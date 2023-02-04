using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class jenglmaierscoreboard : MonoBehaviour
{
    public TextMeshProUGUI healthTextMeshPro;
    private jenglmaierPlayerBrain playerHealth;


    private void Start()
    {
        playerHealth = FindObjectOfType<jenglmaierPlayerBrain>();
        
    }

    private void Update()
    {
        if (playerHealth != null)
        {
            healthTextMeshPro.text = playerHealth.health + "/" + playerHealth.maxHealth;
        }

        if (playerHealth.health >= 100)
        {
            healthTextMeshPro.text = "You won!!";
        }

    }
}