//Type is in global namespace

public class FlexibleGridLayoutGroup : GridLayoutGroup
{

	public virtual float minWidth
	{
		 get { } //Length: 4
	}

	public virtual float preferredWidth
	{
		 get { } //Length: 4
	}

	public FlexibleGridLayoutGroup() { }

	public virtual float get_minWidth() { }

	public virtual float get_preferredWidth() { }

	public virtual void SetLayoutHorizontal() { }

}

