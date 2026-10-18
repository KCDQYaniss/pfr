namespace RootMotion.FinalIK;

[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Spline")]
[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
public class RotationLimitSpline : RotationLimit
{
	[Range(0, 180)]
	public float twistLimit; //Field offset: 0x40
	[HideInInspector]
	[SerializeField]
	public AnimationCurve spline; //Field offset: 0x48

	public RotationLimitSpline() { }

	[ContextMenu("Asset Store Thread")]
	private void ASThread() { }

	protected virtual Quaternion LimitRotation(Quaternion rotation) { }

	public Quaternion LimitSwing(Quaternion rotation) { }

	[ContextMenu("Scrpt Reference")]
	private void OpenScriptReference() { }

	[ContextMenu("User Manual")]
	private void OpenUserManual() { }

	public void SetSpline(Keyframe[] keyframes) { }

	[ContextMenu("Support Group")]
	private void SupportGroup() { }

}

