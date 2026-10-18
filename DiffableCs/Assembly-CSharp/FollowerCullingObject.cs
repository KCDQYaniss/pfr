//Type is in global namespace

[ExecuteInEditMode]
public class FollowerCullingObject : CullingObject
{
	[CompilerGenerated]
	private Action OnVisibilityChanged; //Field offset: 0x98
	private Func _transformGetter; //Field offset: 0xA0

	public event Action OnVisibilityChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public FollowerCullingObject() { }

	[CompilerGenerated]
	public void add_OnVisibilityChanged(Action value) { }

	protected virtual Transform GetTransform() { }

	public void Init(Func transformGetter) { }

	[CompilerGenerated]
	public void remove_OnVisibilityChanged(Action value) { }

	public void SetParams(float radius, Vector3 shift, float cullDistance) { }

	public virtual void SetVisibility(bool isVisible) { }

}

