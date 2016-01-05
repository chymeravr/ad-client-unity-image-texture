using System;
using co.chimeralabs.ads.managed;
using ChimeraVirtualAds.Internal;

namespace ChimeraVirtualAds.Implementation.Managed
{
	public class ImageTextureAdClient:IImageTextureAdClient, AdListener
	{
		private ImageTextureAdService adService;
		private IAdListener unityListener;
		private bool isAdLoaded = false;
		public ImageTextureAdClient(IAdListener adListener, String adId){
			this.unityListener = adListener;
			adService = new ImageTextureAdService (this, adId);
		}
		public void AddInstance(IAdInstance unityInstance){
			AdInstance instance = new AdInstance (unityInstance.GetInstanceId ());
		}
		public void LoadAd(){
			adService.LoadAd ();
		}
		public bool IsAdLoaded(){
			return isAdLoaded;
		}
		public byte[] getImageByteStream(){
			return adService.getImageData ();
		}
		public void OnAdLoadFailed(AdLoadFailedArgs args){
			unityListener.OnAdLoadFailed (args);
		}
		public void OnAdLoaded(System.Object context){
			this.isAdLoaded = true;
			unityListener.OnAdLoaded ();
		}
	}
}
