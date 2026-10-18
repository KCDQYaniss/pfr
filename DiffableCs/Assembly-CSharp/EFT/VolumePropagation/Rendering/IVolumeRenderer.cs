namespace EFT.VolumePropagation.Rendering;

public interface IVolumeRenderer : IDisposable
{

	public float DistanceToCamera
	{
		 get { } //Length: 0
	}

	public bool FadeoutComplete
	{
		 get { } //Length: 0
	}

	public void AppendVoxels(IReadOnlyList voxels, int fromIndex, int count) { }

	public float get_DistanceToCamera() { }

	public bool get_FadeoutComplete() { }

	public void StartFadeout() { }

	public void Update() { }

}

