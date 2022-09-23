using NYTBestseller.Domain.Interfaces;
using NYTBestsellers.Infrastructure;
using MediatR;
using NYTBestsellers.Application.Application.Queries.GetBestsellerCategories;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddRazorPages();
        builder.Services.AddControllers();
        builder.Services.AddControllersWithViews();
        builder.Services.AddHttpClient();
        builder.Services.AddSingleton<IBooksApiService, BooksApiService>();
        builder.Services.AddSwaggerGen();
        builder.Services.AddMediatR(typeof(GetBestsellerCategoriesQueryHandler).Assembly);

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapRazorPages();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });

        app.Run();
    }
}