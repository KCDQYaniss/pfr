namespace System.Resources;

internal interface IResourceGroveler
{

	public ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary localResourceSets, bool tryParents, bool createIfNotExists, ref StackCrawlMark stackMark) { }

}

