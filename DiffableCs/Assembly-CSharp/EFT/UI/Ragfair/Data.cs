namespace EFT.UI.Ragfair;

public abstract class Data
{
	public bool Expanded; //Field offset: 0x10

	public abstract ERagFairOfferDataType DataType
	{
		 get { } //Length: 0
	}

	protected Data() { }

	public abstract ERagFairOfferDataType get_DataType() { }

}

