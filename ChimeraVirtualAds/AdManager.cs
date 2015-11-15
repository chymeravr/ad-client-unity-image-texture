//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using ChimeraVirtualAds.API;

namespace ChimeraVirtualAds
{
	public static class AdManager
	{
		private static Hashtable imageTextureAds = new Hashtable();
		private static bool isUpdateRequired = true;
		public static void addImageTextureAd(ImageTextureAd imageTextureAd){
			imageTextureAds.Add (imageTextureAd.GetAdId(), imageTextureAd);
			isUpdateRequired = true;
		}

		public static void addImageTextureInstance(String adId, String instanceName){
			ImageTextureAd ad = (ImageTextureAd)imageTextureAds[adId];
			//ad.addInstance (instanceName);
		}

		public static void start(){
		}

		public static void update() {
			if (!isUpdateRequired)
				return;
			isUpdateRequired = false;
			foreach (DictionaryEntry entry in imageTextureAds) {
				ImageTextureAd ad = (ImageTextureAd)entry.Value;
				if(!ad.IsTextureGenerated()){
					ad.GenerateTexture();
					isUpdateRequired = true;
				}
			}
		}
	}
}
