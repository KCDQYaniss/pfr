namespace EFT.Interactive;

public class BarbedWire : DamageTrigger
{
	private const float _speedLimitPenalty = 0.15; //Field offset: 0x0
	private const float _soundMinInterval = 0.5; //Field offset: 0x0
	private float _lastSoundTime; //Field offset: 0x58
	[SerializeField]
	private SoundBank _soundBank; //Field offset: 0x60
	[CompilerGenerated]
	private readonly string <Description>k__BackingField; //Field offset: 0x68

	public virtual string Description
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	protected virtual bool IsStatic
	{
		 get { } //Length: 3
	}

	public BarbedWire() { }

	protected virtual void AddPenalty(IObserverToPlayerBridge player) { }

	[CompilerGenerated]
	public virtual string get_Description() { }

	protected virtual bool get_IsStatic() { }

	protected virtual void PlaySound(Collider playerCollider, bool useOcclusion = false) { }

	protected virtual void ProceedDamage(IObserverToPlayerBridge player, BodyPartCollider bodyPart) { }

	protected virtual void RemovePenalty(IObserverToPlayerBridge player) { }

}

