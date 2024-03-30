using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public float hook_Speed;

    public int scoreValue;

    void OnDisable()
    {
        // GameManager.instance.DisplayScore(scoreValue);
    }
}
