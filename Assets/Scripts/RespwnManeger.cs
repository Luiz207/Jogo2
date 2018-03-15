using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RespwnManeger : MonoBehaviour {

    public GameBox gameBox;

    private float respawnTimeCounter;

    public float respawnTime;
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        respawnTimeCounter += Time.deltaTime;
        if (respawnTimeCounter >= respawnTime) {

            Respawn();
            respawnTimeCounter = 0;


        }

       }
    private void Respawn()
    {
        GameObject gameBlockPrefab = Resources.Load("GameBlock") as GameObject;
        GameObject gameBlock = Instantiate(gameBlockPrefab);
        gameBlock.transform.SetParent(transform,false);
        int randomColumn = Random.Range(0,GameBox.NumColumnGrid);
        Debug.Log("Respawn Colunm" + randomColumn);
        gameBlock.transform.position= gameBox.GetGridPosition(randomColumn,8);

        
    }

 }

