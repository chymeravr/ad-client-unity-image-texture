using System;
namespace ChimeraVirtualAds.Internal
{
	public interface IImageTextureAdClient
	{
		void LoadAd();
		void AddInstance(IAdInstance instance);
		bool IsAdLoaded();
		byte[] getImageByteStream();
	}
}

