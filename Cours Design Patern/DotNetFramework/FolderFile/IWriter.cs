namespace FolderFile
{
    public interface IWriter
    {
        void Write(IElement element);
        void Write(Folder element);
        void Write(Link element);
        void Write(File element);
    }
}