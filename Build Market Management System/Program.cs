using Plugins.DataStore.InMemory;
using UseCases.CategoriesUseCases;
using UseCases.DataStorePluginInterfaces;
using UseCases.Interfaces;
using UseCases.ProductsUseCases;
using UseCases.TransactionsUseCases;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<ICategoryRepository, CategoriesInMemoryRepository>();
builder.Services.AddSingleton<IProductRepository, ProductsInMemoryRepository>();
builder.Services.AddSingleton<ITransactionRepository, TransactionsInMemoryRepository>();


builder.Services.AddTransient<IViewCategoriesUseCase, ViewCategoriesUseCase>();
builder.Services.AddTransient<IViewSelectedCategoryUseCase, ViewSelectedCategoryUseCase>();
builder.Services.AddTransient<IEditCategoryUseCase, EditCategoryUseCase>();
builder.Services.AddTransient<IAddCategoryUseCase, AddCategoryUseCase>();
builder.Services.AddTransient<IDeleteCategoryUseCase, DeleteCategoryUseCase>();

builder.Services.AddTransient<IAddProductUseCase, AddProductUseCase>();
builder.Services.AddTransient<IEditProductUseCase, EditProductUseCase>();
builder.Services.AddTransient<IDeleteProductUseCase, DeleteProductUseCase>();
builder.Services.AddTransient<IViewProductsUseCase, ViewProductsUseCase>();
builder.Services.AddTransient<IViewSelectedProductUseCase, ViewSelectedProductUseCase>();
builder.Services.AddTransient<IViewProductsInCategoryUseCase, ViewProductsInCategoryUseCase>();
builder.Services.AddTransient<ISellProductsUseCase, SellProductsUseCase>();
builder.Services.AddTransient<IDecreaseProductQuantityUseCase, DecreaseProductQuantityUseCase>();

builder.Services.AddTransient<IRecordTransactionUseCase, RecordTransactionUseCase>();
builder.Services.AddTransient<ISearchTransactionsUseCase, SearchTransactionsUseCase>();
builder.Services.AddTransient<IGetTodayTransactionUseCase, GetTodayTransactionUseCase>();


var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
