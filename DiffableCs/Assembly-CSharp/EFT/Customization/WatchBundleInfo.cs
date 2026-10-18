namespace EFT.Customization;

public struct WatchBundleInfo
{
	public ResourceKey WatchPrefab; //Field offset: 0x0
	public Vector3 WatchPosition; //Field offset: 0x8
	public Vector3 WatchRotation; //Field offset: 0x14

	public bool HasValidPath() { }

	public virtual string ToString() { }

}

