using UnityEngine;
using System.Collections;
using ChimeraVirtualAds.API;
using ChimeraVirtualAds;

public class AdCreationScript : MonoBehaviour {
	private ImageTextureAd ad1;
	private bool isTextureApplied = false;
	// Use this for initialization
	void Start () {
		ad1 = new ImageTextureAd ("adid1");
		ad1.OnAdLoadFailed += HandleOnAdLoadFailed;
		ad1.OnAdLoaded += HandleOnAdLoaded;
		ad1.LoadAd ();
		AdManager.addImageTextureAd (ad1);
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
		AdManager.update ();
		if(!isTextureApplied && ad1.IsTextureGenerated())
		{
			isTextureApplied = true;
			GetComponent<Renderer>().material.mainTexture = ad1.GetTexture();
		}
	}
}
