using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip getCoin;
    public static AudioClip fan;
    public static AudioClip trash;
    public static AudioClip sad;
    public static AudioClip hit;
    public static AudioClip fist;
    public static AudioClip sbattack1;
    public static AudioClip sbattack2;
    public static AudioClip sbattack3;
    public static AudioClip sbskill1;
    public static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        getCoin = Resources.Load<AudioClip>("coin");
        fan = Resources.Load<AudioClip>("fan");
        trash = Resources.Load<AudioClip>("trashbin");
        sad = Resources.Load<AudioClip>("sad");
        hit = Resources.Load<AudioClip>("hit");
        fist = Resources.Load<AudioClip>("fist");
        sbattack1 = Resources.Load<AudioClip>("sbattack1");
        sbattack2 = Resources.Load<AudioClip>("sbattack2");
        sbattack3 = Resources.Load<AudioClip>("sbattack3");
        sbskill1 = Resources.Load<AudioClip>("sbskill1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void playCoinClip()
    {
        audioSrc.PlayOneShot(getCoin);
    }
    public static void playTrashbinClip()
    {
        audioSrc.PlayOneShot(trash);
    }
    public static void playFanClip()
    {
        audioSrc.PlayOneShot(fan);
    }
    public static void playSadClip()
    {
        audioSrc.PlayOneShot(sad);
    }
    public static void playHitClip()
    {
        audioSrc.PlayOneShot(hit);
    }
    public static void playFistClip()
    {
        audioSrc.PlayOneShot(fist);
    }
    public static void playfirstAClip()
    {
        audioSrc.PlayOneShot(sbattack1);
    }
    public static void playsecondAClip()
    {
        audioSrc.PlayOneShot(sbattack2);
    }
    public static void playthirdAClip()
    {
        audioSrc.PlayOneShot(sbattack3);
    }
    public static void playsbskillClip()
    {
        audioSrc.PlayOneShot(sbskill1);
    }
}
