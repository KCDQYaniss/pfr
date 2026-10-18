namespace Koenigz.PerfectCulling.EFT;

[PreferBinarySerialization]
public sealed class StreamingVolumeBakeDataIndex : ScriptableObject
{
	public const string StreamingIndexFilePostfix = "_index"; //Field offset: 0x0
	public const string StreamingRawDataFilePostfix = "_cull"; //Field offset: 0x0
	public const string PlayerBuildCullingDataFolder = "Culling_Data"; //Field offset: 0x0
	public string volumeGuid; //Field offset: 0x18
	public string groupGuid; //Field offset: 0x20
	public Vector3 cellCount; //Field offset: 0x28
	public Vector3 cellSize; //Field offset: 0x34
	public Vector3 originalCellSize; //Field offset: 0x40
	public Quaternion orientation; //Field offset: 0x4C
	public bool bakeCompleted; //Field offset: 0x5C
	public int bakeHash; //Field offset: 0x60
	public int bakeDataVersion; //Field offset: 0x64
	public VisibilitySetIndex[] indices; //Field offset: 0x68

	public int IndexSizeBytes
	{
		 get { } //Length: 29
	}

	public bool IsValid
	{
		 get { } //Length: 48
	}

	public StreamingVolumeBakeDataIndex() { }

	public static StreamingVolumeBakeDataIndex Convert(PerfectCullingCrossSceneVolume vol, BakeDescriptor desc, PerfectCullingVolumeBakeData data) { }

	public int get_IndexSizeBytes() { }

	public bool get_IsValid() { }

	public static string GetStreamingDataFilePath(PerfectCullingCrossSceneVolume vol, BakeDescriptor desc, bool isIndexFile = false) { }

}

