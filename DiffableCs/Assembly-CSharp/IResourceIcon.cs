//Type is in global namespace

public interface IResourceIcon
{

	public IBindableEvent Changed
	{
		 get { } //Length: 0
	}

	public int Hash
	{
		 get { } //Length: 0
	}

	public Sprite Sprite
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public IBindableEvent get_Changed() { }

	public int get_Hash() { }

	public Sprite get_Sprite() { }

	public void NotifyChanged() { }

	public void set_Sprite(Sprite value) { }

}

