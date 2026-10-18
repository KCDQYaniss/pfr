namespace Sirenix.OdinInspector;

[AttributeUsage(1052)]
public class TypeRegistryItemAttribute : Attribute
{
	public string Name; //Field offset: 0x10
	public string CategoryPath; //Field offset: 0x18
	public SdfIconType Icon; //Field offset: 0x20
	public Nullable LightIconColor; //Field offset: 0x24
	public Nullable DarkIconColor; //Field offset: 0x38
	public int Priority; //Field offset: 0x4C

	public TypeRegistryItemAttribute(string name = null, string categoryPath = null, SdfIconType icon = 0, float lightIconColorR = 0, float lightIconColorG = 0, float lightIconColorB = 0, float lightIconColorA = 0, float darkIconColorR = 0, float darkIconColorG = 0, float darkIconColorB = 0, float darkIconColorA = 0, int priority = 0) { }

}

