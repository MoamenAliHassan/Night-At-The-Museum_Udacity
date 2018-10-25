using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playingvideo : MonoBehaviour {
	public GameObject outSound;
	public GameObject insideSound;
	public GameObject playVideo;


	// Use this for initialization
	void Start () {
		outSound.SetActive (true);
		insideSound.SetActive (false);
		playVideo.SetActive (false);
	}

	public void OnTriggerEnter(Collider Other){
		if(Other.gameObject.name == "coll"){
			Debug.Log ("I'm here");
			outSound.SetActive (false);
			insideSound.SetActive (true);
			playVideo.SetActive (true);
		

		}
	}

	public void OnTriggerExit(Collider Other){
		if(Other.gameObject.name == "coll"){
			outSound.SetActive (true);
			insideSound.SetActive (false);
			playVideo.SetActive (false);


		}
	}
}
