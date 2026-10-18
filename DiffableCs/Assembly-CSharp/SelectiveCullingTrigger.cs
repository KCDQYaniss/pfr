//Type is in global namespace

[ExecuteInEditMode]
public class SelectiveCullingTrigger : DisablerCullingObject
{
	[SerializeField]
	private Color _childGizmosColor; //Field offset: 0xF8
	[SerializeField]
	private List _childs; //Field offset: 0x108
	private List _enteredParents; //Field offset: 0x110

	public virtual bool HasEntered
	{
		 get { } //Length: 143
	}

	public bool HasEnteredSelfOnly
	{
		 get { } //Length: 92
	}

	public SelectiveCullingTrigger() { }

	public virtual bool get_HasEntered() { }

	public bool get_HasEnteredSelfOnly() { }

	public virtual void NullClean() { }

	public void OnParentEnter(SelectiveCullingTrigger parent) { }

	public void OnParentExit(SelectiveCullingTrigger parent) { }

	protected virtual void OnSpectatorTriggerStateReset() { }

	protected virtual void UpdateComponentsStatusOnUpdate() { }

}

