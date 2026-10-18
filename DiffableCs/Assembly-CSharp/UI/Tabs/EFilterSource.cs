namespace UI.Tabs;

[Flags]
public enum EFilterSource
{
	None = 0,
	Items = 1,
	Description = 2,
	Trader = 4,
	Location = 8,
	Target = 16,
	Name = 32,
}

