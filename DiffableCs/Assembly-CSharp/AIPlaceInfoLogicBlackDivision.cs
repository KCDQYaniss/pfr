//Type is in global namespace

public class AIPlaceInfoLogicBlackDivision : AIPlaceInfoLogic
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__8_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <Init>b__8_0(BotZone x) { }

	}

	private int _ownerId; //Field offset: 0x20
	private AIPlaceInfo _aiPlaceInfo; //Field offset: 0x28
	public List PossibleZones; //Field offset: 0x30
	private bool _checkZones; //Field offset: 0x38

	public int CoverAreaId
	{
		 get { } //Length: 26
	}

	public bool HaveOnwer
	{
		 get { } //Length: 8
	}

	public AIPlaceInfoLogicBlackDivision() { }

	public bool CanUse(BotOwner owner) { }

	public virtual void EditorCheck() { }

	public int get_CoverAreaId() { }

	public bool get_HaveOnwer() { }

	public virtual void Init(AIPlaceInfo aiPlaceInfo, BotsController botsController) { }

	private void OnDrawGizmosSelected() { }

	public void SetOwner(BotOwner owner) { }

}

