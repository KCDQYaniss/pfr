//Type is in global namespace

[AttributeUsage(AttributeTargets::Field (256))]
public class CommentAttribute : Attribute
{
	private string _comment; //Field offset: 0x10

	public string Comment
	{
		 get { } //Length: 5
	}

	public CommentAttribute(string commentText) { }

	public string get_Comment() { }

}

