namespace FastAnimatorSystem;

public sealed class AnimatorControllerTransition : AbstractState, IParameterValueChangedListener
{
	public readonly AbstractAnimatorControllerState DestinationState; //Field offset: 0x30
	public readonly AbstractAnimatorControllerState SourceState; //Field offset: 0x38
	public readonly bool IsMuted; //Field offset: 0x40
	public readonly bool IsSolo; //Field offset: 0x41
	public readonly bool IsFixedDuration; //Field offset: 0x42
	public readonly float ExitTimeNormalized; //Field offset: 0x44
	public readonly float Duration; //Field offset: 0x48
	public readonly bool HasExitTime; //Field offset: 0x4C
	public readonly float NormalizedDestinationStateOffset; //Field offset: 0x50
	public readonly TransitionCondition[] Conditions; //Field offset: 0x58
	public readonly ETransitionInterruptionSource InterruptionSource; //Field offset: 0x60
	public readonly bool IsOrderedInterruption; //Field offset: 0x64
	[CompilerGenerated]
	private int <OrderIndex>k__BackingField; //Field offset: 0x68
	private bool _isDirty; //Field offset: 0x6C
	private bool _cachedValue; //Field offset: 0x6D

	public int OrderIndex
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public AnimatorControllerTransition(string name, int hash, AbstractAnimatorControllerState sourceState, AbstractAnimatorControllerState destinationState, bool isMuted, bool isSolo, bool isFixedDuration, float exitTimeNormalized, float duration, bool hasExitTime, float normalizedDestinationStateOffset, TransitionCondition[] conditions, ETransitionInterruptionSource interruptionSource, bool isOrderedInterruption) { }

	internal bool CheckConditions() { }

	protected virtual void Dispose(bool disposing) { }

	[CompilerGenerated]
	public int get_OrderIndex() { }

	private bool InternalCheckConditions() { }

	internal bool IsTimeForTransition(float startFrameTime, float endFrameTime) { }

	public void MarkDependentParameterDirty() { }

	public override void OnParameterValueChanged() { }

	public virtual void ResetCache() { }

	public void ResetTriggeredTriggers() { }

	[CompilerGenerated]
	public void set_OrderIndex(int value) { }

	private string SettingToString() { }

	public virtual string ToString() { }

}

