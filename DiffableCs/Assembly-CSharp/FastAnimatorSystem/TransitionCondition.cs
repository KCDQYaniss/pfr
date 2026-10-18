namespace FastAnimatorSystem;

public sealed class TransitionCondition : IDisposable
{
	private sealed class ConditionCheckDelegate : MulticastDelegate
	{

		public ConditionCheckDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AnimatorParameter animatorParameter, AnimatorValue threshold, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(AnimatorParameter animatorParameter, AnimatorValue threshold) { }

	}

	private enum EConditionDelegateType
	{
		EqualInt = 0,
		EqualBool = 1,
		EqualTrigger = 2,
		GreaterThanInt = 3,
		GreaterThanFloat = 4,
		LessThanInt = 5,
		LessThanFloat = 6,
		NotEqualInt = 7,
		Length = 8,
	}

	internal enum EConditionModes
	{
		Equal = 0,
		NotEqual = 1,
		GreaterThan = 2,
		LessThan = 3,
	}

	private static readonly ConditionCheckDelegate[] _conditionCheckDelegates; //Field offset: 0x0
	public readonly AnimatorParameter Parameter; //Field offset: 0x10
	public readonly AnimatorValue Threshold; //Field offset: 0x18
	public readonly EConditionModes ConditionMode; //Field offset: 0x20
	private readonly int _conditionDelegateType; //Field offset: 0x24

	private static TransitionCondition() { }

	public TransitionCondition(AnimatorParameter parameter, AnimatorValue threshold, EConditionModes conditionMode) { }

	public bool CheckThreshold() { }

	private static EConditionDelegateType CreateConditionCheckDelegate(EConditionModes conditionMode, AnimatorParameter parameter, AnimatorValue threshold) { }

	public override void Dispose() { }

	private static bool EqualBool(AnimatorParameter animatorParameter, AnimatorValue threshold) { }

	private static bool EqualInt(AnimatorParameter animatorParameter, AnimatorValue threshold) { }

	private static bool EqualTrigger(AnimatorParameter animatorParameter, AnimatorValue threshold) { }

	private static bool GreaterThanFloat(AnimatorParameter animatorParameter, AnimatorValue threshold) { }

	private static bool GreaterThanInt(AnimatorParameter animatorParameter, AnimatorValue threshold) { }

	private static bool LessThanFloat(AnimatorParameter animatorParameter, AnimatorValue threshold) { }

	private static bool LessThanInt(AnimatorParameter animatorParameter, AnimatorValue threshold) { }

	private static bool NotEqualInt(AnimatorParameter animatorParameter, AnimatorValue threshold) { }

	public virtual string ToString() { }

}

