//Type is in global namespace

public class BotCalledData : BotData
{
	private bool _called; //Field offset: 0x18
	private BotOwner _caller; //Field offset: 0x20
	private bool _helpOnlyWithEnemy; //Field offset: 0x28
	[CompilerGenerated]
	private CallEnemyTargetInfo <Target>k__BackingField; //Field offset: 0x30

	public bool CallerGroupHaveEnemy
	{
		 get { } //Length: 281
	}

	public Vector3 CallerPosition
	{
		 get { } //Length: 95
	}

	public bool MayUse
	{
		 get { } //Length: 75
	}

	public private CallEnemyTargetInfo Target
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public int TargetEnvId
	{
		 get { } //Length: 26
	}

	public BotCalledData(BotOwner owner) { }

	public void Dispose() { }

	public bool get_CallerGroupHaveEnemy() { }

	public Vector3 get_CallerPosition() { }

	public bool get_MayUse() { }

	[CompilerGenerated]
	public CallEnemyTargetInfo get_Target() { }

	public int get_TargetEnvId() { }

	private void OnBotStateChange(EBotState obj) { }

	private void OnEnemyAdd(IPlayer callerEnemy) { }

	[CompilerGenerated]
	private void set_Target(CallEnemyTargetInfo value) { }

	public void SetOff() { }

	public bool ShouldComeNeartarget() { }

	public bool TryCall(CallEnemyTargetInfo trg, BotOwner caller, bool helpOnlyWithEnemy = true) { }

	public bool TryGetPriorityEnemyPosition(out Vector3 position, out int idEnv) { }

}

