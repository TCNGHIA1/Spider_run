using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public enum PlayerMoveStatus
{
    Run,Jump,DoubleJump,Die
}
public class Player_Move : MonoBehaviour
{
    public float jump_Power;
    public PlayerMoveStatus status;
    public Sprite_Animation _SA;
    public Sound_Player _SP;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        KEYBOARD();
        TOUCH();
        GetComponent<Rigidbody>().WakeUp();
    }
    //Run
    void RUN()
    {
        status = PlayerMoveStatus.Run;
        if(_SA!=null)
        {
            _SA.Run_Play();
        }
    }
    //
    void JUMP()
    {
        status = PlayerMoveStatus.Jump;
        GetComponent<Rigidbody>().AddForce(0, jump_Power * 1.5f, 0);

        if (_SA != null)
        {
            _SA.Jump_Play();
        }
        if (_SP != null)
        {
            _SP.SoundPlay(0);
        }
    }
    //Double Jump
    void DOUBLEJUMP()
    {
        status = PlayerMoveStatus.DoubleJump;
        GetComponent<Rigidbody>().AddForce(0, jump_Power, 0);
        if(_SA!= null)
        {
            _SA.D_JUMP_PLAY();
        }
        if (_SP != null)
        {
            _SP.SoundPlay(0);
        }
    }
    //Dieu khien
    void KEYBOARD()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if(status == PlayerMoveStatus.Jump)
            {
                DOUBLEJUMP();
            }
            if (status == PlayerMoveStatus.Run)
            {
                JUMP();
            }
        }
    }

    //collision
    private void OnCollisionEnter(Collision collision)
    {
        if(status != PlayerMoveStatus.Die)
        {
            RUN();
        }
    }
    void TOUCH()
    {
        if (Input.touchCount > 0)
        {
            if(Input.GetTouch(0).phase == TouchPhase.Began)
            {
                if(status == PlayerMoveStatus.Jump)
                {
                    DOUBLEJUMP();
                }
                if (status == PlayerMoveStatus.Run)
                {
                    JUMP();
                }
            }
        }
    }
}
