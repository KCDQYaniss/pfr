namespace EFT;

public sealed class LocationExportInfo : MonoBehaviour
{
	[SerializeField]
	public long _unixDateTime; //Field offset: 0x20

	public DateTime DateTime
	{
		 get { } //Length: 87
		 set { } //Length: 155
	}

	public LocationExportInfo() { }

	public DateTime get_DateTime() { }

	public void set_DateTime(DateTime value) { }

}

