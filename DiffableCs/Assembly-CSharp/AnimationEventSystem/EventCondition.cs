namespace AnimationEventSystem;

public sealed class EventCondition : ICloneable
{
	private sealed class ConditionDelegate : MulticastDelegate
	{

		public ConditionDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(EventCondition condition, IAnimator animator, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(EventCondition condition, IAnimator animator) { }

	}

	private enum EConditionType
	{
		None = -1,
		IntEqual = 0,
		IntNotEqual = 1,
		IntGreaterThan = 2,
		IntLessThan = 3,
		IntGreaterEqualThan = 4,
		IntLessEqualThan = 5,
		FloatGreaterThan = 6,
		FloatLessThan = 7,
		BoolEqual = 8,
		EConditionTypeEnumsCount = 9,
	}

	private static readonly ConditionDelegate[] _CONDITION_DELEGATES; //Field offset: 0x0
	public bool BoolValue; //Field offset: 0x10
	public float FloatValue; //Field offset: 0x14
	public int IntValue; //Field offset: 0x18
	public string ParameterName; //Field offset: 0x20
	private int _cachedNameHash; //Field offset: 0x28
	private EConditionType _conditionMode; //Field offset: 0x2C
	public EEventConditionParamTypes ConditionParamType; //Field offset: 0x30
	public EEventConditionModes ConditionMode; //Field offset: 0x34

	private static EventCondition() { }

	public EventCondition() { }

	private static bool CheckBoolEqual(EventCondition condition, IAnimator animator) { }

	private static bool CheckFloatGreaterThan(EventCondition condition, IAnimator animator) { }

	private static bool CheckFloatLessThan(EventCondition condition, IAnimator animator) { }

	private static bool CheckIntEqual(EventCondition condition, IAnimator animator) { }

	private static bool CheckIntGreaterEqualThan(EventCondition condition, IAnimator animator) { }

	private static bool CheckIntGreaterThan(EventCondition condition, IAnimator animator) { }

	private static bool CheckIntLessEqualThan(EventCondition condition, IAnimator animator) { }

	private static bool CheckIntLessThan(EventCondition condition, IAnimator animator) { }

	private static bool CheckIntNotEqual(EventCondition condition, IAnimator animator) { }

	public override object Clone() { }

	public void Deserialize(BinaryReader reader) { }

	protected bool Equals(EventCondition other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	private void InitConditionDelegate() { }

	public bool IsSucceed(IAnimator animator) { }

	public void Serialize(BinaryWriter writer) { }

	public string ToString(IAnimator animator) { }

}

