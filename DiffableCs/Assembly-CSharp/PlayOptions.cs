//Type is in global namespace

public struct PlayOptions
{
	public static readonly PlayOptions Default; //Field offset: 0x0
	public bool atListener; //Field offset: 0x0
	public AudioMixerGroup forceMixerGroup; //Field offset: 0x8
	public bool spatialize; //Field offset: 0x10
	public EOcclusionTest occlusionTest; //Field offset: 0x14
	public Vector3 occlusionPositionOffset; //Field offset: 0x18
	public bool occlusionPositionStatic; //Field offset: 0x24
	public AudioSourceGroupType customOutputGroup; //Field offset: 0x28
	public float volume; //Field offset: 0x2C
	public bool needUpdate; //Field offset: 0x30
	public float bankBlendValue; //Field offset: 0x34
	public EnvironmentType environment; //Field offset: 0x38
	public float spatialBlend; //Field offset: 0x3C
	public bool useOcclusion; //Field offset: 0x40
	public bool isLooped; //Field offset: 0x41
	public bool enableStereo; //Field offset: 0x42
	public bool enableReverb; //Field offset: 0x43
	public float pitch; //Field offset: 0x44
	public bool enableEQ; //Field offset: 0x48
	public float clipStartOffsetSeconds; //Field offset: 0x4C

	private static PlayOptions() { }

}

