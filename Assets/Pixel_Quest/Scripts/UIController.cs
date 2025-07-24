using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    private Image _heartImage;
    private TextMeshProUGUI _cointext;
    private int _coinCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        _heartImage = GameObject.Find(Structs.UI.heartImage).GetComponent<Image>();
        _cointext = GameObject.Find(Structs.UI.coinText).GetComponent<TextMeshProUGUI>();
        _coinCount = GameObject.Find(Structs.UI.coins).transform.childCount;
    }

    // Update is called once per frame
    public void heartImageUpdate(float newAmount)

    {
        _heartImage.fillAmount = newAmount;
    }
    public void cointextUpdate(int newAmount)
    {
        _cointext.text = newAmount + " / " + _coinCount;
    }
}
