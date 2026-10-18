//Type is in global namespace

public class BouncingObjectLauncher : MonoBehaviour
{
	[SerializeField]
	private LayerMask _castMask; //Field offset: 0x20
	[SerializeField]
	private int _maxCastCount; //Field offset: 0x24
	[SerializeField]
	private float _deltaTimeStep; //Field offset: 0x28
	[SerializeField]
	private float _jumpSpeed; //Field offset: 0x2C
	[SerializeField]
	private float _playMult; //Field offset: 0x30
	[SerializeField]
	private float _randomReboundSpread; //Field offset: 0x34
	[SerializeField]
	private float _bounceSpeedMult; //Field offset: 0x38
	[SerializeField]
	private float _radius; //Field offset: 0x3C
	private GameObject _ball; //Field offset: 0x40

	public BouncingObjectLauncher() { }

	private void Launch(Transform from) { }

	public void Launch() { }

}

