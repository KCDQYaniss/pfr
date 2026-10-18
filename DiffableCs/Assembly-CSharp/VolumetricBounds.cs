//Type is in global namespace

public class VolumetricBounds
{
	private readonly int _maxParticles; //Field offset: 0x10
	private readonly float _maxLength; //Field offset: 0x14
	private NativeArray _directions; //Field offset: 0x18

	public VolumetricBounds(float radius, float subdivisions, int maxParticles, float maxLength) { }

	private void AddPointInRadius(in NativeArray hitResults, List output, float radius, Vector3 origin, Vector3 dirOffset) { }

	private static NativeArray ComputeDirections(float r, float n) { }

	public void Dispose() { }

	public void RayCast(List output, Vector3 origin) { }

}

