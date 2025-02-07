using UnityEngine;
using TMPro;

public class DialogueAudio : MonoBehaviour
{
    public TextMeshProUGUI targetText; // Assign the TextMeshPro component from the other canvas
    public AudioSource audioSource; // Assign an AudioSource with a typing sound

    private string previousText = ""; // Stores the last frame's text

    private void Update()
    {
        if (targetText == null || audioSource == null) return;

        string currentText = targetText.text;

        // Check if a new character has been added
        if (currentText.Length > previousText.Length)
        {
            audioSource.pitch = Random.Range(0.95f, 1.05f);
            audioSource.Play(); // Play sound on new character
        }

        // Update the previous text state
        previousText = currentText;
    }
}
