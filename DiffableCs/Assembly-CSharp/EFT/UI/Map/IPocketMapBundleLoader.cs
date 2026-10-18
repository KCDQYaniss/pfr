namespace EFT.UI.Map;

public interface IPocketMapBundleLoader
{

	public event Action BundleReceived
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	public void add_BundleReceived(Action value) { }

	[CompilerGenerated]
	public void remove_BundleReceived(Action value) { }

	public void RequestBundle(int scaleVariant) { }

}

