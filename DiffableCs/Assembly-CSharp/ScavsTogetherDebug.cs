//Type is in global namespace

public class ScavsTogetherDebug
{
	internal class ScavsTogetherDebugPointCheck
	{
		private readonly ISpawnPoint _spawnPoint; //Field offset: 0x10
		[CompilerGenerated]
		private bool <NotOccupied>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private float <SDist>k__BackingField; //Field offset: 0x1C

		public bool NotOccupied
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public float SDist
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			 set { } //Length: 6
		}

		public ScavsTogetherDebugPointCheck(ISpawnPoint spawnPoint) { }

		public StringBuilder DebugInfo() { }

		[CompilerGenerated]
		public bool get_NotOccupied() { }

		[CompilerGenerated]
		public float get_SDist() { }

		[CompilerGenerated]
		public void set_NotOccupied(bool value) { }

		[CompilerGenerated]
		public void set_SDist(float value) { }

	}

	public bool Inited; //Field offset: 0x10
	private ISpawnPoint _groupPlayerIsNullISpawnPoint; //Field offset: 0x18
	private Nullable _groupCenter; //Field offset: 0x20
	private readonly List _pointChecks; //Field offset: 0x30
	private ScavsTogetherDebugPointCheck _curPointToCheck; //Field offset: 0x38
	private ISpawnPoint _closest; //Field offset: 0x40
	private float ClosesttmpDist; //Field offset: 0x48

	public ScavsTogetherDebug() { }

	public void CheckValidPoints(ISpawnPoint validPoint) { }

	public void CheckValidPointsIsOccupied(bool notOccupied) { }

	public void CheckValidPointsSDist(float sDist) { }

	public StringBuilder DebugInfo() { }

	public void GroupPlayerIsNull(ISpawnPoint spawnPoint) { }

	public void SetClosest(ISpawnPoint closest, float tmpDist) { }

	public void SetGroupCenter(Vector3 groupCenter) { }

}

