namespace EFT.Interactive;

public sealed class ExperienceTrigger : TriggerWithId
{
	[SerializeField]
	private int _experience; //Field offset: 0x30

	public ExperienceTrigger() { }

	private void Awake() { }

	protected virtual void TriggerEnter(Player player) { }

}

