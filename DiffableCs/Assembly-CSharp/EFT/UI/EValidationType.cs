namespace EFT.UI;

[Flags]
public enum EValidationType
{
	Numbers = 1,
	Latin = 2,
	AnyWordChars = 4,
	Space = 8,
	Hyphen = 16,
	Underscore = 32,
	Period = 64,
	Comma = 128,
	Slash = 256,
	Brackets = 512,
	Exclamation = 1024,
	Question = 2048,
	Quotes = 4096,
	At = 8192,
	Colons = 16384,
	Math = 33552,
	Separator = 65536,
	And = 131072,
	Dollar = 262144,
	NumSign = 524288,
	NewLine = 1048576,
	NotStartWithSpace = 2097152,
	NotEndWithSpace = 4194304,
	Everything = -1,
	NickName = 51,
	BuildName = 6291515,
	Punctuation = 23744,
	AllSymbols = 1048568,
	Notes = 2097151,
	SearchField = 1048573,
}

