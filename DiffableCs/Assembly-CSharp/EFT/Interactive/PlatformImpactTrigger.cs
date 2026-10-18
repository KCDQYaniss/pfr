namespace EFT.Interactive;

public sealed class PlatformImpactTrigger : DamageTrigger
{
	[SerializeField]
	private Locomotive Locomotive; //Field offset: 0x58
	[SerializeField]
	private AnimationCurve DamagePerSpeed; //Field offset: 0x60
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

	public PlatformImpactTrigger() { }

	protected virtual void AddPenalty(IObserverToPlayerBridge player) { }

	[CompilerGenerated]
	public virtual string get_Description() { }

	protected virtual bool get_IsStatic() { }

	protected virtual void PlaySound(Collider playerCollider, bool useOcclusion = false) { }

	protected virtual void ProceedDamage(IObserverToPlayerBridge player, BodyPartCollider bodyPart) { }

	protected virtual void RemovePenalty(IObserverToPlayerBridge player) { }

}

