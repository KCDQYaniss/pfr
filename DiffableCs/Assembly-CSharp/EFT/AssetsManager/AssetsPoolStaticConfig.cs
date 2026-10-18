namespace EFT.AssetsManager;

public class AssetsPoolStaticConfig
{
	internal struct ComponentConfig
	{
		public Type Type; //Field offset: 0x0
		public ResourceType ResourseTypeMask; //Field offset: 0x8
		public bool AddInLocalGame; //Field offset: 0xC
		public bool AddInOnlineGame; //Field offset: 0xD

		public bool Suited(ResourceType type, AssemblyType assemblyType) { }

	}

	public static ComponentConfig[] ComponentsToAdd; //Field offset: 0x0
	public static Dictionary AssetPoolObjectTypes; //Field offset: 0x8

	private static AssetsPoolStaticConfig() { }

	public AssetsPoolStaticConfig() { }

	public static Type GetAssetPoolObjectType(ResourceType resourceType) { }

	public static bool IsGameObjectActiveInPool(Type poolObjectType) { }

}

