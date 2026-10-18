namespace EFT;

public sealed class ObjectsFactoryConfig
{
	private static ObjectsFactoryConfig _default; //Field offset: 0x0
	public static ObjectsFactoryConfig Zero; //Field offset: 0x8
	public readonly int AmmoPoolSize; //Field offset: 0x10
	public readonly int WeaponsPoolSize; //Field offset: 0x14
	public readonly int MagsPoolSize; //Field offset: 0x18
	public readonly int ItemsPoolSize; //Field offset: 0x1C
	public readonly int PlayersPoolSize; //Field offset: 0x20

	public static ObjectsFactoryConfig Default
	{
		 get { } //Length: 504
	}

	private static ObjectsFactoryConfig() { }

	public ObjectsFactoryConfig(int ammoPoolSize, int weaponsPoolSize, int magsPoolSize, int itemsPoolSize, int playersPoolSize) { }

	public static ObjectsFactoryConfig Create(int ammoPoolSize, int weaponsPoolSize, int magsPoolSize, int itemsPoolSize, int playersPoolSize) { }

	public static ObjectsFactoryConfig get_Default() { }

	public int GetPoolSizeForResourceType(ResourceType type) { }

}

