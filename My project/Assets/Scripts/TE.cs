using UnityEngine;
using TMPro;

public class DisplayVariable : MonoBehaviour
{
    public TextMeshProUGUI myText;
    public TextMeshProUGUI myText2; 
    public void Update()
    {
        GameManager manager = FindObjectOfType<GameManager>();
        myText.text = "Enemies Alive: " + manager.enemies.ToString();
        myText2.text = "Round : " + manager.round.ToString();
    }
}
