namespace Vuplex.WebView;

public class StandalonePdfOptions
{
	public bool Landscape; //Field offset: 0x10
	public float MarginBottom; //Field offset: 0x14
	public float MarginLeft; //Field offset: 0x18
	public float MarginRight; //Field offset: 0x1C
	public float MarginTop; //Field offset: 0x20
	public StandalonePdfMarginType MarginType; //Field offset: 0x24
	public string PageRanges; //Field offset: 0x28
	public float PaperHeight; //Field offset: 0x30
	public float PaperWidth; //Field offset: 0x34
	public bool PreferCssPageSize; //Field offset: 0x38
	public bool PrintBackground; //Field offset: 0x39
	public float Scale; //Field offset: 0x3C

	public StandalonePdfOptions() { }

	public string ToJson() { }

	public virtual string ToString() { }

}

