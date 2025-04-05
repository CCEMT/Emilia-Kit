namespace Emilia.Kit
{
    public interface IObjectDescriptionGetter
    {
        string GetDescription(object obj, object owner, object userData);
    }
}