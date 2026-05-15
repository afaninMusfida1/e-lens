using UnityEngine;

public class UnlockAsset : MonoBehaviour
{
    [Header("ID Aset yang mau dibuka (Misal: Aset_01)")]
    public string assetIDToUnlock;

    // Fungsi ini akan dipanggil otomatis pas kartu berhasil discan
    public void BukaGembokSekarang()
    {
        PlayerPrefs.SetInt(assetIDToUnlock, 1);
        PlayerPrefs.Save();
        Debug.Log("Berhasil membuka gembok: " + assetIDToUnlock);
    }
}