using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Facebook.Unity;
using Facebook.Unity.Example;
using UnityEngine.UI;


public class FBShareScreenShotTest : MonoBehaviour {

	public void ShareScreenShot(){
		Debug.Log ("SHARE");
		//ShareScoreOnFB();
		FB.ShareLink(
			new Uri("https://play.google.com/store/apps/developer?id=Jason%20Ledesma&hl=en"),
			"Rebisco",
			"Lets have a great adventure.",
			new Uri("http://immersivemedia.ph/rebiscodb/Artifact/Artifact_Jar.jpg"),
			callback: ShareCallback);
	}


	private void ShareCallback (IShareResult result) {
		if (result.Cancelled || !String.IsNullOrEmpty(result.Error)) {
			Debug.Log("ShareLink Error: "+result.Error);
		} else if (!String.IsNullOrEmpty(result.PostId)) {
			// Print post identifier of the shared content
			Debug.Log(result.PostId);
		} else {
			// Share succeeded without postID
			Debug.Log("ShareLink success!");

		}
	}

}

