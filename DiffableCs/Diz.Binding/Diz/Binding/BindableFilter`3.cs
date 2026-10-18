namespace Diz.Binding;

public class BindableFilter`3 : BaseBindableFilter, ICheckChanges
{
	private readonly IBindable _b1; //Field offset: 0x0
	private readonly IBindable _b2; //Field offset: 0x0
	private readonly Func _projection; //Field offset: 0x0

	public BindableFilter`3(IBindable b1, IBindable b2, Func projection) { }

	public override void CheckChanges() { }

	protected virtual void Connect() { }

}

