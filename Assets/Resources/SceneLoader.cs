using UnityEngine;
using UnityEngine.SceneManagement; // Wajib ada untuk fungsi pindah scene

public class SceneLoader : MonoBehaviour
{
    public void BukaAR()
    {
        Debug.Log("Berhasil");
        SceneManager.LoadScene("ARScene2");
    }

    public void BukaKoleksi()
    {
        SceneManager.LoadScene("ARScene3");
    }
}