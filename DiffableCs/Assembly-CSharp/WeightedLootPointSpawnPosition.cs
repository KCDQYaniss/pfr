//Type is in global namespace

[GenerateBinarySerialization]
public sealed class WeightedLootPointSpawnPosition
{
	public string Name; //Field offset: 0x10
	public float Weight; //Field offset: 0x18
	public ClassVector3 Position; //Field offset: 0x20
	public ClassVector3 Rotation; //Field offset: 0x28

	public WeightedLootPointSpawnPosition() { }

	public WeightedLootPointSpawnPosition(Vector3 position, Vector3 rotationEuler, float weight, string name) { }

}

