using UnityEngine;
using System.Collections;
using System.Net;
using System;

public class WebClientTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//WebClient webClient = new WebClient ();
		Debug.Log ("sushil01");
		//System.Net.WebClient webClient = new System.Net.WebClient ();
		//MyWebClient webClient = new MyWebClient ();
		Uri uri = new Uri ("http://localhost:8080/virtualadserver/");
		//webClient.DownloadDataAsync (uri);
		//webClient.DownloadStringAsync (uri);
		//ImageTextureAdClient adClient = new ImageTextureAdClient ("asdfsa");
		//adClient.LoadAd ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

/*public class MyWebClient : System.Net.WebClient{
	protected override void OnDownloadDataCompleted(DownloadDataCompletedEventArgs e){
		Debug.Log ("ondownloaddatacompleted");
		base.OnDownloadDataCompleted (e);
		byte[] result = e.Result;
		Debug.Log("Result");
		Debug.Log ("sushil");
	}
	protected override void OnDownloadStringCompleted(DownloadStringCompletedEventArgs e){
		Debug.Log ("OnDownloadSringCompleted");
		base.OnDownloadStringCompleted (e);
		Debug.Log ("Result:" + e.Result);
		Metadata deserialized = Newtonsoft.Json.JsonConvert.DeserializeObject<Metadata> (e.Result);
		Debug.Log ("resourceUrl" + deserialized.resourceUrl + "resourceErrorCode" + deserialized.resourceErrorCode);
	}
}

public class Metadata{
	public String resourceUrl;
	public String resourceMetadata;
	public int resourceErrorCode;
}*/