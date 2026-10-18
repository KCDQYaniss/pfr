namespace EFT.UI;

public abstract class BuildWrapper
{
	private readonly BindableEvent _onSelect; //Field offset: 0x10
	private readonly BindableEvent _onRemove; //Field offset: 0x18
	private readonly BindableEvent _onEdit; //Field offset: 0x20
	private readonly BindableEvent _onUpdateVisuals; //Field offset: 0x28
	private bool _selected; //Field offset: 0x30

	public IBindableEvent OnEdit
	{
		 get { } //Length: 5
	}

	public IBindableEvent OnRemove
	{
		 get { } //Length: 5
	}

	public IBindableEvent OnSelect
	{
		 get { } //Length: 5
	}

	public IBindableEvent OnUpdateVisuals
	{
		 get { } //Length: 5
	}

	public bool Selected
	{
		 get { } //Length: 5
		 set { } //Length: 111
	}

	protected BuildWrapper() { }

	public void Delete() { }

	public void Edit() { }

	public IBindableEvent get_OnEdit() { }

	public IBindableEvent get_OnRemove() { }

	public IBindableEvent get_OnSelect() { }

	public IBindableEvent get_OnUpdateVisuals() { }

	public bool get_Selected() { }

	public void set_Selected(bool value) { }

	public void SetSelectSilently(bool value) { }

}

