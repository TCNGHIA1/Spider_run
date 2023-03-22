using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Get : MonoBehaviour
{
    public Sound_Player _SP;
    public Player_Move _PM;
    public int Get_Coin_Count;
    private Game_Manager _gm;


    // Start is called before the first frame update
    void Start()
    {
        GameObject a = GameObject.Find("05_GameManager");
        if (a != null) _gm = a.GetComponent<Game_Manager>();
    }

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("coin"))
        {
            other.gameObject.SetActive(false);
            Get_Coin_Count++;
            if (_gm != null)
            {
                _gm.GETCOIN();
            }
            if (_SP != null)
            {
                _SP.SoundPlay(1);
            }
        }
        if(other.CompareTag("DeathZone"))
        {
            if(_PM.status != PlayerMoveStatus.Die)
            {
                _PM.status = PlayerMoveStatus.Die;

                if(_gm != null)
                {
                    _gm.GAMEOVER();
                }
                if(_SP != null)
                {
                    _SP.SoundPlay(2);
                }
            }

        }
    }
}
