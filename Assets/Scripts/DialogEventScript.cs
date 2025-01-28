using UnityEngine;

public class DialogEventScript : MonoBehaviour
{
    public GhostMove script;
    public GameObject dialog;

    void Start()
    {

    }


    void Update()
    {
        
    }

    public void DialogEnter()
    {
        script.enabled = false;
    }
    public void DialogExit()
    {
        script.enabled = true;
        dialog.SetActive(false); 

    }
}
