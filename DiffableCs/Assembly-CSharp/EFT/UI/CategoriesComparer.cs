namespace EFT.UI;

public sealed class CategoriesComparer : IComparer
{
	public static readonly CategoriesComparer Instance; //Field offset: 0x0
	private readonly Dictionary _localizedNames; //Field offset: 0x10
	private string _culture; //Field offset: 0x18

	private static CategoriesComparer() { }

	public CategoriesComparer() { }

	public override int Compare(HandbookNode x, HandbookNode y) { }

	private string GetLocalizedName(string name) { }

}

