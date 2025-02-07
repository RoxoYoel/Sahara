using UnityEngine;
using TMPro;

public class DialogEventScript : MonoBehaviour
{
    public RPG_Move_v2 script;
    public TMP_Text tmpText;
    public TMP_Text tmpName;

    public void DialogEnter()
    {
        script.enabled = false;
    }
    public void DialogExit(GameObject dialog)
    {
        script.enabled = true;
        dialog.SetActive(false); 
    }
    public void LinaColor()
    {
        if (tmpText != null)
        {
            tmpText.color = new Color(1f, 0.4f, 0.7f); 
            tmpName.color = new Color(1f, 0.4f, 0.7f); 
        }
    }
    public void PlayerColor()
    {
        if (tmpText != null)
        {
            tmpText.color = new Color(1f, 1f, 1f);
            tmpName.color = new Color(1f, 1f, 1f); 
            
        }
    }
    public void AminaColor()
    {
        if (tmpText != null)
        {
            tmpText.color = new Color(0f, 1f, 0f);
            tmpName.color = new Color(0f, 1f, 0f);  
        }
    }
    public void LarbiColor()
    {
        if (tmpText != null)
        {
            tmpText.color = new Color(1f, 0.5f, 0f);
            tmpName.color = new Color(1f, 0.5f, 0f);
        }
    }
 public void MinatuColor()
    {
        if (tmpText != null)
        {
            tmpText.color = new Color(1f, 0f, 0f);
            tmpName.color = new Color(1f, 0f, 0f);
        }
    }



 //ESTAS ERAN UNAS FUNCIONES PARA HACER QUE UN NPC TE MIRE A TI CUANDO LE HABLES INDEPENDIENTEMENTE DE LA POSICION EN LA QUE ESTES, SOLO QUE EN EL ANIMATOR TIENEN QUE TENER IDLES DE RIGHT BACK LEFT Y FRONT, TU LAS HICISTE SI QUIERES METERTE EN ESE FREGAO DALE AQUI TIENES LA FUNCION, TIENES QUE METER LA DE STARTDIALOGUE() CUANDO INICIA EL DIALOGO
 
 /*   Vector2 GetPlayerDirection(Transform player, Transform npc)
{
    Vector2 direction = (player.position - npc.position).normalized;

    // Determine the primary direction
    if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
    {
        return direction.x > 0 ? Vector2.right : Vector2.left;
    }
    else
    {
        return direction.y > 0 ? Vector2.up : Vector2.down;
    }
}




void FacePlayer(Transform player)
{
    Vector2 dir = GetPlayerDirection(player, transform);
    Animator animator = GetComponent<Animator>();

    if (dir == Vector2.right)
        animator.Play("Idle_Right");
    else if (dir == Vector2.left)
        animator.Play("Idle_Left");
    else if (dir == Vector2.up)
        animator.Play("Idle_Back");
    else
        animator.Play("Idle_Front");
}





void StartDialogue()
{
    FacePlayer(player.transform);
    dialogueManager.StartDialogue(npcDialogue);
}*/

}
