namespace EFT;

public sealed class StaticCameraObservationPoint : MonoBehaviour
{
	[SerializeField]
	private Vector3 _maxAngles; //Field offset: 0x20

	public Vector3 MaxAngles
	{
		 get { } //Length: 19
	}

	public StaticCameraObservationPoint() { }

	public Vector3 get_MaxAngles() { }

}

