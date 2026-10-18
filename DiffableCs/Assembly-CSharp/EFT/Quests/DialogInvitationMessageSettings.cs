namespace EFT.Quests;

public class DialogInvitationMessageSettings
{
	[JsonProperty("isEnabled")]
	public bool IsEnabled; //Field offset: 0x10
	[JsonProperty("fromTraderId")]
	public string FromTraderId; //Field offset: 0x18
	[JsonProperty("entryPoint")]
	public EDialogEntryPoint EntryPoint; //Field offset: 0x20
	[JsonProperty("whileAvailableMessageText")]
	public string TraderMessageLocaleKey; //Field offset: 0x28
	[JsonProperty("dialogId")]
	public Nullable DialogId; //Field offset: 0x30

	public DialogInvitationMessageSettings() { }

}

