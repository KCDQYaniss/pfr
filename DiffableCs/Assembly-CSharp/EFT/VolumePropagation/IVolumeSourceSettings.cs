namespace EFT.VolumePropagation;

public interface IVolumeSourceSettings
{

	public byte PresetId
	{
		 get { } //Length: 0
	}

	public IVolumePropagationSettings Propagation
	{
		 get { } //Length: 0
	}

	public byte get_PresetId() { }

	public IVolumePropagationSettings get_Propagation() { }

}

