using UnityEngine;

public class DialogEventScript : MonoBehaviour
{
    public RPG_Move_v2 script;

    public void DialogEnter()
    {
        script.enabled = false;
    }
    public void DialogExit(GameObject dialog)
    {
        script.enabled = true;
        dialog.SetActive(false); 
    }
}
