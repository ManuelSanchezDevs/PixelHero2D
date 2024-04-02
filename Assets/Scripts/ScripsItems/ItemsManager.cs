using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsManager : MonoBehaviour
{
    [SerializeField] PlayerExtrasTracker playerExtrasTracker;
    [SerializeField] UIManager UImanager;

    private float _heartsCounterNumber = 5;
    private float _coinSpinNumber = 6;  //MonedaGirando  -- ejecuta el dash
    private float _coinShineNumber = 10;  //MonedaBrillando  -- ballmode y dropbombs

    public float HeartsCounterNumber { get => _heartsCounterNumber; set => _heartsCounterNumber = value; }
    public float CoinSpinNumber { get => _coinSpinNumber; set => _coinSpinNumber = value; }
    public float CoinShineNumber { get => _coinShineNumber; set => _coinShineNumber = value; }

    void Start()
    {
        playerExtrasTracker = FindObjectOfType<PlayerExtrasTracker>();
        UImanager = GameObject.FindObjectOfType<UIManager>();
    }

    public void PickCounter()
    {
        HeartsCounterNumber --;
        UImanager.Heart--;

        if ( HeartsCounterNumber == 0)
        {
            playerExtrasTracker.CanDoubleJump = true;
        }
    }

    public void CoinSpinCounter()
    {
        CoinSpinNumber --;
        UImanager.CoinSpin--;
            
        if (CoinSpinNumber == 0)
        {
            playerExtrasTracker.CanDash = true;
        }
    }

    public void CoinShineCounter()
    {
        CoinShineNumber --;
        UImanager.CoinShin--;

        if (CoinShineNumber == 0)
        {
            playerExtrasTracker.CanDropBombs = true;
            playerExtrasTracker.CanEnterBallMode = true;
        }
    }
}
