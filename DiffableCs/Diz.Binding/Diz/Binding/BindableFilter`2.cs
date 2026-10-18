namespace Diz.Binding;

public class BindableFilter`2 : BaseBindableFilter, ICheckChanges
{
	private readonly IBindable _b1; //Field offset: 0x0
	private readonly Func _projection; //Field offset: 0x0

	public BindableFilter`2(IBindable b1, Func projection) { }

	public override void CheckChanges() { }

	protected virtual void Connect() { }

}

