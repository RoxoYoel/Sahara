using UnityEngine;

public class AlbumStaticBool : MonoBehaviour
{
    public static bool AlbumMinatu = false;
    public GameObject Minatu;
    public GameObject Mural;
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
    }
}
