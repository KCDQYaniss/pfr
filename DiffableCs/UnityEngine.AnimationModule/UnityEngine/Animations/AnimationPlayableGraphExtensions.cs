namespace UnityEngine.Animations;

[Extension]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationPlayableGraphExtensions.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[NativeHeader("Modules/Animation/Animator.h")]
[StaticAccessor("AnimationPlayableGraphExtensionsBindings", StaticAccessorType::DoubleColon (2))]
internal static class AnimationPlayableGraphExtensions
{

	[NativeThrows]
	internal static bool InternalCreateAnimationOutput(ref PlayableGraph graph, string name, out PlayableOutputHandle handle) { }

}

