using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardLayoutScript : MonoBehaviour
{
    //int[] intx;
    //int[] inty;
    Vector2[,] boardPositions;
    [SerializeField] GameObject whiteTile = null;
    [SerializeField] GameObject blackTile = null;
    Vector2 boardOffset = new Vector2(800, 800);
    GameObject tempTile = null;

    void Start()
    {
        boardPositions = new Vector2[8, 8];
        for (int x = 0; x < 8; x++)
        {
            for (int y = 0; y < 8; y++)
            {
                //boardPositions[x, y] = new Vector2((x * 175) + 90, (y * 175) + 90);
                boardPositions[x, y] = new Vector2((x * 100) + 50, (y * 100) + 50);
                tempTile = Instantiate(blackTile, boardPositions[x, y] - boardOffset, Quaternion.identity);
                //tempTile.transform.position = boardPositions[x, y] - boardOffset;
                tempTile.transform.SetParent(this.gameObject.transform);
                //tempTile.transform.localScale = Vector3.one;
            }
        }
    }
}
