//Type is in global namespace

public abstract class ResourceIcon : IResourceIcon
{
	[CompilerGenerated]
	private readonly int <Hash>k__BackingField; //Field offset: 0x10
	private Sprite _sprite; //Field offset: 0x18
	private readonly BindableEvent _onChanged; //Field offset: 0x20

	public override IBindableEvent Changed
	{
		 get { } //Length: 5
	}

	public override int Hash
	{
		[CompilerGenerated]
		 get { } //Length: 164
	}

	public override Sprite Sprite
	{
		 get { } //Length: 5
		 set { } //Length: 406
	}

	protected ResourceIcon(int hash) { }

	protected ResourceIcon(int hash, Sprite sprite) { }

	public override IBindableEvent get_Changed() { }

	[CompilerGenerated]
	public override int get_Hash() { }

	public override Sprite get_Sprite() { }

	public override void NotifyChanged() { }

	public override void set_Sprite(Sprite value) { }

}

