using UnityEngine;

public class KoleksiManager : MonoBehaviour
{
    [Header("Daftar Gembok (Icon_Lock) dari Card 1 - 5")]
    public GameObject[] iconLocks;

    [Header("Daftar Gambar Asli (icon_Asli) dari Card 1 - 5")]
    public GameObject[] iconAslis;

    [Header("ID Unik Kartu (Isi: Aset_01, Aset_02, dst)")]
    public string[] assetIDs;

    void Start()
    {
        // Ngecek status setiap kartu satu per satu (Looping)
        for (int i = 0; i < assetIDs.Length; i++)
        {
            // Ambil data dari local storage Unity (PlayerPrefs)
            // Nilai '0' adalah default kalau belum pernah discan
            if (PlayerPrefs.GetInt(assetIDs[i], 0) == 1)
            {
                // Status: UNLOCKED (Sudah discan)
                iconLocks[i].SetActive(false); // Matikan gembok
                iconAslis[i].SetActive(true);  // Nyalakan thumbnail rumah adat
            }
            else
            {
                // Status: LOCKED (Belum discan)
                iconLocks[i].SetActive(true);  // Nyalakan gembok
                iconAslis[i].SetActive(false); // Matikan thumbnail rumah adat
            }
        }
    }
    
    // Fitur Reset buat testing
    public void ResetMemori()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("Semua memori di-reset! Semua rumah kembali tergembok.");
    }
}