namespace EFT.Hideout;

public sealed class HideoutAreaStashAdditionalInfo : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static UnityAction <>9__3_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <SetupExternalObtainButton>b__3_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public int availableLinesCount; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal void <SetupExternalObtainButton>b__1() { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static UnityAction <0>__CloseTooltip; //Field offset: 0x0
		public static UnityAction <1>__ExternalObtainButtonClickHandler; //Field offset: 0x8

	}

	[SerializeField]
	private DefaultUIButton _externalObtainButton; //Field offset: 0x70

	public HideoutAreaStashAdditionalInfo() { }

	public virtual void Close() { }

	private static void ExternalObtainButtonClickHandler() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void SetupExternalObtainButton() { }

	private static bool TryGetLobbyStash(out Stash stash) { }

}

