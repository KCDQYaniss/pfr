namespace Diz.LanguageExtensions;

public interface IOption
{

	public Error Error
	{
		 get { } //Length: 0
	}

	public bool Failed
	{
		 get { } //Length: 0
	}

	public bool Succeeded
	{
		 get { } //Length: 0
	}

	public Error get_Error() { }

	public bool get_Failed() { }

	public bool get_Succeeded() { }

}

