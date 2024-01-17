using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//2 ïðîñòðàíñòâà èì¸í UI è TMpro text
using UnityEngine.UI;
using TMPro;
public class PlayerUi : MonoBehaviour
{
    //Ïîëå èãðîâîãî îáúåêòà ñëàéäåð
    public Slider healthBar;
    // ïîëå òåêñòà ñ êîëè÷åñòâîì ìîíåò
    public TMPro.TextMeshProUGUI CoinsCounter;
    //Ïîëå ñêðèïòà èãðîêà
    public Player player;
    void Start()
    {
        healthBar.maxValue = player.maxHealth;
        healthBar.value = player.health;
        CoinsCounter.text = "coins:" + player.coins;
    }
    void Update()
    {
        healthBar.value = player.health;
        CoinsCounter.text = "coins:" + player.coins;
    }
}
