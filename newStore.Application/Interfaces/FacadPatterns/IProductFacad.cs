using newStore.Application.Services.Products.Commands.AddNewCategory;
using newStore.Application.Services.Products.Queries.GetCategories;

using newStore.Application.Services.Products.Commands.AddNewCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using newStore.Application.Services.Products.Commands.AddNewProduct;
using newStore.Application.Services.Products.Queries.GetAllCategories;
using newStore.Application.Services.Products.Queries.GetProductForAdmin;
using newStore.Application.Services.Products.Queries.GetProductDetailForAdmin;
using newStore.Application.Services.Products.Queries.GetProductForSite;
using newStore.Application.Services.Products.Queries.GetProductDetailForSite;
using newStore.Application.Services.Products.Commands.DeleteProductForAdmin;
using newStore.Application.Services.Users.Commands.EditProductForAdmin;

namespace newStore.Application.Interfaces.FacadPatterns
{
    public interface IProductFacad
    {
        AddNewCategoryService AddNewCategoryService { get; }
        IGetCategoriesService GetCategoriesService { get; }
        AddNewProductService AddNewProductService { get; }
        IGetAllCategoriesService GetAllCategoriesService { get; }
        IGetProductForAdminService GetProductForAdminService { get; }

        IGetProductDetailForAdminService GetProductDetailForAdminService { get; }

        IGetProductForSiteService GetProductForSiteService { get; }
        IGetProductDetailForSiteService GetProductDetailForSiteService { get; }

        IDeleteProductForAdminService DeleteProductForAdminService { get; }

        IEditProductForAdminService EditProductForAdminService { get; }


    }
}
