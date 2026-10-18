namespace Diz.Binding;

[Extension]
public static class BindableExtensions
{

	[Extension]
	public static IBindableList BindWhere(IBindableList source, Predicate predicate) { }

	[Extension]
	public static IBindableList Counted(IBindableList source, Func keySelector) { }

	[Extension]
	public static IBindableList Merge(IEnumerable lists) { }

}

