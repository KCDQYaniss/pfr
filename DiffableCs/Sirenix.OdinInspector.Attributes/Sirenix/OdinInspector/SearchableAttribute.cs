namespace Sirenix.OdinInspector;

[Conditional("UNITY_EDITOR")]
[DontApplyToListElements]
public class SearchableAttribute : Attribute
{
	public bool FuzzySearch; //Field offset: 0x10
	public SearchFilterOptions FilterOptions; //Field offset: 0x14
	public bool Recursive; //Field offset: 0x18

	public SearchableAttribute() { }

}

