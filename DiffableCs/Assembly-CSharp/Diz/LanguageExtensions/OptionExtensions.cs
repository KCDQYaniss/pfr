namespace Diz.LanguageExtensions;

[Extension]
public static class OptionExtensions
{

	[Extension]
	public static OperationResult Cast(OperationResult source) { }

	[Extension]
	public static void Invoke(Callback callback, Option sourceOption) { }

	[Extension]
	public static IResult ToResult(IOption sourceOption) { }

}

