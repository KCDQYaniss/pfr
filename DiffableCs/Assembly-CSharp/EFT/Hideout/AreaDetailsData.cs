namespace EFT.Hideout;

public sealed class AreaDetailsData
{
	private const string FUEL_TEXT = "hideout/Fuel"; //Field offset: 0x0
	private const string NO_FUEL_TEXT = "hideout/No fuel!"; //Field offset: 0x0
	private const string SWITCHED_OFF_TEXT = "hideout/Switched off"; //Field offset: 0x0
	private const string ITEMS_READY_TEXT = "hideout/Items ready"; //Field offset: 0x0
	private const string GIFT_BESTOWED_TEXT = "hideout/Bestowed"; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnChanged; //Field offset: 0x10
	private AreaDetailsCache _detailsCache; //Field offset: 0x18

	public event Action OnChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public bool IsActive
	{
		 get { } //Length: 5
		 set { } //Length: 58
	}

	public int Percentages
	{
		 get { } //Length: 4
		 set { } //Length: 58
	}

	public string Text
	{
		 get { } //Length: 848
	}

	public int Time
	{
		 get { } //Length: 4
		 set { } //Length: 58
	}

	public EDetailsType Type
	{
		 get { } //Length: 4
		 set { } //Length: 58
	}

	public AreaDetailsData() { }

	[CompilerGenerated]
	public void add_OnChanged(Action value) { }

	public AreaDetailsData Copy() { }

	public bool get_IsActive() { }

	public int get_Percentages() { }

	public string get_Text() { }

	public int get_Time() { }

	public EDetailsType get_Type() { }

	[CompilerGenerated]
	public void remove_OnChanged(Action value) { }

	public void set_IsActive(bool value) { }

	public void set_Percentages(int value) { }

	public void set_Time(int value) { }

	public void set_Type(EDetailsType value) { }

}

