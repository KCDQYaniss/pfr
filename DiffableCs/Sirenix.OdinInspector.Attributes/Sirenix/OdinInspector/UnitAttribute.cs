namespace Sirenix.OdinInspector;

public class UnitAttribute : Attribute
{
	public Units Base; //Field offset: 0x10
	public Units Display; //Field offset: 0x14
	public string BaseName; //Field offset: 0x18
	public string DisplayName; //Field offset: 0x20
	public bool DisplayAsString; //Field offset: 0x28
	public bool ForceDisplayUnit; //Field offset: 0x29

	public UnitAttribute(Units unit) { }

	public UnitAttribute(string unit) { }

	public UnitAttribute(Units base, Units display) { }

	public UnitAttribute(Units base, string display) { }

	public UnitAttribute(string base, Units display) { }

	public UnitAttribute(string base, string display) { }

}

