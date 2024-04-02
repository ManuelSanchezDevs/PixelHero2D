using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private float _heart = 5;
    private float _coinSpin = 6;
    private float _coinShin = 10;

    public float Heart { get => _heart; set => _heart = value; }
    public float CoinSpin { get => _coinSpin; set => _coinSpin = value; }
    public float CoinShin { get => _coinShin; set => _coinShin = value; }

    private void OnGUI()
    {
        GUILayout.Label("HEART  " + _heart );
        GUILayout.Label("COINSPIN  " + _coinSpin);
        GUILayout.Label("COINSHIN  " + _coinShin);
    }
}
