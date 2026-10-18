namespace FastAnimatorSystem;

public class AnimatorSystemLogger : AbstractLogger
{

	public AnimatorSystemLogger() { }

	public void LogErrorOnGetLayerWeight(int layerIndex, IAnimator animator) { }

	public void LogErrorOnSetLayerWeight(int layerIndex, float weight, IAnimator animator) { }

	public void LogGetLayerNameWarning(int layerIndex, IAnimator animator) { }

	public void LogLayerGetByNameWarning(string layerName, IAnimator animator) { }

	public void LogNotUsed(string notUsedFeature, IAnimator animator) { }

	public void LogTriggeredTransition(AnimatorControllerTransition triggeredTransition) { }

	public void LogTriggInfo(AbstractAnimatorControllerState currentState, float currentNormTime, float absoluteStartFrameTime, float absoluteEndFrameTime) { }

}

