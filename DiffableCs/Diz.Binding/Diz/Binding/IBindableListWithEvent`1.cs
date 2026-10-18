namespace Diz.Binding;

public interface IBindableListWithEvent`1 : IBindableList, IEnumerable, IEnumerable
{

	public BindableEvent ItemsChanged
	{
		 get { } //Length: 0
	}

	public BindableEvent get_ItemsChanged() { }

}

