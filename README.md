# Unity-Facebook-Soscial-Share
Developer: Anthony A. Castor

This Source does not give any warranty please use at your own risk </br>

This is a demo application for people who want to implement a facebook login and facebook share in their application. </br>

This application is free of virus or malware </br>

<h3>Software Requirment </h3>
facebook-unity-sdk-7.9.0<br/>
Unity 5.6<br/>
Unity C#<br/>

<h3>Online Portfolio</h3>
Distribution itch(Web and Desktop): https://goo.gl/Wq1nuD </br>
Distribution Google Play: https://goo.gl/uKIIr4 </br>
Distribution Itunes AppStore: https://goo.gl/54yJPi </br>
Distribution Amazon Store: https://goo.gl/RUp1Od </br>
Distribution Windows Store: https://goo.gl/rCxsH6   (No Direct link to Dev Page) </br>
Distribution WearVR: https://goo.gl/y0X1nR  (No Direct link to Dev Page) </br>

<h3>More Information and Demo Videos </h3>
Facebook: https://goo.gl/vvDSIL </br>
Linkedin: https://goo.gl/c9Fh6n </br>
YouTube: https://goo.gl/BFZ7C5 </br>
StackOverFlow: https://goo.gl/J1hFqL </br>
Github: https://goo.gl/jPHFPe </br>


<h3>Application Functions</h3>
Facebook Login </br>
Facebook Share </br>


<h3>Source Code</h3>

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

<h3>Screenshot</h3>

![alt text](screenshots/1.png "Scene1")
![alt text](screenshots/2.png "Scene2")
![alt text](screenshots/3.png "Scene3")
![alt text](screenshots/4.png "Scene4")