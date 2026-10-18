//Type is in global namespace

public class BackendException : Exception
{
	[CompilerGenerated]
	private string <ResponseText>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private double <DownloadSeconds>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private double <ParseSeconds>k__BackingField; //Field offset: 0xA0

	public double DownloadSeconds
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public double ParseSeconds
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public string ResponseText
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public BackendException(string message) { }

	public BackendException(string message, Exception innerException) { }

	[CompilerGenerated]
	public double get_DownloadSeconds() { }

	[CompilerGenerated]
	public double get_ParseSeconds() { }

	[CompilerGenerated]
	public string get_ResponseText() { }

	[CompilerGenerated]
	public void set_DownloadSeconds(double value) { }

	[CompilerGenerated]
	public void set_ParseSeconds(double value) { }

	[CompilerGenerated]
	public void set_ResponseText(string value) { }

	public virtual string ToString() { }

}

