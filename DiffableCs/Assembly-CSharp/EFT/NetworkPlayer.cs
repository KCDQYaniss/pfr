namespace EFT;

public abstract class NetworkPlayer : Player
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__17_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal Item <ProcessPoisonResourceChange>b__17_0(Slot slot) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public string id; //Field offset: 0x10

		public <>c__DisplayClass17_0() { }

		internal bool <ProcessPoisonResourceChange>b__1(Item item) { }

		internal bool <ProcessPoisonResourceChange>b__2(Item item) { }

	}

	internal struct ClientShot
	{
		public bool Approved; //Field offset: 0x0
		public int BodyPart; //Field offset: 0x4
		public float Damage; //Field offset: 0x8
		public float LeftBodyPartHealth; //Field offset: 0xC
		public string TargetName; //Field offset: 0x10

		public virtual string ToString() { }

	}

	public static readonly EPhraseTrigger[] LocalPhrases; //Field offset: 0x0
	[CompilerGenerated]
	private bool <IsVisible>k__BackingField; //Field offset: 0xC88
	[CompilerGenerated]
	private IFrameIndexer <FrameIndexer>k__BackingField; //Field offset: 0xC90

	protected private IFrameIndexer FrameIndexer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public virtual AbstractHandsController HandsController
	{
		 get { } //Length: 8
		 set { } //Length: 18
	}

	internal abstract PlayerInventoryController InventoryController
	{
		internal get { } //Length: 0
	}

	public virtual bool IsVisible
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	private static NetworkPlayer() { }

	protected NetworkPlayer() { }

	internal static T CreateNetworkPlayer(GameWorld gameWorld, ResourceKey assetName, int playerId, Vector3 position, string prefix, IFrameIndexer frameIndexer, EUpdateQueue updateQueue, EUpdateMode armsUpdateMode, EUpdateMode bodyUpdateMode, Mode characterControllerMode, Func getSensitivity, Func getAimingSensitivity, bool isThirdPerson, bool useSimplifiedSkeleton = false) { }

	public virtual void Dispose() { }

	[CompilerGenerated]
	protected IFrameIndexer get_FrameIndexer() { }

	public virtual AbstractHandsController get_HandsController() { }

	internal abstract PlayerInventoryController get_InventoryController() { }

	[CompilerGenerated]
	public virtual bool get_IsVisible() { }

	public virtual void OnDeserializeFromServer(byte channelId, IBitReaderStream reader) { }

	protected void ProcessArmorPointsChange(string id, float value) { }

	protected void ProcessChangeMasteringExperience(Nullable packet, bool silent) { }

	protected void ProcessChangeSkillExperience(Nullable packet, bool silent) { }

	protected void ProcessPoisonResourceChange(string id, float value) { }

	[CompilerGenerated]
	private void set_FrameIndexer(IFrameIndexer value) { }

	protected virtual void set_HandsController(AbstractHandsController value) { }

	[CompilerGenerated]
	public virtual void set_IsVisible(bool value) { }

}

