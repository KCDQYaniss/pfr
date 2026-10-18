namespace EFT.InventoryLogic;

public class RecorderHandler
{
	public ERecorderHandsAction CurrentAction; //Field offset: 0x10
	[CompilerGenerated]
	private Item <Tape>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Item <PreviousTape>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly Action <InsertHandler>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly Action <EjectHandler>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly Action <PressButtonHandler>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private readonly Action <BreakHandler>k__BackingField; //Field offset: 0x40

	public Action BreakHandler
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Action EjectHandler
	{
		[CompilerGenerated]
		 get { } //Length: 76
	}

	public bool EjectTape
	{
		 get { } //Length: 9
	}

	public Action InsertHandler
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool InsertTape
	{
		 get { } //Length: 12
	}

	public bool IsPushButton
	{
		 get { } //Length: 17
	}

	public Action PressButtonHandler
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public private Item PreviousTape
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private Item Tape
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public RecorderHandler(Action playHandler, Item tape, Item prevTape, bool insertTape, bool ejectTape, Action insertHandler, Action ejectHandler, Action breakHandler) { }

	public RecorderHandler(Action stopHandler) { }

	public static RecorderHandler CreateEmptyHandler() { }

	[CompilerGenerated]
	public Action get_BreakHandler() { }

	[CompilerGenerated]
	public Action get_EjectHandler() { }

	public bool get_EjectTape() { }

	[CompilerGenerated]
	public Action get_InsertHandler() { }

	public bool get_InsertTape() { }

	public bool get_IsPushButton() { }

	[CompilerGenerated]
	public Action get_PressButtonHandler() { }

	[CompilerGenerated]
	public Item get_PreviousTape() { }

	[CompilerGenerated]
	public Item get_Tape() { }

	[CompilerGenerated]
	private void set_PreviousTape(Item value) { }

	[CompilerGenerated]
	private void set_Tape(Item value) { }

}

