namespace RootMotion.FinalIK;

public abstract class Grounder : MonoBehaviour
{
	internal sealed class GrounderDelegate : MulticastDelegate
	{

		public GrounderDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[Range(0, 1)]
	[Tooltip("The master weight. Use this to fade in/out the grounding effect.")]
	public float weight; //Field offset: 0x20
	[Tooltip("The Grounding solver. Not to confuse with IK solvers.")]
	public Grounding solver; //Field offset: 0x28
	public GrounderDelegate OnPreGrounder; //Field offset: 0x30
	public GrounderDelegate OnPostGrounder; //Field offset: 0x38
	protected bool initiated; //Field offset: 0x40

	protected Grounder() { }

	private Vector3 GetLegSpineBendVector(Leg leg) { }

	private Vector3 GetLegSpineTangent(Leg leg) { }

	protected Vector3 GetSpineOffsetTarget() { }

	protected void LogWarning(string message) { }

	protected abstract void OpenScriptReference() { }

	protected abstract void OpenUserManual() { }

	public abstract void ResetPosition() { }

}

