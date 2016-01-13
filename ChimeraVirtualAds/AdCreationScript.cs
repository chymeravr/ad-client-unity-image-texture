using UnityEngine;
using System.Collections;
using ChimeraVirtualAds.API;
using ChimeraVirtualAds;
using UnityEngine.VR;

public class AdCreationScript : MonoBehaviour {
	public string adId;
	public string adInstanceId;
	private ImageTextureAd ad;
	private AdInstance instance;

	// Use this for initialization
	void Awake () {
		ImageTextureAd tempAdObject = AdManager.GetImageTextureAd (adId);
		if (tempAdObject == null) {
			ad = new ImageTextureAd (adId);
			ad.OnAdLoadFailed += HandleOnAdLoadFailed;
			ad.OnAdLoaded += HandleOnAdLoaded;
			ad.LoadAd ();
			AdManager.AddImageTextureAd (ad);
		} else {
			ad = tempAdObject;
		}
		instance = ad.CreateInstance (adInstanceId, gameObject, Camera.main);
	}

	void Start(){
		AdManager.Update (instance);
	}

	void HandleOnAdLoaded (object sender, System.EventArgs e)
	{
		Debug.Log ("OnAdLoaded");
	}

	void HandleOnAdLoadFailed (object sender, System.EventArgs e)
	{
		co.chimeralabs.ads.managed.AdLoadFailedArgs args = (co.chimeralabs.ads.managed.AdLoadFailedArgs) e;
		Debug.Log ("OnAdLoadFailed" + args.getErrorMessage());
	}

	// Update is called once per frame
	void Update () {
		AdManager.Update (instance);
	}
}
