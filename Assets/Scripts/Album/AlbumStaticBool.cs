using UnityEngine;

public class AlbumStaticBool : MonoBehaviour
{
    public static bool AlbumMinatu = false;
    public static bool AlbumMural = false;


    public GameManager Manager;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V)) 
        {
            Manager.AlbumActivo();
        }
        if (AlbumMinatu == true) 
        {
            Manager.MinatuEnAlbum();
        }
        if (AlbumMural == true)
        {
            Manager.MuralEnAlbum();
        }
    }
}
