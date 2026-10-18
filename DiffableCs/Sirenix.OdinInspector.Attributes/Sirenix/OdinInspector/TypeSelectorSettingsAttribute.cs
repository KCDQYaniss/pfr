namespace Sirenix.OdinInspector;

[AttributeUsage(384)]
public class TypeSelectorSettingsAttribute : Attribute
{
	public const string FILTER_TYPES_FUNCTION_NAMED_VALUE = "type"; //Field offset: 0x0
	public string FilterTypesFunction; //Field offset: 0x10
	private Nullable showNoneItem; //Field offset: 0x18
	private Nullable showCategories; //Field offset: 0x1A
	private Nullable preferNamespaces; //Field offset: 0x1C

	public bool PreferNamespaces
	{
		 get { } //Length: 62
		 set { } //Length: 78
	}

	public bool PreferNamespacesIsSet
	{
		 get { } //Length: 62
	}

	public bool ShowCategories
	{
		 get { } //Length: 62
		 set { } //Length: 78
	}

	public bool ShowCategoriesIsSet
	{
		 get { } //Length: 62
	}

	public bool ShowNoneItem
	{
		 get { } //Length: 62
		 set { } //Length: 78
	}

	public bool ShowNoneItemIsSet
	{
		 get { } //Length: 62
	}

	public TypeSelectorSettingsAttribute() { }

	public bool get_PreferNamespaces() { }

	public bool get_PreferNamespacesIsSet() { }

	public bool get_ShowCategories() { }

	public bool get_ShowCategoriesIsSet() { }

	public bool get_ShowNoneItem() { }

	public bool get_ShowNoneItemIsSet() { }

	public void set_PreferNamespaces(bool value) { }

	public void set_ShowCategories(bool value) { }

	public void set_ShowNoneItem(bool value) { }

}

