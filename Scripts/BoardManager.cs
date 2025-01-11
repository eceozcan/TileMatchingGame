using UnityEngine;

public class BoardManager : MonoBehaviour
{
    public int rows = 10; // Sat�r say�s�
    public int columns = 12; // S�tun say�s�
    public GameObject[] blockPrefabs; // Farkl� bloklar i�in prefab dizisi

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

                // Rastgele bir blok prefab'i se�
                GameObject randomBlock = blockPrefabs[Random.Range(0, blockPrefabs.Length)];

                // Se�ilen prefab'i sahneye yerle�tir
                Instantiate(randomBlock, position, Quaternion.identity, transform);
            }
        }
    }
}
