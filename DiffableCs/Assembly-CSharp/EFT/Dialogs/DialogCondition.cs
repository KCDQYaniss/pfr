namespace EFT.Dialogs;

[JsonConverter(typeof(DialogConditionConverter))]
[JsonObject(MemberSerialization::OptIn (1))]
public abstract class DialogCondition : ICondition
{

	[JsonProperty("type")]
	public abstract EDialogConditionType Type
	{
		 get { } //Length: 0
	}

	protected DialogCondition() { }

	public abstract EDialogConditionType get_Type() { }

	public abstract bool Test(IDialogContext context) { }

}

