using System;
namespace ChimeraVirtualAds.Internal
{
	public interface IImageTextureAdClient
	{
		void LoadAd();
		bool IsAdLoaded();
		byte[] getImageByteStream();
	}
}

