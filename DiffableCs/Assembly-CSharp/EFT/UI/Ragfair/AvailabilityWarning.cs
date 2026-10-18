namespace EFT.UI.Ragfair;

public sealed class AvailabilityWarning : Data
{

	public virtual ERagFairOfferDataType DataType
	{
		 get { } //Length: 6
	}

	public AvailabilityWarning() { }

	public virtual ERagFairOfferDataType get_DataType() { }

}

