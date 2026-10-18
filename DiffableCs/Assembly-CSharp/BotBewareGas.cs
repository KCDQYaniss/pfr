//Type is in global namespace

public class BotBewareGas : BotData, IDisposable
{
	public Vector3 GasPoint; //Field offset: 0x18
	public float SafeRad; //Field offset: 0x24
	public float GasStopAffected; //Field offset: 0x28
	private bool _isCurGasAffected; //Field offset: 0x2C
	private float _affectedByGasUntil; //Field offset: 0x30
	private bool _subscribed; //Field offset: 0x34

	public bool AffectedByGas
	{
		 get { } //Length: 86
	}

	public BotBewareGas(BotOwner owner) { }

	public void AddAffectedByGasUntil(float period, Vector3 gasPoint) { }

	public override void Dispose() { }

	public CustomNavigationPoint FoundSafePoint() { }

	public bool get_AffectedByGas() { }

	public bool IsBewaringGas() { }

	private void OnPlayerTouchGas(Vector3 gasSourcePosition, IObserverToPlayerBridge aggressor) { }

	public bool ShallRunAway() { }

	private void Subscribe() { }

	private void Unsubscribe() { }

}

