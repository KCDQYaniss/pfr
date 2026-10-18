namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/ScriptBindings/AnimationRemoveScalePlayable.bindings.h")]
[NativeHeader("Modules/Animation/Director/AnimationRemoveScalePlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationRemoveScalePlayableBindings", StaticAccessorType::DoubleColon (2))]
internal struct AnimationRemoveScalePlayable : IPlayable, IEquatable
{
	private static readonly AnimationRemoveScalePlayable m_NullPlayable; //Field offset: 0x0
	private PlayableHandle m_Handle; //Field offset: 0x0

	private static AnimationRemoveScalePlayable() { }

	internal AnimationRemoveScalePlayable(PlayableHandle handle) { }

	public static AnimationRemoveScalePlayable Create(PlayableGraph graph, int inputCount) { }

	private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount) { }

	[NativeThrows]
	private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle) { }

	private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle) { }

	public override bool Equals(AnimationRemoveScalePlayable other) { }

	public override PlayableHandle GetHandle() { }

	public static Playable op_Implicit(AnimationRemoveScalePlayable playable) { }

}

