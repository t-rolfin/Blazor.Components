namespace Rolfin.Blazor.Components.Shared;

public class FileDetails
{
    public FileDetails() { }
    public FileDetails(Guid id, string name, long size, FileState fileState, byte[] content)
    {
        Id = id;
        Name = name.Substring(0, name.LastIndexOf("."));
        Size = size;
        Extension = name.Substring(name.LastIndexOf(".") + 1);
        Content = content;
        FileState = fileState;

        SizeAsString = GetSizeAsString(size);
    }
    public FileDetails(Guid id, string name, long size, string extension, FileState fileState, byte[] content)
    {
        Id = id;
        Name = name;
        Size = size;
        Extension = extension;
        Content = content;
        FileState = fileState;

        SizeAsString = GetSizeAsString(size);
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public long Size { get; set; }
    public byte[] Content { get; set; }
    public string Extension { get; set; }
    public string SizeAsString { get; set; }
    public FileState FileState { get; set; }

    string GetSizeAsString(float size)
    {
        string[] sizes = { "B", "KB", "MB", "GB", "TB" };
        int order = 0;

        while (size >= 1024 && order < sizes.Length - 1)
        {
            order++;
            size = size / 1024;
        }

        return String.Format("{0:0.##} {1}", size, sizes[order]);
    }
}
