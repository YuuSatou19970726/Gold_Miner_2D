using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void IdleAnimation()
    {
        anim.Play(AniamtionTags.IDLE_ANIMATION);
    }

    public void PullingItemAnimation()
    {
        anim.Play(AniamtionTags.ROPE_WRAP_ANIMATION);
    }
}
