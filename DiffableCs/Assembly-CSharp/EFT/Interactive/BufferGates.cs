namespace EFT.Interactive;

public class BufferGates : Switch
{
	[SerializeField]
	private AnimationCurve _gatesMovementCurve; //Field offset: 0x210
	[SerializeField]
	private AnimationCurve _gatesCloseMovementCurve; //Field offset: 0x218
	[SerializeField]
	private GameObjectsToggleByDistance gatePartsDisabler; //Field offset: 0x220
	[SerializeField]
	private AudioClip _gatesOpenSound; //Field offset: 0x228
	[SerializeField]
	private AudioClip _gatesCloseSound; //Field offset: 0x230
	[SerializeField]
	private float _curveValueOnStartAutoClosing; //Field offset: 0x238
	private float currentCurveProgress; //Field offset: 0x23C
	private float _lastCurveProgress; //Field offset: 0x240
	private bool _gateOpenSoundPlayed; //Field offset: 0x244
	private bool _gateCloseSoundPlayed; //Field offset: 0x245

	internal bool CanForceClose
	{
		internal get { } //Length: 19
	}

	public BufferGates() { }

	protected virtual bool CanStartInteraction(EDoorState state, bool logFalse = false) { }

	protected virtual void DoorStateChanged(EDoorState newState) { }

	private void GatesCloseMovementProcess() { }

	private void GatesMovementProcess() { }

	internal bool get_CanForceClose() { }

	protected virtual void InitializeSmoothOpenInteraction(EDoorState state, bool confirmed) { }

	protected virtual void ProcessAngleAsShift(float value) { }

	private void TryPlayCloseSound() { }

	private void TryPlayOpenSound() { }

}

