//Type is in global namespace

public class BotBewareGasDebug : MonoBehaviour
{
	[Min(0.01)]
	[SerializeField]
	private float _affectDurationSeconds; //Field offset: 0x20
	[Min(0.05)]
	[SerializeField]
	private float _sourceSphereRadius; //Field offset: 0x24
	[SerializeField]
	private Color _sourceSphereColor; //Field offset: 0x28
	[Min(0.05)]
	[SerializeField]
	private float _lastBotSphereRadius; //Field offset: 0x38
	[SerializeField]
	private Color _lastBotLineColor; //Field offset: 0x3C
	private BotOwner _lastAffectedBot; //Field offset: 0x50

	public BotBewareGasDebug() { }

	public void ApplyGasEffectFromSource() { }

	private static BotOwner FindNearestBotWithBewareGas(Vector3 from) { }

	private void OnDrawGizmos() { }

}

