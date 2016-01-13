using System;
using UnityEngine;
using System.Collections;
using co.chimeralabs.ads.managed;

public class ControllingBox : MonoBehaviour, AdListener {
    public string url = "http://images.earthcam.com/ec_metros/ourcams/fridays.jpg";
    public string url1 = "https://fbcdn-profile-a.akamaihd.net/hprofile-ak-xaf1/v/t1.0-1/c36.0.160.160/p160x160/10245558_984698391554833_6578971494841583883_n.jpg?oh=67f1852b3168c8ee0c5003c50c13ef03&oe=56CF4495&__gda__=1456533907_8af054b1185d234c871d6f52001e843a";
    public string myname;
    private Transform transform;
	private Renderer rendererObject;
	private Texture2D tex;
	private bool isImageLoaded = false;
	ImageTextureAd adClient;
	// Use this for initialization
    /*IEnumerator Start()
    {
        Name name = new Name();
        Debug.Log("At Update function" + name.getName());
        transform = GetComponent<Transform>();
        WWW www = new WWW(url);
        yield return www;
        Renderer renderer = GetComponent<Renderer>();	
        renderer.material.mainTexture = www.texture;
    }*/
	void Start(){
		tex = new Texture2D (2, 2);
		adClient = new ImageTextureAd (this, "asdfds");
		adClient.LoadAd ();
		rendererObject = GetComponent<Renderer> ();
	}
    // Update is called once per frame
    void Update () {
        //Vector3 vec = new Vector3(0.0f, 1.0f, 0.0f);
        //transform.Rotate(vec, 1);
		if (isImageLoaded == true) {
			isImageLoaded = false;
			tex.LoadImage (adClient.getImageData());
			rendererObject.material.mainTexture = tex;
		}
    }

	public void OnAdLoadFailed(AdLoadFailedArgs args){
	}
	public void OnAdLoaded(System.Object context){
		//ImageTextureAdClient client = (ImageTextureAdClient)context;
		//String test = "test";
		//byte[] data = client.getImageData();
		isImageLoaded = true;

		//var tex = new Texture2D (2, 2);
		//tex.LoadImage (data);

		//GetComponent<Renderer> ().material.mainTexture = tex;
	}
	
	/*public class AdListenerImpl:AdListener{
		void OnAdLoadFailed(AdLoadFailedArgs args){
		}
		void OnAdLoaded(Object context){
			ImageTextureAdClient client = (ImageTextureAdClient)context;
			String test = "test";
			byte[] data = client.getImageData();

			var tex = new Texture2D (2, 2);
			tex.LoadImage (data);
		}
	}*/
}
