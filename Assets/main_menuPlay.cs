using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    // Reference to the two buttons
    public GameObject buttonA;
    public GameObject buttonB;

    // This method will be called when MainButton is pressed
    public void OnMainButtonPressed()
    {
        // Hide the current button
        gameObject.SetActive(false);

        // Show the other two buttons
        buttonA.SetActive(true);
        buttonB.SetActive(true);
    }
}
