namespace FastAnimatorSystem.JsonSerialization;

[Extension]
public static class FastAnimatorControllerJsonSerializator
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__17_1; //Field offset: 0x8
		public static Func <>9__17_0; //Field offset: 0x10
		public static Func <>9__18_0; //Field offset: 0x18
		public static Func <>9__24_0; //Field offset: 0x20
		public static Func <>9__26_0; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal IEnumerable <GetAllTransitions>b__17_0(AbstractAnimatorControllerState s) { }

		internal FlatAnimatorControllerTransition <GetAllTransitions>b__17_1(AnimatorControllerTransition t) { }

		internal FlatAnimatorParameter <GetFlatParameters>b__18_0(AnimatorParameter p) { }

		internal FlatMotion <ToFlatEntity>b__24_0(AbstractMotion x) { }

		internal FlatTransitionCondition <ToFlatEntity>b__26_0(TransitionCondition c) { }

	}

	internal sealed class FlatAnimatorControllerTransition : ICloneable
	{
		public string Name; //Field offset: 0x10
		public int Hash; //Field offset: 0x18
		public int SourceStateId; //Field offset: 0x1C
		public int DestinationStateId; //Field offset: 0x20
		public bool IsMuted; //Field offset: 0x24
		public bool IsSolo; //Field offset: 0x25
		public bool IsFixedDuration; //Field offset: 0x26
		public float ExitTime; //Field offset: 0x28
		public float Duration; //Field offset: 0x2C
		public bool HasExitTime; //Field offset: 0x30
		public List Conditions; //Field offset: 0x38
		public float DestinationStateOffset; //Field offset: 0x40
		public ETransitionInterruptionSource InterruptionSource; //Field offset: 0x44
		public bool IsOrderedInterruption; //Field offset: 0x48

		public FlatAnimatorControllerTransition() { }

		public override object Clone() { }

		public void Deserialize(BinaryReader reader) { }

		public virtual bool Equals(object obj) { }

		protected bool Equals(FlatAnimatorControllerTransition other) { }

		public virtual int GetHashCode() { }

		public void Serialize(BinaryWriter writer) { }

	}

	internal sealed class FlatAnimatorParameter : ICloneable
	{
		public string Name; //Field offset: 0x10
		public int Hash; //Field offset: 0x18
		public EAnimatorValueType Type; //Field offset: 0x1C
		public string Value; //Field offset: 0x20
		public bool IsControlledByAnimationCurver; //Field offset: 0x28
		public bool DefaultBoolValue; //Field offset: 0x29
		public float DefaultFloatValue; //Field offset: 0x2C
		public int DefaultIntValue; //Field offset: 0x30

		public FlatAnimatorParameter() { }

		public override object Clone() { }

		public void Deserialize(BinaryReader reader) { }

		protected bool Equals(FlatAnimatorParameter other) { }

		public virtual bool Equals(object obj) { }

		public virtual int GetHashCode() { }

		public void Serialize(BinaryWriter writer) { }

	}

	internal sealed class FlatFastAnimatorController : ICloneable
	{
		public string UnityAnimatorControllerObjectHash; //Field offset: 0x10
		public List Parameters; //Field offset: 0x18
		public List States; //Field offset: 0x20
		public List Transitions; //Field offset: 0x28

		public FlatFastAnimatorController() { }

		public override object Clone() { }

		public void Deserialize(BinaryReader reader) { }

		public virtual bool Equals(object obj) { }

		protected bool Equals(FlatFastAnimatorController other) { }

		public virtual int GetHashCode() { }

		public void Serialize(BinaryWriter writer) { }

	}

	internal sealed class FlatFastAnimatorControllerEntity : ICloneable
	{
		private enum BehType
		{
			None = 0,
			EventsState = 1,
			PlayerContainer = 2,
		}

		public string TypeName; //Field offset: 0x10
		public int Hash; //Field offset: 0x18
		public string Name; //Field offset: 0x20
		public int ParentStateMachine; //Field offset: 0x28
		public List Motions; //Field offset: 0x30
		public float SpeedMultiplier; //Field offset: 0x38
		public int SpeedMultiplierParameterHash; //Field offset: 0x3C
		public float LayerWeight; //Field offset: 0x40
		public int DefaultStateHash; //Field offset: 0x44
		public FastStateBehavior[] Behaviors; //Field offset: 0x48

		public FlatFastAnimatorControllerEntity() { }

		public override object Clone() { }

		public void Deserialize(BinaryReader reader) { }

		public virtual bool Equals(object obj) { }

		protected bool Equals(FlatFastAnimatorControllerEntity other) { }

		public virtual int GetHashCode() { }

		public void Serialize(BinaryWriter writer) { }

	}

	internal sealed class FlatMotion : ICloneable
	{
		public float Duration; //Field offset: 0x10
		public string Name; //Field offset: 0x18
		public bool IsLooping; //Field offset: 0x20
		public int ClipInstanceId; //Field offset: 0x24

		public FlatMotion() { }

		public override object Clone() { }

		public void Deserialize(BinaryReader reader) { }

		public virtual bool Equals(object obj) { }

		protected bool Equals(FlatMotion other) { }

		public virtual int GetHashCode() { }

		public void Serialize(BinaryWriter writer) { }

	}

	private class FlatToRealContext
	{
		public int ControllerHashId; //Field offset: 0x10
		public Dictionary States; //Field offset: 0x18
		public Dictionary Parameters; //Field offset: 0x20
		public string AnimatorControllerObjectHash; //Field offset: 0x28

		public FastAnimatorController FastAnimatorController
		{
			 get { } //Length: 164
		}

		public FlatToRealContext() { }

		public FastAnimatorController get_FastAnimatorController() { }

	}

	internal sealed class FlatTransitionCondition : ICloneable
	{
		public string ParameterName; //Field offset: 0x10
		public int ParameterNameHash; //Field offset: 0x18
		public EConditionModes ConditionMode; //Field offset: 0x1C
		public string ThresholdValue; //Field offset: 0x20

		public FlatTransitionCondition() { }

		public override object Clone() { }

		public void Deserialize(BinaryReader reader) { }

		public virtual bool Equals(object obj) { }

		protected bool Equals(FlatTransitionCondition other) { }

		public virtual int GetHashCode() { }

		public void Serialize(BinaryWriter writer) { }

	}

	private static readonly string _fastAnimatorControllerTypeName; //Field offset: 0x0
	private static readonly string _layerStateMachineTypeName; //Field offset: 0x8
	private static readonly string _stateMachineTypeName; //Field offset: 0x10
	private static readonly string _animatedStateTypeName; //Field offset: 0x18
	private static readonly string _oneDBlendTreeStateTypeName; //Field offset: 0x20

	private static FastAnimatorControllerJsonSerializator() { }

	private static FastStateBehavior[] CloneBehaviors(FastStateBehavior[] behaviors) { }

	public static FastAnimatorController ConvertFlatToFast(FlatFastAnimatorController flatFastAnimatorController) { }

	public static FastAnimatorController Deserialize(byte[] data) { }

	public static FlatFastAnimatorController DeserializeToFlat(byte[] data) { }

	[Extension]
	private static List GetAllInternalStatesAndStateMachines(FastAnimatorController fastAnimatorController) { }

	[Extension]
	private static List GetAllTransitions(FastAnimatorController fastAnimatorController) { }

	[Extension]
	private static List GetFlatEntities(LayerStateMachine layerStateMachine) { }

	[Extension]
	private static List GetFlatParameters(FastAnimatorController fastAnimatorController) { }

	public static MemoryStream Serialize(FastAnimatorController fastAnimatorController) { }

	[Extension]
	private static AbstractMotion ToAbstractMotion(FlatMotion motion) { }

	[Extension]
	private static AnimatorParameter ToAnimatorParameter(FlatAnimatorParameter flatAnimatorParameter, FlatToRealContext context) { }

	[Extension]
	private static AbstractState ToAnimatorState(FlatFastAnimatorControllerEntity controllerEntity, FlatToRealContext context) { }

	[Extension]
	private static AnimatorControllerTransition ToAnimatorTransition(FlatAnimatorControllerTransition flatAnimatorControllerTransition, FlatToRealContext context) { }

	[Extension]
	private static FlatMotion ToFlatEntity(AbstractMotion abstractMotion) { }

	[Extension]
	private static FlatAnimatorParameter ToFlatEntity(AnimatorParameter animatorParameter) { }

	[Extension]
	private static FlatFastAnimatorControllerEntity ToFlatEntity(AbstractInnerStateMachine layerStateMachine) { }

	[Extension]
	private static FlatFastAnimatorControllerEntity ToFlatEntity(AbstractAnimatorControllerState controllerState) { }

	[Extension]
	private static FlatFastAnimatorControllerEntity ToFlatEntity(AnimatedState controllerState) { }

	[Extension]
	private static FlatFastAnimatorControllerEntity ToFlatEntity(OneDBlendTreeState controllerState) { }

	[Extension]
	private static FlatFastAnimatorControllerEntity ToFlatEntity(AbstractState fastAnimatorController) { }

	[Extension]
	private static FlatAnimatorControllerTransition ToFlatEntity(AnimatorControllerTransition transition) { }

	[Extension]
	private static FlatTransitionCondition ToFlatEntity(TransitionCondition condition) { }

	[Extension]
	private static TransitionCondition ToTransitionCondition(FlatTransitionCondition flatTranstionCondition, FlatToRealContext context) { }

}

