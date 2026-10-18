namespace JsonType;

public struct ResourceTypeInfo
{
	public ResourceType ResourceType; //Field offset: 0x0
	[CanBeNull]
	public ItemTemplate ItemTemplate; //Field offset: 0x8

	public static ResourceTypeInfo Other
	{
		 get { } //Length: 16
	}

	public static ResourceTypeInfo Player
	{
		 get { } //Length: 16
	}

	public static ResourceTypeInfo SynchronizableObject
	{
		 get { } //Length: 16
	}

	public ResourceTypeInfo(ResourceType resourceType, ItemTemplate itemTemplate) { }

	public static ResourceTypeInfo get_Other() { }

	public static ResourceTypeInfo get_Player() { }

	public static ResourceTypeInfo get_SynchronizableObject() { }

}

