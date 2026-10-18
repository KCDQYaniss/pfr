namespace FilesChecker;

[Flags]
public enum ConsistencyEnsuranceMode
{
	Skip = 0,
	Availability = 1,
	Size = 2,
	Checksum = 4,
	Fast = 3,
	Full = 7,
}

