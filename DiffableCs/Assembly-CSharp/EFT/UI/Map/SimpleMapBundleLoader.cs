namespace EFT.UI.Map;

public class SimpleMapBundleLoader : IPocketMapBundleLoader
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__6_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__6_0(PocketMapConfig <p0>) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public SimpleMapBundleLoader <>4__this; //Field offset: 0x10
		public LoadingBundle loadingBundle; //Field offset: 0x18

		public <>c__DisplayClass7_0() { }

		internal void <RequestBundle>b__0() { }

	}

	internal class LoadingBundle
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			public LoadingBundle <>4__this; //Field offset: 0x10
			public string bundleName; //Field offset: 0x18
			public Action loadedMap; //Field offset: 0x20

			public <>c__DisplayClass3_0() { }

			internal void <Load>b__0() { }

		}

		public PocketMapConfig pocketMapConfig; //Field offset: 0x10
		public CancellationTokenSource loadingCancellation; //Field offset: 0x18
		public Token currentMapToken; //Field offset: 0x20

		public LoadingBundle() { }

		public void CancelAndRelease() { }

		public void Load(string bundleName, Action loadedMap) { }

	}

	[CompilerGenerated]
	private Action BundleReceived; //Field offset: 0x10
	private string _mapBundleName; //Field offset: 0x18
	private List _loadingPresets; //Field offset: 0x20

	public override event Action BundleReceived
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public SimpleMapBundleLoader(string mapBundleBundleName) { }

	[CompilerGenerated]
	public override void add_BundleReceived(Action value) { }

	[CompilerGenerated]
	public override void remove_BundleReceived(Action value) { }

	public override void RequestBundle(int scalePreset) { }

	public void UnloadMapBundle() { }

}

