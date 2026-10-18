//Type is in global namespace

public class BewareArtillery : BotData
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__7_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <CalcAndSetCover>b__7_0(GroupPoint point) { }

	}

	private const string LOG_TAG = "beware_art_node"; //Field offset: 0x0
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"nextCheck", "lastResult"})]
	private ValueTuple _lineCastResult; //Field offset: 0x18
	private bool _lastSafeResult; //Field offset: 0x20
	private float _coverSaveAndHasPathLastCheckTime; //Field offset: 0x24
	private float _lastFindNewCoverTime; //Field offset: 0x28

	public BewareArtillery(BotOwner owner) { }

	private void CalcAndSetCover() { }

	public bool IsCoverSafe(CustomNavigationPoint cover) { }

	public void UpdateByNode() { }

}

