//Type is in global namespace

public class ItemSounds : ScriptableObject
{
	internal class ClipsByEInventorySoundType
	{
		public AudioClip[] Clips; //Field offset: 0x10

		public ClipsByEInventorySoundType() { }

	}

	public ClipsByEInventorySoundType[] Clips; //Field offset: 0x18
	public AudioClip[] LootingClips; //Field offset: 0x20

	public ItemSounds() { }

	public AudioClip GetClip(string partName, EInventorySoundType soundType) { }

}

