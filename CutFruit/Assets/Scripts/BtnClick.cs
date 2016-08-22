using UnityEngine;
using System.Collections;

public class BtnClick : MonoBehaviour {

	public Sprite Sound1;
	public Sprite Sound2;

	private bool isPlayBg = false;

//	// Use this for initialization
//	void Start () {
//	
//	}
//	
//	// Update is called once per frame
//	void Update () {
//	
//	}

	void OnClick() {
		if (name == "play") { 
//			SceneManager.LoadScene("play");
			Application.LoadLevel ("play");
		} else if (name == "credits") {
			Application.OpenURL("http://www.baidu.com");
		} else if (name == "more") {
			Application.OpenURL("http://www.youku.com");
		} else if (name == "sound") {
			if (isPlayBg) {
				GetComponent<SpriteRenderer> ().sprite = Sound2;
				Camera.main.GetComponent<AudioSource>().Stop();
				isPlayBg = false;
			} else {
				GetComponent<SpriteRenderer> ().sprite = Sound1;
				Camera.main.GetComponent<AudioSource>().Play();
				isPlayBg = true;
			}
		} 
	}
}