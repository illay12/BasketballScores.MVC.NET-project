using BasketballScores.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BasketballScores.Data;

public class ApplicationDbContext : IdentityDbContext<UserModel>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
    {   
    }
    
    public DbSet<ScoreBoard> ScoreBoards { get; set; }
    public DbSet<UserModel> UserModels { get; set; }
}
