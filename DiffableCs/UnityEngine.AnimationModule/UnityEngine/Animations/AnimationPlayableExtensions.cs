namespace UnityEngine.Animations;

[Extension]
[NativeHeader("Modules/Animation/Director/AnimationPlayableExtensions.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Animation/AnimationClip.h")]
public static class AnimationPlayableExtensions
{

	[Extension]
	public static void SetAnimatedProperties(U playable, AnimationClip clip) { }

	[NativeThrows]
	internal static void SetAnimatedPropertiesInternal(ref PlayableHandle playable, AnimationClip animatedProperties) { }

}

