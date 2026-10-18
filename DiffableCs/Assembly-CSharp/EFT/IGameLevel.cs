namespace EFT;

public interface IGameLevel
{

	public event Action OnLootItemDestroyed
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public GrenadeFactory GrenadeFactory
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnLootItemDestroyed(Action value) { }

	public IBallisticsCalculator CreateBallisticCalculator(int seed) { }

	public void DestroyLoot(string id) { }

	public GrenadeFactory get_GrenadeFactory() { }

	public void PlantTripwire(Item grenade, int playerRaidId, Vector3 fromPosition, Vector3 toPosition) { }

	public void RegisterGrenade(Throwable grenade) { }

	[CompilerGenerated]
	public void remove_OnLootItemDestroyed(Action value) { }

	public void RemoveBallisticCalculator(Item weapon) { }

	public LootItem SetupItem(Item item, IPlayer player, Vector3 position, Quaternion rotation) { }

	public LootItem ThrowItem(Item item, IPlayer player, Nullable fwd) { }

	public void UnregisterGrenade(string id) { }

}

