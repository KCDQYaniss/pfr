namespace Koenigz.PerfectCulling.EFT;

public sealed class AutocullLODGroupCell : IAutocullAutomated
{
	[SerializeField]
	private List _lodGroups; //Field offset: 0x10
	[SerializeField]
	private Bounds _bounds; //Field offset: 0x18
	private bool _isAutocullVisible; //Field offset: 0x30

	public override Bounds AutocullObjectBounds
	{
		 get { } //Length: 21
	}

	public override bool IsAutocullVisible
	{
		 get { } //Length: 5
		 set { } //Length: 412
	}

	public override bool IsDynamicCullingObject
	{
		 get { } //Length: 3
	}

	public AutocullLODGroupCell(List lodGroups) { }

	public override Bounds get_AutocullObjectBounds() { }

	public override bool get_IsAutocullVisible() { }

	public override bool get_IsDynamicCullingObject() { }

	private void RecomputeBounds() { }

	public override void set_IsAutocullVisible(bool value) { }

	public void Union(AutocullLODGroupCell other) { }

}

