//Type is in global namespace

public abstract class AbstractSuppressStationary : BotData
{
	private readonly BotSuppressStationary _suppressStationary; //Field offset: 0x18
	[CompilerGenerated]
	private float <EndSuppressTime>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private float <StartArtSupress>k__BackingField; //Field offset: 0x24

	public private float EndSuppressTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public bool IsInProcess
	{
		 get { } //Length: 90
	}

	public private float StartArtSupress
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public abstract bool Usable
	{
		 get { } //Length: 0
	}

	protected AbstractSuppressStationary(BotSuppressStationary suppressStationary, BotOwner bot) { }

	public abstract bool CanStartSuppressAt(Vector3 enemyPos) { }

	public abstract bool CanStartSupressEnemy(EnemyInfo memoryGoalEnemy) { }

	[CompilerGenerated]
	public float get_EndSuppressTime() { }

	public bool get_IsInProcess() { }

	[CompilerGenerated]
	public float get_StartArtSupress() { }

	public abstract bool get_Usable() { }

	public bool IsAtSector(Vector3 point) { }

	public override bool IsReady() { }

	[CompilerGenerated]
	private void set_EndSuppressTime(float value) { }

	[CompilerGenerated]
	private void set_StartArtSupress(float value) { }

	public void SetPeriod(float sec) { }

	protected void Stop() { }

	public abstract void StopExternal(Vector3 badPos) { }

}

