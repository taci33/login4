using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using login4.Data.EF;
using login4.Pages.GestionUsuarios;

namespace login4.Models.EF;

public partial class IntranetSenasaData230209Context : IdentityDbContext
{
    public IntranetSenasaData230209Context()
    {
    }

    public IntranetSenasaData230209Context(DbContextOptions<IntranetSenasaData230209Context> options)
        : base(options)
    {
    }
    public virtual DbSet<EXT_adm_CL_Email_Update> EXT_adm_CL_Email_Updates { get; set; }
    public virtual DbSet<EXT_adm_CL_email_lookup> EXT_adm_CL_email_lookups { get; set; }
    public virtual DbSet<EXT_adm_CL_Tipos_lookup> EXT_adm_CL_Tipos_lookups { get; set; }
    public virtual DbSet<ext_adm_CL_Search> ext_adm_CL_Searchs { get; set; }
    public DbSet<appusuario> appusuario { get; set; }


   

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //Personaliza la longitud de las columnas de ASPnetusers
       
        modelBuilder.Entity<IdentityUser>(entity =>
        {
            entity.Property(u => u.PasswordHash).HasMaxLength(400);
            entity.Property(u => u.PhoneNumber).HasMaxLength(255);
            entity.Property(u => u.ConcurrencyStamp).HasMaxLength(400);
            entity.Property(u => u.SecurityStamp).HasMaxLength(400);
        });
        modelBuilder.Entity<appusuario>(entity =>
        {
            entity.Property(u => u.Nombre).HasMaxLength(255);
            entity.Property(u => u.RolAcceso).HasMaxLength(30);
            entity.Property(u => u.IDpersona).HasMaxLength(400);

        });



        modelBuilder.Entity<IdentityUser>().ToTable("ClientesUsers");
        modelBuilder.Entity<IdentityRole>().ToTable("clientesRole");
        modelBuilder.Entity<IdentityUserRole<string>>().ToTable("clientesUserRole");
        modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("clientesUserClaim");
        modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("clientesUserLogin");
        modelBuilder.Entity<IdentityUserToken<string>>().ToTable("clientesUsertoken");
        modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("clientesroleclaim");

        modelBuilder.Entity<ext_adm_CL_Search>(entity =>
        {
            entity.HasKey(e => e.IDPersona);

            entity.ToView("ext_adm_CL_Search"); //Indica que la entidad está mapeada a la vista ext_adm_CL_Search

            // Configura las propiedades correspondientes a las columnas de la vista
            entity.Property(e => e.IDPersona).HasColumnName("IDPersona");
            entity.Property(e => e.Nombre).HasColumnName("Nombre");
            entity.Property(e => e.NombreComercial).HasColumnName("NombreComercial");
            entity.Property(e => e.Telefono).HasColumnName("Telefono");
            entity.Property(e => e.Fax).HasColumnName("Fax");
            entity.Property(e => e.CIF_NIF).HasColumnName("CIF_NIF");
            entity.Property(e => e.Email).HasColumnName("Email");
            entity.Property(e => e.PaginaWeb).HasColumnName("PaginaWeb");
            entity.Property(e => e.UsuarioRegistrado).HasColumnName("UsuarioRegistrado");
            entity.Property(e => e.TipoDeCliente).HasColumnName("Tipo de Cliente");
            entity.Property(e => e.TipoID).HasColumnName("TipoID");
            entity.Property(e => e.LockoutEnabled).HasColumnName("LockoutEnabled");
            entity.Property(e => e.EmailConfirmed).HasColumnName("EmailConfirmed");
            entity.Property(e => e.EXT_Email).HasColumnName("EXT_Email");

        });

        modelBuilder.Entity<EXT_adm_CL_Email_Update>(entity =>
        {
            entity.HasNoKey();
            entity.ToFunction("EXT_adm_CL_Email_Update");
        });

        modelBuilder.Entity<EXT_adm_CL_Tipos_lookup>(entity =>
        {
            entity.HasKey(e => e.IDTipo);

            entity.ToView("EXT_adm_CL_Tipos_lookup"); //Indica que la entidad está mapeada a la vista ext_adm_CL_Search

            // Configura las propiedades correspondientes a las columnas de la vista
            entity.Property(e => e.IDTipo).HasColumnName("IDTipo");
            entity.Property(e => e.Nombre).HasColumnName("Nombre");
           
        });
        modelBuilder.Entity<EXT_adm_CL_email_lookup>(entity =>
        {
            entity.HasKey(e => e.IDContacto);

            entity.ToView("EXT_adm_CL_email_lookup"); //Indica que la entidad está mapeada a la vista ext_adm_CL_Search

            // Configura las propiedades correspondientes a las columnas de la vista
            entity.Property(e => e.IDContacto).HasColumnName("IDContacto");
            entity.Property(e => e.Email).HasColumnName("Email");
            entity.Property(e => e.Descripcion).HasColumnName("Descripcion");
        });

     

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
