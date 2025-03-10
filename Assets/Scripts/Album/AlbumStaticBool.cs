using UnityEngine;

public class AlbumStaticBool : MonoBehaviour
{
    public static bool AlbumMinatu = false;
    public static bool AlbumMural = false;
    public static bool AlbumCompleto = false;
    private bool albumActivo = false;

    public GameManager Manager;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (albumActivo)
            {
                Manager.AlbumDesactivo();
            }
            else
            {
                Manager.AlbumActivo();
            }
            albumActivo = !albumActivo; // Alterna entre true y false
        }

        if (AlbumMinatu)
        {
            Manager.MinatuEnAlbum();
            print("AlmbuMinatuListo");
        }

        if (AlbumMural)
        {
            Manager.MuralEnAlbum();
            print("AlmbuMuralListo");
        }

        if (AlbumMinatu && AlbumMural)
        {
            print("ESTA COMPLETO");
            AlbumCompleto = true;
        }
    }
}
