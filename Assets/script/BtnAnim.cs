using Unity.VisualScripting;
using UnityEngine;

public class BtnAnim : MonoBehaviour
{
    public Animator Anim;
    public bool isWalk = false;
    public bool isJump = false;

    public void Walk()
    {
        if (!isWalk || isJump)
        {
            Anim.SetBool("isWalk", true);
            isWalk = true;
            Anim.SetBool("isJump", false);
            isJump = false;
        }
    }

    public void Stop()
    {
        if (isWalk)
        {
            Anim.SetBool("isWalk", false);
            isWalk = false;
        }
        else if (isJump)
        {
            Anim.SetBool("isJump", false);
            isJump = false;
        }
    }

    public void jump()
    {
        if (!isJump || isWalk)
        {
            Anim.SetBool("isWalk", false);
            Anim.SetBool("isJump", true);
            isJump = true;
            isWalk = false;
        }
    }

}
