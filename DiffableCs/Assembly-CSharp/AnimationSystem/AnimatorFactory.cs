namespace AnimationSystem;

public static class AnimatorFactory
{

	public static IAnimator CreateAnimator(Animator animator) { }

	public static IAnimator CreateAnimator(FastAnimatorController fastAnimatorController, Dictionary computedNodes = null, Transform rootBone = null, IPlayableAnimator playableAnimator = null) { }

}

