namespace EFT.Water;

public sealed class WaterHashTracker
{
	private int _propertiesHash; //Field offset: 0x10
	private int _version; //Field offset: 0x14
	private EWaterFeatureDirty _lastDirty; //Field offset: 0x18
	private EWaterFeatureDirty _pendingDirty; //Field offset: 0x1C

	public bool HasPendingDirty
	{
		 get { } //Length: 8
	}

	public EWaterFeatureDirty LastDirty
	{
		 get { } //Length: 4
	}

	public int Version
	{
		 get { } //Length: 4
	}

	public WaterHashTracker() { }

	private static int ComputeHash(WaterProperties props) { }

	public EWaterFeatureDirty DetectChanges(WaterProperties props) { }

	public bool get_HasPendingDirty() { }

	public EWaterFeatureDirty get_LastDirty() { }

	public int get_Version() { }

	private static int HashColor(Color c) { }

	private static int HashDynamicFoam(DynamicWaterFoam prop) { }

	private static int HashUnderwaterAbsorption(UnderwaterAbsorption prop) { }

	private static int HashUnderwaterColor(UnderwaterColor prop) { }

	private static int HashUnderwaterDepth(UnderwaterDepth prop) { }

	private static int HashUnderwaterRefraction(UnderwaterRefraction prop) { }

	private static int HashUnderwaterScattering(UnderwaterScattering prop) { }

	private static int HashVector3(Vector3 v) { }

	public void Invalidate(EWaterFeatureDirty dirty) { }

	public void Reset() { }

}

