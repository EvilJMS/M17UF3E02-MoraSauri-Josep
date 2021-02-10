using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectCoin : MonoBehaviour
{
    private int monedas;
    private int score;
    public Image coin;
    // Start is called before the first frame update
    void Start()
    {
        monedas = 0;
        score = 0;
        PlayerPrefs.SetInt("monedas",monedas);
        PlayerPrefs.SetInt("score",score);
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        monedas = PlayerPrefs.GetInt("monedas");
        score = PlayerPrefs.GetInt("score");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            coin.enabled = true;
            monedas++;
            score += 100;
            PlayerPrefs.SetInt("monedas",monedas);
            PlayerPrefs.SetInt("score",score);
            PlayerPrefs.Save();
            Destroy(this.gameObject);
        }
    }
}
