namespace ChartAndGraph;

public class CharItemEffectController : MonoBehaviour
{
	private List mEffects; //Field offset: 0x20
	private Transform mParent; //Field offset: 0x28
	[CompilerGenerated]
	private bool <WorkOnParent>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private bool <InitialScale>k__BackingField; //Field offset: 0x31
	private Vector3 mInitialScale; //Field offset: 0x34

	internal bool InitialScale
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	protected Transform Parent
	{
		 get { } //Length: 435
	}

	internal bool WorkOnParent
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	public CharItemEffectController() { }

	[CompilerGenerated]
	internal bool get_InitialScale() { }

	protected Transform get_Parent() { }

	[CompilerGenerated]
	internal bool get_WorkOnParent() { }

	private void OnTransformParentChanged() { }

	public void Register(ChartItemEffect effect) { }

	[CompilerGenerated]
	internal void set_InitialScale(bool value) { }

	[CompilerGenerated]
	internal void set_WorkOnParent(bool value) { }

	private void Start() { }

	public void Unregister(ChartItemEffect effect) { }

	private void Update() { }

}

