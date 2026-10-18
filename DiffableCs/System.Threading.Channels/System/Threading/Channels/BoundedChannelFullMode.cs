namespace System.Threading.Channels;

public enum BoundedChannelFullMode
{
	Wait = 0,
	DropNewest = 1,
	DropOldest = 2,
	DropWrite = 3,
}

