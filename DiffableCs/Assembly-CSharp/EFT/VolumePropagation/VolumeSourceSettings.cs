namespace EFT.VolumePropagation;

public class VolumeSourceSettings : IVolumeSourceSettings
{
	[CompilerGenerated]
	private byte <PresetId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private IVolumePropagationSettings <Propagation>k__BackingField; //Field offset: 0x18

	public override byte PresetId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override IVolumePropagationSettings Propagation
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public VolumeSourceSettings() { }

	[CompilerGenerated]
	public override byte get_PresetId() { }

	[CompilerGenerated]
	public override IVolumePropagationSettings get_Propagation() { }

	[CompilerGenerated]
	public void set_PresetId(byte value) { }

	[CompilerGenerated]
	public void set_Propagation(IVolumePropagationSettings value) { }

}

