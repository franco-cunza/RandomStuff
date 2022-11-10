using AutoMapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Source, Destination>()
            .ForMember(dest => dest.FooBar, opt =>
                opt.MapFrom((src, dest, destMember, context) =>
                {
                    var mapType = context.Items["mapType"].ToString();

                    if (mapType == "Foo") return src.Foo;
                    if (mapType == "Bar") return src.Bar;

                    return string.Empty;
                }));
    }
}