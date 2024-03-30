using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hook : MonoBehaviour
{
    [SerializeField]
    private Transform itemHolder;

    private bool itemAttached;

    private HookMovement hookMovement;

    void Awake()
    {
        hookMovement = GetComponentInParent<HookMovement>();
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == Tags.SMALL_GOLD || target.tag == Tags.MIDDLE_GOLD ||
        target.tag == Tags.LARGE_GOLD || target.tag == Tags.LARGE_STONE ||
        target.tag == Tags.MIDDLE_STONE)
        {
            itemAttached = true;

            target.transform.parent = itemHolder;
            target.transform.position = itemHolder.position;

            hookMovement.move_Speed = target.GetComponent<Item>().hook_Speed;

            hookMovement.HookAttachedItem();

            // animation player

            if (target.tag == Tags.SMALL_GOLD || target.tag == Tags.MIDDLE_GOLD ||
            target.tag == Tags.LARGE_GOLD)
            {
                // SoundManager.instance.HookGrab_Gold();
            }
            else if (target.tag == Tags.MIDDLE_STONE || target.tag == Tags.LARGE_STONE)
            {
                // SoundManager.instance.HookGrab_Stone();
            }

            // SoundManager.instance.PullSound(true);
        }
    }
}
