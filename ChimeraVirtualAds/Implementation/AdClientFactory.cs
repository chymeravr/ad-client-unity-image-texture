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
using ChimeraVirtualAds.Internal;
using ChimeraVirtualAds.Implementation.Managed;
namespace ChimeraVirtualAds.Implementation
{
	public static class AdClientFactory
	{
		public static ImageTextureAdClient getImageTextureAdClient(IAdListener adListener, String adId){
			return new ImageTextureAdClient(adListener, adId);
		}
	}
}
