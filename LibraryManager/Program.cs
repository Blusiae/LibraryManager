using LibraryManager;
using LibraryManager.Database;
using LibraryManager.Domain;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer("Server=.;Database=LibraryManagerDB;Trusted_Connection=True;"));

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

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    dbContext.Database.Migrate();
}

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
