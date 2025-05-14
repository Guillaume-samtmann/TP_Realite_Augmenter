using Unity.VisualScripting;
using UnityEngine;

public class BtnAnim : MonoBehaviour
{
    public Animator Anim;

    public void Walk()
    {
        Anim.SetTrigger("walkTriggeur");
    }

    public void jump()
    {
        Anim.SetTrigger("jumpTrigeur");
    }

}
