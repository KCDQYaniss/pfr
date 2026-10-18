namespace EFT;

[Extension]
public static class DestroyedItemExtensions
{

	[Extension]
	public static DestroyedItem ReadDestroyedItem(NetworkReader reader) { }

	[Extension]
	public static void WriteDestroyedItem(NetworkWriter writer, DestroyedItem target) { }

}

