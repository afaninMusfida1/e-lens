using UnityEngine;
using UnityEngine.SceneManagement;

public class PindahHalaman : MonoBehaviour
{
    public void KembaliKeMenu()
    {
        // Ganti "MenuUtama" dengan nama persis file Scene menu awalmu
        SceneManager.LoadScene("ARScene"); 
    }
}