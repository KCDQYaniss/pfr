//Type is in global namespace

public class BTRExhaustSmokeController : MonoBehaviour
{
	private const float RATE_IN_MOVE = 100; //Field offset: 0x0
	private readonly Vector2 _lifetimeHardInMove; //Field offset: 0x20
	private readonly Vector2 _lifetimeSoftInMove; //Field offset: 0x28
	[SerializeField]
	private BTRExhaustSmokeVisual[] _exhaustEffects; //Field offset: 0x30
	[SerializeField]
	private BTRExhaustSmokeProperties _movingProperties; //Field offset: 0x38
	[SerializeField]
	private BTRExhaustSmokeProperties _idleProperties; //Field offset: 0x60
	[SerializeField]
	private float _lightModeTimeChange; //Field offset: 0x88
	private BTRView _btrView; //Field offset: 0x90
	private bool _inSoftState; //Field offset: 0x98
	private bool _stateRouteChanged; //Field offset: 0x99
	private float _currentTime; //Field offset: 0x9C

	public BTRExhaustSmokeController() { }

	private void OnDestroy() { }

	private void OnMoveUpdate() { }

	private void OnRouteStateChanged() { }

	private void OnStateChanged(EBtrState state) { }

	private void SetHardIntermediateProperties() { }

	private void SetHardProperties() { }

	private void SetSoftIntermediateProperties() { }

	private void SetSoftProperties() { }

	private void Start() { }

	private void Update() { }

}

