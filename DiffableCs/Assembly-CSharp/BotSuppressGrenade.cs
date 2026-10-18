//Type is in global namespace

public class BotSuppressGrenade : BotSuppressData
{
	[CompilerGenerated]
	private Action OnSupressComplete; //Field offset: 0x50

	public event Action OnSupressComplete
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public BotSuppressGrenade(BotOwner owner) { }

	public virtual void Activate() { }

	[CompilerGenerated]
	public void add_OnSupressComplete(Action value) { }

	public virtual void Dispose() { }

	public bool Init(EnemyInfo enemyToSuppress, Nullable grenadeType, CustomNavigationPoint posToDo, AIGreandeAng throwAngle = 3) { }

	public bool Init(EnemyInfo enemyToSuppress, CustomNavigationPoint fromCurPos, AIGreandeAng throwAngle = 3) { }

	public bool Init(Vector3 targetPosition, AIGreandeAng throwAngle = 3) { }

	private void OnGrenadeThrowComplete(ThrowWeap throwWeap) { }

	[CompilerGenerated]
	public void remove_OnSupressComplete(Action value) { }

}

