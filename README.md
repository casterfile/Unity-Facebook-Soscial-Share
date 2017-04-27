# Unity-Facebook-Soscial-Share
Developer: Anthony A. Castor

Software Requirment 
facebook-unity-sdk-7.9.0
Unity 5.6

--Online Portfolio </br>
Distribution itch(Web and Desktop): https://goo.gl/Wq1nuD </br>
Distribution Google Play: https://goo.gl/uKIIr4 </br>
Distribution Itunes AppStore: https://goo.gl/54yJPi </br>
Distribution Amazon Store: https://goo.gl/RUp1Od </br>
Distribution Windows Store: https://goo.gl/rCxsH6   (No Direct link to Dev Page) </br>
Distribution WearVR: https://goo.gl/y0X1nR  (No Direct link to Dev Page) </br>

--More Information and Demo Videos </br>
Facebook: https://goo.gl/vvDSIL </br>
Linkedin: https://goo.gl/c9Fh6n </br>
YouTube: https://goo.gl/BFZ7C5 </br>
StackOverFlow: https://goo.gl/J1hFqL </br>
Github: https://goo.gl/jPHFPe </br>



This Source does not give any warranty please use at your own risk </br>

This is a demo application for people who want to implement a facebook login and facebook share in their application. </br>

This application is free of virus or malware </br>


Functions </br>
Facebook Login </br>
Facebook Share </br>


#Source Code

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