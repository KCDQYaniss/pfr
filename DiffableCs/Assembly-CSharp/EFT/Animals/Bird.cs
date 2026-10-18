namespace EFT.Animals;

public class Bird : MonoBehaviour
{
	private static readonly int _flight; //Field offset: 0x0
	private static readonly int _soar; //Field offset: 0x4
	private static readonly int _speedMult; //Field offset: 0x8
	[SerializeField]
	private Animator _animator; //Field offset: 0x20
	[SerializeField]
	public Transform Carina; //Field offset: 0x28
	[SerializeField]
	private float _shaftAngleSmooth; //Field offset: 0x30
	[SerializeField]
	private float _directionChangeSensitivity; //Field offset: 0x34
	[SerializeField]
	private float _switchToSoarPoint; //Field offset: 0x38
	[SerializeField]
	private float _speedToFlap; //Field offset: 0x3C
	[SerializeField]
	private float _directionToFlap; //Field offset: 0x40
	private Vector3 _direction; //Field offset: 0x44
	private float _shaftAngle; //Field offset: 0x50
	private float _shaftAngleVelocity; //Field offset: 0x54

	private static Bird() { }

	public Bird() { }

	public void SetDirection(Vector3 direction, float commonSpeedMult) { }

}

