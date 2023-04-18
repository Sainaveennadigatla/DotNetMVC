using Microsoft.EntityFrameworkCore;
using MinimalShoppingListApi;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApiDbContext>(opt => opt.UseInMemoryDatabase("ShoppingListApi"));

var app = builder.Build();

app.MapGet("/shoppingList", async (ApiDbContext db) =>
await db.Groceries.ToListAsync());

app.MapPost("/shoppingList", async (Grocery grocery, ApiDbContext db) =>
{
    db.Groceries.Add(grocery);
    await db.SaveChangesAsync();
    return Results.Created($"/shoppingList/{grocery.Id}", grocery);
});

app.MapGet("/ShoppingItem/{id}", async (int Id, ApiDbContext db) =>
{
    var grocery = await db.Groceries.FindAsync(Id); 
    return grocery;
});

app.MapDelete("/ShoppingItem/{id}", async (int Id, ApiDbContext db) =>
{
    var grocery = await db.Groceries.FindAsync(Id);
    if(grocery!=null)
    {
        db.Groceries.Remove(grocery);
        await db.SaveChangesAsync();
        return Results.NoContent();
    }
    return Results.NotFound();
    
});
app.MapPut("/ShoppingItem/{id}", async (int Id,Grocery grocery, ApiDbContext db) =>
{
    var updategrocery = await db.Groceries.FindAsync(Id);
    if (updategrocery != null)
    {
        updategrocery.Name = grocery.Name;
        updategrocery.Purchased = grocery.Purchased;
        await db.SaveChangesAsync();
        return Results.Ok(updategrocery);
    }
    return Results.NotFound();

});

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.Run();

  