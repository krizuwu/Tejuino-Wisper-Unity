using UnityEngine;

public class InteraccionPerro : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        anim.SetBool("animar", true);
    }
}