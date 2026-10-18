namespace EFT.Game.Spawning;

public sealed class SpawnColliderParamsSerializer : PolymorphicSerializer
{
	private readonly List _types; //Field offset: 0x20

	public SpawnColliderParamsSerializer() { }

	protected virtual Type KeyToType(string serializedType) { }

	protected virtual string TypeToKey(Type serializedType) { }

}

