using UnityEngine;

public class Block : MonoBehaviour
{
    public int groupSize; // Blok grubunun boyutu (BoardManager'dan ayarlanabilir)
    public Sprite defaultIcon; // Varsayılan ikon
    public Sprite firstIcon;   // İlk eşik değeri için ikon
    public Sprite secondIcon;  // İkinci eşik değeri için ikon
    public Sprite thirdIcon;   // Üçüncü eşik değeri için ikon

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        UpdateIcon(); // Başlangıçta ikonu ayarla
    }

    public void SetIcon(Sprite icon)
    {
        // BoardManager tarafından atanan ikonu kullan
        defaultIcon = icon;
        spriteRenderer.sprite = defaultIcon;
    }

    public void UpdateIcon()
    {
        // Grup boyutuna göre ikonları değiştir
        if (groupSize >= 10)
            spriteRenderer.sprite = thirdIcon;
        else if (groupSize >= 7)
            spriteRenderer.sprite = secondIcon;
        else if (groupSize >= 4)
            spriteRenderer.sprite = firstIcon;
        else
            spriteRenderer.sprite = defaultIcon;
    }

    private void OnMouseDown()
    {
        // Blok tıklanınca yapılacak işlemler
        Debug.Log($"Blok tıklandı: {gameObject.name}, Grup Boyutu: {groupSize}");
        // Bu noktada bloğun patlatılması veya diğer etkileşimler eklenebilir.
    }
}
