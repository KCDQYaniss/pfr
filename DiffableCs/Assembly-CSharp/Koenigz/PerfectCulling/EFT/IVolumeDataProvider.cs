namespace Koenigz.PerfectCulling.EFT;

public interface IVolumeDataProvider
{

	public Vector3 SizeOfVolume
	{
		 get { } //Length: 0
	}

	public string VolumeGuid
	{
		 get { } //Length: 0
	}

	public Vector3 get_SizeOfVolume() { }

	public string get_VolumeGuid() { }

	public Vector3 GetSamplingPositionAt(int index, Vector3 cellSize, Space space) { }

	public List GetSamplingProviders() { }

	public IReadOnlyCollection GetUniqueBakeCellSizes() { }

}

