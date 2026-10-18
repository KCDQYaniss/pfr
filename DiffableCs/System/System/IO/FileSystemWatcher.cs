namespace System.IO;

[DefaultEvent("Changed")]
[IODescription(null)]
public class FileSystemWatcher : Component, ISupportInitialize
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass70_0
	{
		public FileSystemWatcher <>4__this; //Field offset: 0x10
		public string filename; //Field offset: 0x18

		public <>c__DisplayClass70_0() { }

		internal void <DispatchEvents>b__0() { }

		internal void <DispatchEvents>b__1() { }

		internal void <DispatchEvents>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass70_1
	{
		public RenamedEventArgs renamed_ref; //Field offset: 0x10
		public <>c__DisplayClass70_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass70_1() { }

		internal void <DispatchEvents>b__3() { }

	}

	private enum EventType
	{
		FileSystemEvent = 0,
		ErrorEvent = 1,
		RenameEvent = 2,
	}

	private static object lockobj; //Field offset: 0x0
	private bool inited; //Field offset: 0x28
	private bool start_requested; //Field offset: 0x29
	private bool enableRaisingEvents; //Field offset: 0x2A
	private string filter; //Field offset: 0x30
	private bool includeSubdirectories; //Field offset: 0x38
	private int internalBufferSize; //Field offset: 0x3C
	private NotifyFilters notifyFilter; //Field offset: 0x40
	private string path; //Field offset: 0x48
	private string fullpath; //Field offset: 0x50
	private ISynchronizeInvoke synchronizingObject; //Field offset: 0x58
	private WaitForChangedResult lastData; //Field offset: 0x60
	private bool waiting; //Field offset: 0x80
	private SearchPattern2 pattern; //Field offset: 0x88
	private bool disposed; //Field offset: 0x90
	private string mangledFilter; //Field offset: 0x98
	private IFileWatcher watcher; //Field offset: 0xA0
	private object watcher_handle; //Field offset: 0xA8
	[CompilerGenerated]
	private FileSystemEventHandler Changed; //Field offset: 0xB0
	[CompilerGenerated]
	private FileSystemEventHandler Created; //Field offset: 0xB8
	[CompilerGenerated]
	private FileSystemEventHandler Deleted; //Field offset: 0xC0
	[CompilerGenerated]
	private ErrorEventHandler Error; //Field offset: 0xC8
	[CompilerGenerated]
	private RenamedEventHandler Renamed; //Field offset: 0xD0

	[IODescription("Occurs when a file/directory change matches the filter")]
	public event FileSystemEventHandler Changed
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	[IODescription("Occurs when a file/directory creation matches the filter")]
	public event FileSystemEventHandler Created
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	[IODescription("Occurs when a file/directory deletion matches the filter")]
	public event FileSystemEventHandler Deleted
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	[Browsable(False)]
	public event ErrorEventHandler Error
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	[IODescription("Occurs when a file/directory rename matches the filter")]
	public event RenamedEventHandler Renamed
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	[DefaultValue(False)]
	[IODescription("Flag to indicate if this instance is active")]
	public bool EnableRaisingEvents
	{
		 get { } //Length: 5
		 set { } //Length: 173
	}

	[DefaultValue("*.*")]
	[IODescription("File name filter pattern")]
	[SettingsBindable(True)]
	[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public string Filter
	{
		 get { } //Length: 76
		 set { } //Length: 635
	}

	internal string FullPath
	{
		internal get { } //Length: 299
	}

	[DefaultValue(False)]
	[IODescription("Flag to indicate we want to watch subdirectories")]
	public bool IncludeSubdirectories
	{
		 get { } //Length: 5
		 set { } //Length: 55
	}

	[Browsable(False)]
	[DefaultValue(8192)]
	public int InternalBufferSize
	{
		 get { } //Length: 4
		 set { } //Length: 61
	}

	internal string MangledFilter
	{
		internal get { } //Length: 153
	}

	[DefaultValue(19)]
	[IODescription("Flag to indicate which change event we want to monitor")]
	public NotifyFilters NotifyFilter
	{
		 get { } //Length: 4
		 set { } //Length: 51
	}

	[DefaultValue(null)]
	[Editor("System.Diagnostics.Design.FSWPathEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[IODescription("The directory to monitor")]
	[SettingsBindable(True)]
	[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public string Path
	{
		 get { } //Length: 5
		 set { } //Length: 605
	}

	internal SearchPattern2 Pattern
	{
		internal get { } //Length: 344
	}

	[Browsable(False)]
	public virtual ISite Site
	{
		 get { } //Length: 5
		 set { } //Length: 236
	}

	[Browsable(False)]
	[DefaultValue(null)]
	[IODescription("The object used to marshal the event handler calls resulting from a directory change")]
	public ISynchronizeInvoke SynchronizingObject
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	internal bool Waiting
	{
		internal get { } //Length: 8
		internal set { } //Length: 7
	}

	private static FileSystemWatcher() { }

	public FileSystemWatcher(string path, string filter) { }

	public FileSystemWatcher() { }

	public FileSystemWatcher(string path) { }

	[CompilerGenerated]
	public void add_Changed(FileSystemEventHandler value) { }

	[CompilerGenerated]
	public void add_Created(FileSystemEventHandler value) { }

	[CompilerGenerated]
	public void add_Deleted(FileSystemEventHandler value) { }

	[CompilerGenerated]
	public void add_Error(ErrorEventHandler value) { }

	[CompilerGenerated]
	public void add_Renamed(RenamedEventHandler value) { }

	public override void BeginInit() { }

	internal void DispatchErrorEvents(ErrorEventArgs args) { }

	internal void DispatchEvents(FileAction act, string filename, ref RenamedEventArgs renamed) { }

	protected virtual void Dispose(bool disposing) { }

	public override void EndInit() { }

	protected virtual void Finalize() { }

	public bool get_EnableRaisingEvents() { }

	public string get_Filter() { }

	internal string get_FullPath() { }

	public bool get_IncludeSubdirectories() { }

	public int get_InternalBufferSize() { }

	internal string get_MangledFilter() { }

	public NotifyFilters get_NotifyFilter() { }

	public string get_Path() { }

	internal SearchPattern2 get_Pattern() { }

	public virtual ISite get_Site() { }

	public ISynchronizeInvoke get_SynchronizingObject() { }

	internal bool get_Waiting() { }

	private void InitWatcher() { }

	private static int InternalSupportsFSW() { }

	protected void OnChanged(FileSystemEventArgs e) { }

	protected void OnCreated(FileSystemEventArgs e) { }

	protected void OnDeleted(FileSystemEventArgs e) { }

	protected void OnError(ErrorEventArgs e) { }

	protected void OnRenamed(RenamedEventArgs e) { }

	private void RaiseEvent(Delegate ev, EventArgs arg, EventType evtype) { }

	[CompilerGenerated]
	public void remove_Changed(FileSystemEventHandler value) { }

	[CompilerGenerated]
	public void remove_Created(FileSystemEventHandler value) { }

	[CompilerGenerated]
	public void remove_Deleted(FileSystemEventHandler value) { }

	[CompilerGenerated]
	public void remove_Error(ErrorEventHandler value) { }

	[CompilerGenerated]
	public void remove_Renamed(RenamedEventHandler value) { }

	public void set_EnableRaisingEvents(bool value) { }

	public void set_Filter(string value) { }

	public void set_IncludeSubdirectories(bool value) { }

	public void set_InternalBufferSize(int value) { }

	public void set_NotifyFilter(NotifyFilters value) { }

	public void set_Path(string value) { }

	public virtual void set_Site(ISite value) { }

	public void set_SynchronizingObject(ISynchronizeInvoke value) { }

	internal void set_Waiting(bool value) { }

	[Conditional("DEBUG")]
	[Conditional("TRACE")]
	private void ShowWatcherInfo() { }

	private void Start() { }

	private void Stop() { }

	public WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType, int timeout) { }

	public WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType) { }

}

