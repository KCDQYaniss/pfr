namespace Koenigz.PerfectCulling.EFT;

public interface IAutocullAutomated
{

	public Bounds AutocullObjectBounds
	{
		 get { } //Length: 0
	}

	public bool IsAutocullVisible
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool IsDynamicCullingObject
	{
		 get { } //Length: 0
	}

	public Bounds get_AutocullObjectBounds() { }

	public bool get_IsAutocullVisible() { }

	public bool get_IsDynamicCullingObject() { }

	public void set_IsAutocullVisible(bool value) { }

}

