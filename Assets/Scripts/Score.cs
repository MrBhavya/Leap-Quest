
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = ((player.position.x + 24.92f)*10).ToString("0");
    }
}