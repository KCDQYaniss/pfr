namespace EFT.VolumePropagation;

[IsReadOnly]
public struct DoorStateChange
{
	public readonly Door Door; //Field offset: 0x0
	public readonly bool IsOpened; //Field offset: 0x8

	public DoorStateChange(Door door, bool isOpened) { }

}

