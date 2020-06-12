using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class KillDuck : MonoBehaviour
{
    public Animator[] arrows;
    int i = 0;
    public AudioSource source;
    public AudioClip otherClip;
    public AudioClip otherClip2;
	public static bool clicked = true;
    private float cooldown;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    IEnumerator Cooldown()
    {
        yield return new WaitForSeconds (1f);
        source.clip = otherClip;
        source.Play();
        yield return new WaitForSeconds (1.5f);
        foreach(Animator arrow in arrows){
            arrow.SetBool ("shot", false);
        }
        yield return new WaitForSeconds (0.5f);
        i = 0;
        clicked = true;
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && clicked)
        {
            source.clip = otherClip2;
            source.Play();
			arrows[i].SetBool ("shot", true);
			i++;
			if (i == arrows.Length)
			{
				clicked = false;
				StartCoroutine (Cooldown ());
			}
        }
    }
}
