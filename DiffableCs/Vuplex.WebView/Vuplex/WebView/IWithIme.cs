namespace Vuplex.WebView;

public interface IWithIme
{

	public event EventHandler ImeInputFieldPositionChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	public void add_ImeInputFieldPositionChanged(EventHandler value) { }

	public void CancelImeComposition() { }

	public void FinishImeComposition(string text) { }

	[CompilerGenerated]
	public void remove_ImeInputFieldPositionChanged(EventHandler value) { }

	public void SetImeComposition(string text) { }

}

