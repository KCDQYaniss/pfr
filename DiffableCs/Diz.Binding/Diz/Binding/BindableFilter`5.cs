namespace Diz.Binding;

public class BindableFilter`5 : BaseBindableFilter, ICheckChanges
{
	private readonly IBindable _b1; //Field offset: 0x0
	private readonly IBindable _b2; //Field offset: 0x0
	private readonly IBindable _b3; //Field offset: 0x0
	private readonly IBindable _b4; //Field offset: 0x0
	private readonly Func _projection; //Field offset: 0x0

	public BindableFilter`5(IBindable b1, IBindable b2, IBindable b3, IBindable b4, Func projection) { }

	public override void CheckChanges() { }

	protected virtual void Connect() { }

}

