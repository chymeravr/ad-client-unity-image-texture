using System;
using UnityEngine;
using ChimeraVirtualAds.Internal;
using ChimeraVirtualAds.Implementation;

namespace ChimeraVirtualAds.API
{
	public class ImageTextureAd:IAdListener{
		private IImageTextureAdClient adClient;
		private String adId;
		private Texture2D tex;
		private bool isTextureGenerated = false;

		public event EventHandler<EventArgs> OnAdLoaded = delegate {};
		public event EventHandler<EventArgs> OnAdLoadFailed = delegate {};
		//public event EventHandler<EventArgs> OnAdInstanceCreated = delegate {};

		public ImageTextureAd(String adId){
			this.adClient = AdClientFactory.getImageTextureAdClient (this, adId);
			this.adId = adId;
		}

		public void LoadAd(){
			this.adClient.LoadAd ();
		}

		public bool IsAdLoaded(){
			return this.adClient.IsAdLoaded ();
		}

		public String GetAdId(){
			return this.adId;
		}

		public Texture2D GetTexture(){
			return tex;
		}

		public void GenerateTexture(){
			if (!adClient.IsAdLoaded ())
				return;
			tex = new Texture2D (2, 2);
			tex.LoadImage (adClient.getImageByteStream ());
			isTextureGenerated = true;
		}

		public bool IsTextureGenerated(){
			return isTextureGenerated;
		}

		#region IAdListener Implementation
		void IAdListener.OnAdLoaded(){
			OnAdLoaded (this, EventArgs.Empty);
		}

		void IAdListener.OnAdLoadFailed(EventArgs args){
			OnAdLoadFailed (this, args);
		}

		//void IAdListener.OnAdInstanceCreated(){
		//	OnAdInstanceCreated (this, EventArgs.Empty);
		//}
		#endregion
	}
}