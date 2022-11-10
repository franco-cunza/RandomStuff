// See https://aka.ms/new-console-template for more information
using AutoMapper;

var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile<MappingProfile>();
});

var mapper = config.CreateMapper();

var source = new Source("TheFoo", "TheBar");

var fooDest = mapper.Map<Destination>(source, opt => opt.Items["mapType"] = "Foo");
var barDest = mapper.Map<Destination>(source, opt => opt.Items["mapType"] = "Bar");

Console.WriteLine(fooDest);
Console.WriteLine(barDest);