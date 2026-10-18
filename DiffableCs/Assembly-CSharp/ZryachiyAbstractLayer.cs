//Type is in global namespace

public abstract class ZryachiyAbstractLayer : ZryachiyBaseLayer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__12_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <ApplyShot>b__12_0(BodyPartCollider x) { }

	}

	private const int SHOOT_TO_KILL = 4; //Field offset: 0x0
	private const int SHOT_DIST_TO_APPLY_SHOT = 4; //Field offset: 0x0
	private AIPlaceInfoLogicZryachiy _placeForCover; //Field offset: 0x98
	private readonly Dictionary _enemiesShoots; //Field offset: 0xA0
	[CompilerGenerated]
	private Nullable <_placeInfo>k__BackingField; //Field offset: 0xA8

	protected private Nullable _placeInfo
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private float PossibleFogToTp
	{
		private get { } //Length: 58
	}

	public float SECONDS_CAN_TELERORT
	{
		 get { } //Length: 58
	}

	protected ZryachiyAbstractLayer(BotOwner bot, int priority) { }

	[CompilerGenerated]
	private bool <.ctor>g__FindArea|10_0(AIPlaceInfoLogicZryachiy infoLogicZryachiy, AIPlaceInfo aiPlaceInfo) { }

	protected void ApplyShot(Player player, bool lethal) { }

	protected bool CanTeleport() { }

	public virtual void Dispose() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	protected bool FogIsOk() { }

	[CompilerGenerated]
	protected Nullable get__placeInfo() { }

	private float get_PossibleFogToTp() { }

	public float get_SECONDS_CAN_TELERORT() { }

	private void OnTriggerPressed() { }

	[CompilerGenerated]
	private void set__placeInfo(Nullable value) { }

}

