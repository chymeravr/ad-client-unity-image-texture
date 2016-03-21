using UnityEngine;
using System.Collections;
using ChimeraVirtualAds;
using UnityEngine.VR;

public class AdCreationScript : MonoBehaviour {
	public string adUnitId;
	public string adInstanceId;
	public int nDistinctAds = 1;
	private ImageTextureAdInstanceUnity instance;
	private bool isAdReady = false;
	private bool isAdDisplayed = false;
	// Use this for initialization
	void Awake () {
		instance = new ImageTextureAdInstanceUnity (gameObject, Camera.main, this.adUnitId, this.adInstanceId);
		instance.OnAdLoaded += HandleOnAdLoaded;
		instance.OnAdLoadFailed += HandleOnAdLoadFailed;
		AdManager.RegisterImageTextureAdUnit (instance, nDistinctAds);
	}
	
	void Start(){
		instance.Update ();
	}
	
	void HandleOnAdLoaded (object sender, System.EventArgs e)
	{
		isAdReady = true;
		Debug.Log ("OnAdLoaded");
	}
	
	void HandleOnAdLoadFailed (object sender, System.EventArgs e)
	{
		co.chimeralabs.ads.managed.AdUnitFailedArgs args = (co.chimeralabs.ads.managed.AdUnitFailedArgs) e;
		if (args.errorCode == co.chimeralabs.ads.managed.AdUnitFailedArgs.ErrorCode.FEW_ADS_LOADED) {
			Debug.Log ("(AdUnit:"+args.adUnitId+")Few ads Loaded. Error Message " + args.errorMessage);
		}else if (args.errorCode == co.chimeralabs.ads.managed.AdUnitFailedArgs.ErrorCode.NO_AD_LOADED) {
			Debug.Log ("(AdUnit:"+args.adUnitId+")No ad Loaded. Error Message:" + args.errorMessage);
		}
	}
	
	// Update is called once per frame
	void Update () {
		instance.Update ();
	}
}
