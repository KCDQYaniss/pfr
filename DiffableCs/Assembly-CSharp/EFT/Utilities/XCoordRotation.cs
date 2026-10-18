namespace EFT.Utilities;

public class XCoordRotation : MonoBehaviour
{
	[SerializeField]
	private float _rotationSpeed; //Field offset: 0x20
	private Transform _rotator; //Field offset: 0x28
	[CompilerGenerated]
	private float <CurrentYaw>k__BackingField; //Field offset: 0x30

	public private float CurrentYaw
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public XCoordRotation() { }

	private float ClampYaw(float value) { }

	[CompilerGenerated]
	public float get_CurrentYaw() { }

	public void Init(Transform model) { }

	public void Rotate(float angle) { }

	[CompilerGenerated]
	private void set_CurrentYaw(float value) { }

	public void SetRotation(float yaw) { }

}

