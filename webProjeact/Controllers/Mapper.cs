using AutoMapper;
using Entity;
using DTO;


namespace webProjeact.Controllers
{
    public class Mapper:Profile
    {
        public Mapper()
        {  
            CreateMap<Product, ProductDTO>().ForMember(dest=>dest.CategoryName,src=>src.MapFrom(p=>p.CategoryNavigation.CategoryName))
            .ReverseMap();
            CreateMap<Order, OrderDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ForMember(dest=> dest.ProductsAmount,src=>src.MapFrom(c=>c.Products.Count())).ReverseMap();
            CreateMap<User, UserSaveDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();

        }
    }
}
