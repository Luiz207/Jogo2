using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBox : MonoBehaviour {

    private const int numColumnGrid = 4;
    private const int numRowGrid = 9;

    private float gridAreaWidth;
    private float gridAreaHeight;
    private Vector3 gridAreaPosition;

    private float gameBlockWidth;
    private float gameBlockHeight;

      public static int NumColumnGrid
    {
        get { return numColumnGrid; }
    }
	// Use this for initialization
	void Start () {
     
       Transform transformGridArea = transform.Find("GridArea");
        SpriteRenderer spriteRendererGridArea = transformGridArea.gameObject.GetComponent<SpriteRenderer>();
        gridAreaWidth = spriteRendererGridArea.bounds.size.x;
        gridAreaHeight = spriteRendererGridArea.bounds.size.y;

        gameBlockWidth = gridAreaWidth/ numColumnGrid;
        gameBlockHeight = gridAreaHeight / numRowGrid;

        gridAreaPosition = transformGridArea.position;
        gridAreaPosition.z = 0f;

        // Teste
       /* for (int x=0; x < numColumnGrid; x++)
        {
            for (int y=0; y < numRowGrid; y++) {

                GameObject gameBlockPrefab = Resources.Load("GameBlock") as GameObject;
                GameObject gameBlock = Instantiate(gameBlockPrefab);
                float posX = x * gameBlockWidth - (gridAreaWidth /2) + (gameBlockWidth /2);
                float posY = y * gameBlockHeight - (gridAreaHeight/2) + (gameBlockHeight);
                gameBlock.transform.position =
                    new Vector3(posX, posY, 0f) + gridAreaPosition;
                gameBlock.transform.SetParent(transform, false);
            }
        }*/
	}
	
    public Vector3 GetGridPosition(int x , int y) {
        float posX = x * gameBlockWidth - (gridAreaWidth / 2) + (gameBlockWidth / 2);
        float posY = y * gameBlockHeight - (gridAreaHeight / 2) + (gameBlockHeight);
        return new Vector3(posX, posY, -1f) + gridAreaPosition;

    }
	// Update is called once per frame
	void Update () {
		
	}
}
