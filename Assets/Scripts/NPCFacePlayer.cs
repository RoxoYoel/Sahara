using UnityEngine;

public class NPCFacing : MonoBehaviour
{
    public Animator npcAnimator;
    public Transform playerTransform;

    // Call this method when the dialogue starts
    public void FacePlayer()
    {
        Vector2 direction = (playerTransform.position - transform.position).normalized;

        // Determine facing direction based on player's position
        if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
        {
            if (direction.x > 0)
                SetFacing("Right");
            else
                SetFacing("Left");
        }
        else
        {
            if (direction.y > 0)
                SetFacing("Front");
            else
                SetFacing("Back");
        }
    }

    private void SetFacing(string direction)
    {
        npcAnimator.Play($"Idle_{direction}");
    }
}
