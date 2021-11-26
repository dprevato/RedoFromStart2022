using System.Configuration;
using System.Reflection;
using System.Runtime.CompilerServices;
using Domain;
using Domain.Helpers;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace DataAccess;

public class RfsContext : DbContext
{
    #region DbSets definitions
    public DbSet<AppUser> AppUser { get; set; }
    public DbSet<Area> Area { get; set; }
    public DbSet<Chart> Chart { get; set; }
    public DbSet<ChartDoc> ChartDoc { get; set; }
    public DbSet<ChartNote> ChartNote { get; set; }
    public DbSet<ChartSeries> ChartSeries { get; set; }
    public DbSet<Device> Device { get; set; }
    public DbSet<DeviceDetail> DeviceDetail { get; set; }
    public DbSet<DevKind> DevKind { get; set; }
    public DbSet<DevSubkind> DevSubkind { get; set; }
    public DbSet<Formula> Formula { get; set; }
    public DbSet<FormulaArgument> FormulaArgument { get; set; }
    public DbSet<Journal> Journal { get; set; }
    public DbSet<MetaDictionary> MetaDictionary { get; set; }
    public DbSet<Pdm> Pdm { get; set; }
    public DbSet<Person> Person { get; set; }
    public DbSet<PersonPlant> PersonPlant { get; set; }
    public DbSet<Plant> Plant { get; set; }
    public DbSet<PlantDetail> PlantDetail { get; set; }
    public DbSet<PreImport> PreImport { get; set; }
    public DbSet<Reading> Reading { get; set; }
    public DbSet<StatusHistory> StatusHistory { get; set; }
    public DbSet<TechData> TechData { get; set; }

    #endregion DbSets definitions

    static RfsContext() {
        NpgsqlConnection.GlobalTypeMapper.MapEnum<Grants>();
        NpgsqlConnection.GlobalTypeMapper.MapEnum<StatusValues>();
        NpgsqlConnection.GlobalTypeMapper.MapEnum<ChartSeriesTypes>();
        NpgsqlConnection.GlobalTypeMapper.MapEnum<NoteAlignment>();
    }
    #region Overrides of DbContext

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseNpgsql(ConfigurationManager.ConnectionStrings["NpgSqlLocalDb"].ConnectionString, options => {
            options.UseAdminDatabase("postgres");
            options.SetPostgresVersion(13, 4);
            options.UseNodaTime();
            options.EnableRetryOnFailure();
        });
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.UseIdentityByDefaultColumns();
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    #endregion
}