using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    [SerializeField]
    private AudioSource hookGrab_Gold_FX, hookGrab_stone_FX, playerLaugh_FX, pullSoundFX, ropeStretchFX, timeRunningOut_FX, gameEnd_FX;

    void Awake()
    {
        MakeInstance();
    }

    void MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void HookGrab_Gold()
    {
        hookGrab_Gold_FX.Play();
    }

    public void HookGrab_Stone()
    {
        hookGrab_stone_FX.Play();
    }

    public void PlayerLaugh()
    {
        playerLaugh_FX.Play();
    }

    public void PullSound(bool playFX)
    {
        if (playFX)
        {
            if (!pullSoundFX.isPlaying)
                pullSoundFX.Play();
        }
        else
        {
            if (pullSoundFX.isPlaying)
                pullSoundFX.Stop();
        }
    }

    public void RopeStretch(bool playFX)
    {
        if (playFX)
        {
            if (!ropeStretchFX.isPlaying)
                ropeStretchFX.Play();
        }
        else
        {
            if (ropeStretchFX.isPlaying)
                ropeStretchFX.Stop();
        }
    }

    public void TimeRunningOut(bool playFX)
    {
        if (playFX)
        {
            if (!timeRunningOut_FX.isPlaying)
                timeRunningOut_FX.Play();
        }
        else
        {
            if (timeRunningOut_FX.isPlaying)
                timeRunningOut_FX.Stop();
        }
    }

    public void GameEnd()
    {
        gameEnd_FX.Play();
    }
}
