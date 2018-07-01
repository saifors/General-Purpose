using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    public AudioClip[] clips;
	
    public void PlaySound(int num, float vol, bool is2D)
    {
        GameObject obj = new GameObject();
        obj.transform.position = transform.position;
        obj.name = "AUDIO_" + clips[num].name;

        AudioSource source = obj.AddComponent<AudioSource>();
        source.clip = clips[num];
        source.volume = vol;
        //source.pitch = pit; //Not necessary but can be optional.
        if(is2D) source.spatialBlend = 0;
        else source.spatialBlend = 0;
        source.Play();

        Destroy(obj, clips[num].length); //Don't mistake length(length of clip) with "L"ength (Length of array)
    }
    public void PlaySound(int num, float vol, bool is2D, float pit)
    {
        GameObject obj = new GameObject();
        obj.transform.position = transform.position;
        obj.name = "AUDIO_" + clips[num].name;

        AudioSource source = obj.AddComponent<AudioSource>();
        source.clip = clips[num];
        source.volume = vol;
        source.pitch = pit; //Not necessary but can be optional.
        if (is2D) source.spatialBlend = 0;
        else source.spatialBlend = 0;
        source.Play();

        Destroy(obj, clips[num].length);
    }

    //Parented to an object?

    //PlayMusicLoop?
}
