using LibraryManager;
using LibraryManager.Database;
using LibraryManager.Domain;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews()
                .AddViewLocalization();
builder.Services.AddDbContext<ApplicationDbContext>(
    options => options.UseLazyLoadingProxies()
                      .UseSqlServer("Server=.;Database=LibraryManagerDB;Trusted_Connection=True;"));

#region repositories
builder.Services.AddTransient<IBookRepository, BookRepository>();
builder.Services.AddTransient<IAuthorRepository, AuthorRepository>();
builder.Services.AddTransient<IReaderRepository, ReaderRepository>();
builder.Services.AddTransient<IBorrowRepository, BorrowRepository>();
#endregion
#region managers
builder.Services.AddTransient<IBookManager, BookManager>();
builder.Services.AddTransient<IAuthorManager, AuthorManager>();
builder.Services.AddTransient<IReaderManager, ReaderManager>();
builder.Services.AddTransient<IBorrowManager, BorrowManager>();
#endregion
#region mappers
builder.Services.AddTransient<DtoMapper>();
builder.Services.AddTransient<ViewModelMapper>();
#endregion

builder.Services.AddLocalization(options =>
{
    options.ResourcesPath = "Resources";
});

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    options.DefaultRequestCulture = new RequestCulture("en-US");

    var cultures = new CultureInfo[]
    {
        new CultureInfo("pl-PL")
    };

    options.SupportedCultures = cultures;
    options.SupportedUICultures = cultures;
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseRequestLocalization();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    dbContext.Database.Migrate();
}

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
