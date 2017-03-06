namespace MountainBlog.Common.Mapping
{
    using AutoMapper;

    public interface IHaveCustomMappings
    {
        void CreateMappings(IMapperConfiguration configuration);
    }
}
