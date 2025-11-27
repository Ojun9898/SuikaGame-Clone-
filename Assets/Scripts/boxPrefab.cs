using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxPrefab : MonoBehaviour
{
    GameOver gameOverListner;

    void Start()
    {
        gameOverListner = transform.GetComponentInChildren<GameOver>();
        gameOverListner.gamoverUI = GameObject.Find("Canvas").transform.Find("GameOver_UI").gameObject;
        gameOverListner.firebase = GameObject.Find("Firebase").GetComponent<FirebaseInit>();
        gameOverListner.spawnPointer = GameObject.Find("spawnPointer");
        gameOverListner.MotionInteraction = GameObject.Find("MotionInteraction");
        gameOverListner.gameSystem = GameObject.Find("GameSystem");
    }
}
