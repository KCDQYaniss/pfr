namespace EFT.Game.Spawning;

public class SpawnPoint : ISpawnPoint, IPositionPoint
{
	public string Id; //Field offset: 0x10
	public string Name; //Field offset: 0x18
	public Vector3 Position; //Field offset: 0x20
	public Quaternion Rotation; //Field offset: 0x2C
	public EPlayerSideMask Sides; //Field offset: 0x3C
	public ESpawnCategoryMask Categories; //Field offset: 0x40
	public string Infiltration; //Field offset: 0x48
	public BotZone BotZone; //Field offset: 0x50
	public float DelayToCanSpawnSec; //Field offset: 0x58
	public int CorePointId; //Field offset: 0x5C
	[CompilerGenerated]
	private ISpawnPointCollider <Collider>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private bool <SpawnBlocked>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private float <NextBornTime>k__BackingField; //Field offset: 0x6C
	private int _lastNearestPlayerId; //Field offset: 0x70
	private int _nearestPlayerSeries; //Field offset: 0x74
	private float lockSpawnStartTime; //Field offset: 0x78
	private float lockSpawnStepTime; //Field offset: 0x7C
	private float lockSpawnCheckRadiusSqr; //Field offset: 0x80
	private bool _runtimeConstantsInited; //Field offset: 0x84

	public string BotZoneName
	{
		 get { } //Length: 257
	}

	public override ISpawnPointCollider Collider
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	private override string EFT.Game.Spawning.ISpawnPoint.BotZoneName
	{
		private get { } //Length: 235
	}

	private override ESpawnCategoryMask EFT.Game.Spawning.ISpawnPoint.Categories
	{
		private get { } //Length: 4
	}

	private override int EFT.Game.Spawning.ISpawnPoint.CorePointId
	{
		private get { } //Length: 4
		private set { } //Length: 4
	}

	private override float EFT.Game.Spawning.ISpawnPoint.DelayToCanSpawnSec
	{
		private get { } //Length: 6
	}

	private override string EFT.Game.Spawning.ISpawnPoint.Id
	{
		private get { } //Length: 5
	}

	private override string EFT.Game.Spawning.ISpawnPoint.Infiltration
	{
		private get { } //Length: 5
	}

	private override bool EFT.Game.Spawning.ISpawnPoint.IsSnipeZone
	{
		private get { } //Length: 233
	}

	private override string EFT.Game.Spawning.ISpawnPoint.Name
	{
		private get { } //Length: 5
	}

	private override Vector3 EFT.Game.Spawning.ISpawnPoint.Position
	{
		private get { } //Length: 19
	}

	private override Quaternion EFT.Game.Spawning.ISpawnPoint.Rotation
	{
		private get { } //Length: 11
	}

	private override EPlayerSideMask EFT.Game.Spawning.ISpawnPoint.Sides
	{
		private get { } //Length: 4
	}

	private override Vector3 IPositionPoint.Position
	{
		private get { } //Length: 19
	}

	public override float NextBornTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public override bool SpawnBlocked
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public SpawnPoint() { }

	public override float CalcMultiSpawnDelay(float additionalDelay, BotCreationData creationData) { }

	public override void Dispose() { }

	private override string EFT.Game.Spawning.ISpawnPoint.get_BotZoneName() { }

	private override ESpawnCategoryMask EFT.Game.Spawning.ISpawnPoint.get_Categories() { }

	private override int EFT.Game.Spawning.ISpawnPoint.get_CorePointId() { }

	private override float EFT.Game.Spawning.ISpawnPoint.get_DelayToCanSpawnSec() { }

	private override string EFT.Game.Spawning.ISpawnPoint.get_Id() { }

	private override string EFT.Game.Spawning.ISpawnPoint.get_Infiltration() { }

	private override bool EFT.Game.Spawning.ISpawnPoint.get_IsSnipeZone() { }

	private override string EFT.Game.Spawning.ISpawnPoint.get_Name() { }

	private override Vector3 EFT.Game.Spawning.ISpawnPoint.get_Position() { }

	private override Quaternion EFT.Game.Spawning.ISpawnPoint.get_Rotation() { }

	private override EPlayerSideMask EFT.Game.Spawning.ISpawnPoint.get_Sides() { }

	private override void EFT.Game.Spawning.ISpawnPoint.set_CorePointId(int value) { }

	public string get_BotZoneName() { }

	[CompilerGenerated]
	public override ISpawnPointCollider get_Collider() { }

	[CompilerGenerated]
	public override float get_NextBornTime() { }

	[CompilerGenerated]
	public override bool get_SpawnBlocked() { }

	private Player GetNearestPlayer() { }

	public override void IncreaseUsedPlayerSpawnsForNearestPlayer(BotCreationData creationData) { }

	private override Vector3 IPositionPoint.get_Position() { }

	public override bool IsInPlayersIndividualLimits(BotCreationData creationData) { }

	public override bool IsNotCollidedArtillery(ArtilleryShellingControllerServer artilleryShelling) { }

	[CompilerGenerated]
	public void set_Collider(ISpawnPointCollider value) { }

	[CompilerGenerated]
	public override void set_NextBornTime(float value) { }

	[CompilerGenerated]
	public override void set_SpawnBlocked(bool value) { }

	private void TryInitRuntimeConstants() { }

}

