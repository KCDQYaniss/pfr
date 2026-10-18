namespace EFT.Communications;

public sealed class StatisticNotification : Notification
{
	private readonly LocalizationKey _firstKey; //Field offset: 0x30
	private readonly LocalizationKey _secondKey; //Field offset: 0x34
	private readonly int _value; //Field offset: 0x38

	public virtual string Description
	{
		 get { } //Length: 412
	}

	public StatisticNotification(LocalizationKey localizationKey1, LocalizationKey localizationKey2, int value) { }

	public virtual string get_Description() { }

}

