using System;
using System.Collections;
using System.Collections.Generic;
using GameSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Panel : MonoBehaviour
{
    [SerializeField] private Game game;
    [SerializeField] private Button button;
    [SerializeField] private GameObject panel;
    [SerializeField] private TextMeshProUGUI text;
    private void Start()
    {
        panel.SetActive(false);
        button.onClick.AddListener(game.Restart);
    }

    public void Ending(string str)
    {
        panel.SetActive(true);
        text.text = $"{str}";
    }
}
