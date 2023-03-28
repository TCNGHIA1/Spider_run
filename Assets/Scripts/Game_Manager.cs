using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Game_Manager : MonoBehaviour
{
    public int GameLV;
    public float GameSpeed;
    public Box_Loop _BL;
    public Scroll_Mapping _SM;
    public GameObject Player;
    public Bullet_Move _BM;


    private float meter;
    private int getMoney = 0;
    public int countBettery = 4;

    //
    public GameObject gameOver;
    public GameObject gameComplete;
    public GameObject Pause;
    public Image bettery;

    //text get value gold and meter
    public TMP_Text[] gold_Label;
    public TMP_Text[] meter_label;

    public Sprite[] betterys;

    void Start()
    {
        GameSpeed = _BL.Speed;
    }

    // Update is called once per frame
    void Update()
    { 
            METERUPDATE();
    }

    //Tuong tac giao dien

    void METERUPDATE() {
        meter += Time.deltaTime * GameSpeed;
        meter_label[2].text = string.Format("{0:N0}<color=#ff3366> m</color>", meter);
        meter_label[0].text = meter_label[1].text = meter_label[2].text;
        
    }

    private void GameLevelUp()
    {
        GameLV += 1;
        GameSpeed += 3;
        _SM.ScrollSpeed += 0.1f;
        _BL.Speed = GameSpeed;
        _BM.BulletSpeed += 0.5f;
    }

    public void GAMEOVER()
    {
        Time.timeScale = 0;
        gameOver.SetActive(true);
    }
    //get coin
    public void GETCOIN()
    {
        getMoney += 1;
        gold_Label[0].text = string.Format("{0:N0}", getMoney);
        gold_Label[2].text= gold_Label[1].text = gold_Label[0].text ;
        if (getMoney >= 10 && GameLV == 1)
        {
           GameLevelUp();
        }
        if (getMoney >= 30 && GameLV == 2)
        {
            GameLevelUp();
        }
        if (getMoney >= 100 && GameLV == 3)
        {
            GameLevelUp();
        }
        if (getMoney >= 150 && GameLV == 4)
        {
            GameLevelUp();
        }
        if (getMoney >= 200 && GameLV == 5)
        {
            GameComplete();
        }
    }
    //sự kiện xảy ra khi chạm bettery hoặc bullet
    public void GETBETTERY()
    {
        if(countBettery > 4)
        {
            countBettery = 4;
        }
            if (countBettery == 0)
            {
                bettery.overrideSprite = betterys[0];
                GAMEOVER();
            }
            else if (countBettery == 1)
            {
                bettery.overrideSprite = betterys[1];
            }
            else if (countBettery == 2)
            {
                bettery.overrideSprite = betterys[2];
            }
            else if (countBettery == 3)
            {
                bettery.overrideSprite = betterys[3];
            }
            else if (countBettery == 4)
            {
                bettery.overrideSprite = betterys[4];
            }

        



    }

    void GameComplete()
    {
        gameComplete.SetActive(true);
        Player.SetActive(false);
        Time.timeScale = 0;
    }


    public void PauseGame(bool check) 
    {
        if (check)
        {
            Time.timeScale = 0;
            Pause.SetActive(check);
        }
        else
        {
            Time.timeScale = 1;
            Pause.SetActive(check);
        }
    }
}
