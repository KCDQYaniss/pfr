namespace CommonAssets.Scripts.Audio.RadioSystem;

public class BroadcastItemData
{
	public AudioClip clip; //Field offset: 0x10
	[HideInInspector]
	public int clipIndex; //Field offset: 0x18
	[HideInInspector]
	public float clipLength; //Field offset: 0x1C
	[HideInInspector]
	public EBroadcastItemType itemType; //Field offset: 0x20

	public BroadcastItemData() { }

}

