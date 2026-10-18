namespace ChartAndGraph;

public abstract class ChartItemEffect : MonoBehaviour
{
	internal int LineTag; //Field offset: 0x20
	private CharItemEffectController mController; //Field offset: 0x28
	[CompilerGenerated]
	private Action Deactivate; //Field offset: 0x30

	public event Action Deactivate
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	protected CharItemEffectController Controller
	{
		 get { } //Length: 681
	}

	internal abstract Quaternion Rotation
	{
		internal get { } //Length: 0
	}

	internal abstract Vector3 ScaleMultiplier
	{
		internal get { } //Length: 0
	}

	internal abstract Vector3 Translation
	{
		internal get { } //Length: 0
	}

	protected ChartItemEffect() { }

	[CompilerGenerated]
	public void add_Deactivate(Action value) { }

	protected override void Destroy() { }

	protected CharItemEffectController get_Controller() { }

	internal abstract Quaternion get_Rotation() { }

	internal abstract Vector3 get_ScaleMultiplier() { }

	internal abstract Vector3 get_Translation() { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	protected void RaiseDeactivated() { }

	private void Register() { }

	[CompilerGenerated]
	public void remove_Deactivate(Action value) { }

	protected override void Start() { }

	public abstract void TriggerIn(bool deactivateOnEnd) { }

	public abstract void TriggerOut(bool deactivateOnEnd) { }

	private void Unregister() { }

}

