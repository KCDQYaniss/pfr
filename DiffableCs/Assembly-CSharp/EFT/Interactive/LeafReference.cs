namespace EFT.Interactive;

public class LeafReference : NodeReference
{
	private bool _selected; //Field offset: 0x18

	public virtual ENodeStatus CurrentStatus
	{
		 get { } //Length: 14
	}

	public LeafReference() { }

	public virtual ENodeStatus get_CurrentStatus() { }

	public virtual IEnumerable GetSelected() { }

	public virtual void GetSelectedLeavesNonAlloc(List list) { }

	public virtual void SetFilter(IEnumerable filters) { }

	public virtual void SetSelected(bool value) { }

}

