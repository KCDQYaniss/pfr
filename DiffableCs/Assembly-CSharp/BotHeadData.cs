//Type is in global namespace

public class BotHeadData : BotData
{
	private enum EBotHeadDirection
	{
		Turn = 0,
		LookStraight = 1,
	}

	private enum EHeadState
	{
		Disabled = 0,
		Patrol = 1,
		EnemyVisibility = 2,
	}

	[CompilerGenerated]
	private EHeadState <State>k__BackingField; //Field offset: 0x18
	private float _rotationSpeed; //Field offset: 0x1C
	private float _targetHorizontalRotation; //Field offset: 0x20
	private EBotHeadDirection _dirType; //Field offset: 0x24
	private float _nextHeadChange; //Field offset: 0x28
	private float _updatePointTimer; //Field offset: 0x2C

	private float CurrentHorizontalRotation
	{
		private get { } //Length: 43
	}

	private BotGlobalPatrolSettings PatrolSettings
	{
		private get { } //Length: 45
	}

	private EHeadState State
	{
		[CompilerGenerated]
		private get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public BotHeadData(BotOwner owner) { }

	private void EnterEnemyVisibilityState() { }

	private void EnterPatrolState() { }

	private float get_CurrentHorizontalRotation() { }

	private BotGlobalPatrolSettings get_PatrolSettings() { }

	[CompilerGenerated]
	private EHeadState get_State() { }

	public void ManualUpdate() { }

	[CompilerGenerated]
	private void set_State(EHeadState value) { }

	private void SetTargetLookPosition(Vector3 target) { }

	private void TryChangeState(EHeadState newState) { }

	private void UpdateDisabledState() { }

	private void UpdateEnemyVisibilityState() { }

	private void UpdateHeadRotation() { }

	private void UpdatePatrolState() { }

	private void UpdateStates() { }

}

