using UnityEngine;
using System.Collections;
using System.Threading;

public class MusicWait : MonoBehaviour {

    AudioSource thingy;
    public int times;

	// Use this for initialization
	void Start () {
        thingy = GetComponent<AudioSource>();
        thingy.Stop();
        Thread.Sleep(5000);
        thingy.Play();
    }
	
	// Update is called once per frame
	void Update () {

	}


}
