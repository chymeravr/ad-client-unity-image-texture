using UnityEngine;
using System.Collections;
using ChimeraVirtualAds.API;
using ChimeraVirtualAds;

public class AdCreationScript : MonoBehaviour {
	public string adId;
	public string adInstanceId;
	private ImageTextureAd ad;
	private bool isTextureApplied = false;
	// Use this for initialization
	void Start () {
		ImageTextureAd imageTextureAd = AdManager.GetImageTextureAd (adId);
		if (imageTextureAd == null) {
			ad = new ImageTextureAd (adId);
			ad.OnAdLoadFailed += HandleOnAdLoadFailed;
			ad.OnAdLoaded += HandleOnAdLoaded;
			ad.LoadAd ();
			AdManager.AddImageTextureAd (ad);
		} else {
			ad = imageTextureAd;
		}
		AdInstance instance = new AdInstance (adInstanceId, gameObject);
		ad.AddInstance (instance);
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
		AdManager.Update ();
		if(!isTextureApplied && ad.IsTextureGenerated())
		{
			isTextureApplied = true;
		}
	}
}
