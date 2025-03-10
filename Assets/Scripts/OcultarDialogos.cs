using UnityEngine;

public class OcultarDialogos : MonoBehaviour
{
    public GameObject triggerAmina;
    public GameObject triggerMinatu;
    public GameObject intMinatu;
    public GameObject intAmina;
    void Start()
    {
        if (AlbumStaticBool.AlbumMural)
        {
            intAmina.SetActive(false);
            triggerAmina.SetActive(false);
        }
        if (AlbumStaticBool.AlbumMinatu)
        {
            intMinatu.SetActive(false);
            triggerMinatu.SetActive(false);
        }
    }
}
