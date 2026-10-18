//Type is in global namespace

public class BotMinesData : BotData
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass56_0
	{
		public BotMinesData <>4__this; //Field offset: 0x10
		public AIMinePoint place; //Field offset: 0x18
		public AIMinePoint aiMinePoint; //Field offset: 0x20

		public <>c__DisplayClass56_0() { }

		internal void <DoPlant>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass58_0
	{
		public BotMinesData <>4__this; //Field offset: 0x10
		public AIMinePoint place; //Field offset: 0x18

		public <>c__DisplayClass58_0() { }

		internal void <PlantHereNow>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass60_0
	{
		public Vector3 p1; //Field offset: 0x10
		public Vector3 p2; //Field offset: 0x1C
		public BotMinesData <>4__this; //Field offset: 0x28

		public <>c__DisplayClass60_0() { }

		internal void <PlantHereNow>b__0(IResult result) { }

	}

	public const float SCLOSE_TO_MINE = 2.25; //Field offset: 0x0
	private const float SDIST_NOT_CLOSE_TO_ENEMY = 100; //Field offset: 0x0
	private const float DIST_NOT_CLOSE_TO_ENEMY = 10; //Field offset: 0x0
	private const float SDIST_BETWEEN_MINES = 100; //Field offset: 0x0
	private const float DIST_BETWEEN_MINES = 10; //Field offset: 0x0
	public BotMinesRealtimePlaceFinder MinesRealtimePlaceFinder; //Field offset: 0x18
	private HashSet _placesMineSetted; //Field offset: 0x20
	private HashSet _placesMineInfo; //Field offset: 0x28
	private List _placedMinesInfo; //Field offset: 0x30
	private int _maxMinesPerCach; //Field offset: 0x38
	[CompilerGenerated]
	private Action OnMinesStartCache; //Field offset: 0x40
	[CompilerGenerated]
	private Action OnMinesCacheCompleted; //Field offset: 0x48
	[CompilerGenerated]
	private Vector3 <LastCacheCenter>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private bool <Planting>k__BackingField; //Field offset: 0x5C
	private bool _haveUnplanted; //Field offset: 0x5D
	[CompilerGenerated]
	private AIMinePoint <LastPlanted>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private AIMinePoint <CurrentActive>k__BackingField; //Field offset: 0x68
	public float _lastPlantTime; //Field offset: 0x70
	private float _startPlaneTime; //Field offset: 0x74

	public event Action OnMinesCacheCompleted
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnMinesStartCache
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public private AIMinePoint CurrentActive
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public bool HaveUnplanted
	{
		 get { } //Length: 5
	}

	public private Vector3 LastCacheCenter
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public private AIMinePoint LastPlanted
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public float LastPlantTime
	{
		 get { } //Length: 6
	}

	public private bool Planting
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public BotMinesData(BotOwner owner) { }

	public void Activate() { }

	[CompilerGenerated]
	public void add_OnMinesCacheCompleted(Action value) { }

	[CompilerGenerated]
	public void add_OnMinesStartCache(Action value) { }

	private int ByPriority(AIMinePoint x, AIMinePoint y) { }

	public void CacheAllInRadius(Vector3 pos, float rad) { }

	public void ClearCache() { }

	public void Dispose() { }

	private void DoPlant(AIMinePoint place, ThrowWeap potentialGrenade) { }

	public AIMinePoint FindClosestsUnplanted(Vector3 pos) { }

	[CompilerGenerated]
	public AIMinePoint get_CurrentActive() { }

	public bool get_HaveUnplanted() { }

	[CompilerGenerated]
	public Vector3 get_LastCacheCenter() { }

	[CompilerGenerated]
	public AIMinePoint get_LastPlanted() { }

	public float get_LastPlantTime() { }

	[CompilerGenerated]
	public bool get_Planting() { }

	public AIMinePoint GetClosestsFromCache(Vector3 ownerPosition) { }

	public AIMinePoint GetClosestsPlanted(Vector3 position) { }

	public bool GetFirstFragGrenade(out ThrowWeap grenade) { }

	public bool GetFirstGrenade(ThrowWeapType throwType, out ThrowWeap grenade) { }

	public bool HaveAtCache() { }

	public bool IsPlanted(AIMinePoint closests) { }

	public void ManualUpdate() { }

	public void MinePlantedComplete(AIMinePoint point, bool succsec) { }

	public bool PlantHereNow(AIMinePoint place, ThrowWeapType throwType) { }

	public bool PlantHereNow(AIMinePoint place) { }

	public bool PlantHereNow(Vector3 p1, Vector3 p2, ThrowWeapType throwType) { }

	public bool PlantHereNow(Vector3 p1, Vector3 p2) { }

	[CompilerGenerated]
	public void remove_OnMinesCacheCompleted(Action value) { }

	[CompilerGenerated]
	public void remove_OnMinesStartCache(Action value) { }

	[CompilerGenerated]
	private void set_CurrentActive(AIMinePoint value) { }

	[CompilerGenerated]
	private void set_LastCacheCenter(Vector3 value) { }

	[CompilerGenerated]
	private void set_LastPlanted(AIMinePoint value) { }

	[CompilerGenerated]
	private void set_Planting(bool value) { }

	public void SetActive(AIMinePoint point) { }

	public void StartPlant(AIMinePoint place) { }

}

