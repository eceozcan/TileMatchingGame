using UnityEngine;

public class BoardManager : MonoBehaviour
{
    public int rows = 10; // Satýr sayýsý
    public int columns = 12; // Sütun sayýsý
    public GameObject[] blockPrefabs; // Farklý bloklar için prefab dizisi

    void Start()
    {
        GenerateBoard();
    }

    void GenerateBoard()
    {
        for (int x = 0; x < columns; x++)
        {
            for (int y = 0; y < rows; y++)
            {
                Vector2 position = new Vector2(x, y);

                // Rastgele bir blok prefab'i seç
                GameObject randomBlock = blockPrefabs[Random.Range(0, blockPrefabs.Length)];

                // Seçilen prefab'i sahneye yerleþtir
                Instantiate(randomBlock, position, Quaternion.identity, transform);
            }
        }
    }
}
