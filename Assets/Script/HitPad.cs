using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitPad : MonoBehaviour
{
    GameManager gameManager;
    Button button;

    void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
        button = GetComponent<Button>();
        button.onClick.AddListener(gameManager.HitSlime);
    }
}
