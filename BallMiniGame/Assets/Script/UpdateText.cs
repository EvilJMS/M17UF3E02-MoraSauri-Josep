using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpdateText : MonoBehaviour
{
  private int score;
  public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
      score = PlayerPrefs.GetInt("score");
      text.SetText("Score: "+score);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
