namespace CommonAssets.Scripts.Audio.RadioSystem;

public struct BroadcastDataPacket
{
	public byte radioStation; //Field offset: 0x0
	public byte broadcastItemType; //Field offset: 0x1
	public int broadcastItemIndex; //Field offset: 0x4
	public float currentClipTime; //Field offset: 0x8

}

