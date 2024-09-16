using System;
using System.Collections.Generic;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public partial class DbFirstContext : DbContext
{
    public DbFirstContext()
    {
    }

    public DbFirstContext(DbContextOptions<DbFirstContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ciudad> Ciudades { get; set; }

    public virtual DbSet<Contactopersona> Contactopersonas { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<Detallemovinventario> Detallemovinventarios { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<Formapago> Formapagos { get; set; }

    public virtual DbSet<Inventario> Inventarios { get; set; }

    public virtual DbSet<Marca> Marcas { get; set; }

    public virtual DbSet<Movimientoinventario> Movimientoinventarios { get; set; }

    public virtual DbSet<Pais> Paises { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Presentacion> Presentacions { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Rolpersona> Rolpersonas { get; set; }

    public virtual DbSet<Tipocontacto> Tipocontactos { get; set; }

    public virtual DbSet<Tipodocumento> Tipodocumentos { get; set; }

    public virtual DbSet<Tipomovinventario> Tipomovinventarios { get; set; }

    public virtual DbSet<Tipopersona> Tipopersonas { get; set; }

    public virtual DbSet<Ubicacionpersona> Ubicacionpersonas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;user=root;password=10150325;database=apolo2023", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.34-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb3_general_ci")
            .HasCharSet("utf8mb3");

        modelBuilder.Entity<Ciudad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("ciudad");

            entity.HasIndex(e => e.IddepartamentoFk, "FK_iddepartamento");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IddepartamentoFk).HasColumnName("iddepartamentoFk");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IddepartamentoFkNavigation).WithMany(p => p.Ciudades)
                .HasForeignKey(d => d.IddepartamentoFk)
                .HasConstraintName("FK_iddepartamento");
        });

        modelBuilder.Entity<Contactopersona>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("contactopersona");

            entity.HasIndex(e => e.IdPersona, "FK_idPersonaContacto");

            entity.HasIndex(e => e.IdTipoContacto, "FK_idTipoContacto");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdPersona)
                .HasMaxLength(20)
                .HasColumnName("idPersona");
            entity.Property(e => e.IdTipoContacto).HasColumnName("idTipoContacto");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Contactopersonas)
                .HasForeignKey(d => d.IdPersona)
                .HasConstraintName("FK_idPersonaContacto");

            entity.HasOne(d => d.IdTipoContactoNavigation).WithMany(p => p.Contactopersonas)
                .HasForeignKey(d => d.IdTipoContacto)
                .HasConstraintName("FK_idTipoContacto");
        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("departamento");

            entity.HasIndex(e => e.IdpaisFk, "FK_idpais");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdpaisFk).HasColumnName("idpaisFk");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdpaisFkNavigation).WithMany(p => p.Departamentos)
                .HasForeignKey(d => d.IdpaisFk)
                .HasConstraintName("FK_idpais");
        });

        modelBuilder.Entity<Detallemovinventario>(entity =>
        {
            entity.HasKey(e => new { e.IdInventario, e.IdMovInv })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("detallemovinventario");

            entity.HasIndex(e => e.IdMovInv, "FK_idMovInv");

            entity.Property(e => e.IdInventario)
                .HasMaxLength(10)
                .HasColumnName("idInventario");
            entity.Property(e => e.IdMovInv)
                .HasMaxLength(10)
                .HasColumnName("idMovInv");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.Precio)
                .HasColumnType("double(11,2)")
                .HasColumnName("precio");

            entity.HasOne(d => d.IdInventarioNavigation).WithMany(p => p.Detallemovinventarios)
                .HasForeignKey(d => d.IdInventario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_idInventario");

            entity.HasOne(d => d.IdMovInvNavigation).WithMany(p => p.Detallemovinventarios)
                .HasForeignKey(d => d.IdMovInv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_idMovInv");
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("factura");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FacturaActual).HasColumnName("facturaActual");
            entity.Property(e => e.FacturaFinal).HasColumnName("facturaFinal");
            entity.Property(e => e.FacturaInicial).HasColumnName("facturaInicial");
            entity.Property(e => e.NroResolucion)
                .HasMaxLength(10)
                .HasColumnName("nroResolucion");
        });

        modelBuilder.Entity<Formapago>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("formapago");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Inventario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("inventario");

            entity.HasIndex(e => e.CodProducto, "FK_CodProducto");

            entity.HasIndex(e => e.Idpresentacion, "FK_idpresentacion");

            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .HasColumnName("id");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(10)
                .HasColumnName("codProducto");
            entity.Property(e => e.Idpresentacion).HasColumnName("idpresentacion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
            entity.Property(e => e.Precio)
                .HasColumnType("double(11,2)")
                .HasColumnName("precio");
            entity.Property(e => e.Stock).HasColumnName("stock");
            entity.Property(e => e.StockMax).HasColumnName("stockMax");
            entity.Property(e => e.StockMin).HasColumnName("stockMin");

            entity.HasOne(d => d.CodProductoNavigation).WithMany(p => p.Inventarios)
                .HasForeignKey(d => d.CodProducto)
                .HasConstraintName("FK_CodProducto");

            entity.HasOne(d => d.IdpresentacionNavigation).WithMany(p => p.Inventarios)
                .HasForeignKey(d => d.Idpresentacion)
                .HasConstraintName("FK_idpresentacion");
        });

        modelBuilder.Entity<Marca>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("marca");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Movimientoinventario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("movimientoinventario");

            entity.HasIndex(e => e.IdReceptor, "FK_idReceptor");

            entity.HasIndex(e => e.IdResponsable, "FK_idResponsable");

            entity.HasIndex(e => e.IdtipoMovInv, "fk_idTipoMovInv");

            entity.HasIndex(e => e.IdFormaPago, "idFormaPago");

            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .HasColumnName("id");
            entity.Property(e => e.FechaMovimiento).HasColumnName("fechaMovimiento");
            entity.Property(e => e.FechaVencimiento).HasColumnName("fechaVencimiento");
            entity.Property(e => e.IdFormaPago).HasColumnName("idFormaPago");
            entity.Property(e => e.IdReceptor)
                .HasMaxLength(20)
                .HasColumnName("idReceptor");
            entity.Property(e => e.IdResponsable)
                .HasMaxLength(20)
                .HasColumnName("idResponsable");
            entity.Property(e => e.IdtipoMovInv).HasColumnName("idtipoMovInv");

            entity.HasOne(d => d.IdFormaPagoNavigation).WithMany(p => p.Movimientoinventarios)
                .HasForeignKey(d => d.IdFormaPago)
                .HasConstraintName("movimientoinventario_ibfk_1");

            entity.HasOne(d => d.IdReceptorNavigation).WithMany(p => p.MovimientoinventarioIdReceptorNavigations)
                .HasForeignKey(d => d.IdReceptor)
                .HasConstraintName("FK_idReceptor");

            entity.HasOne(d => d.IdResponsableNavigation).WithMany(p => p.MovimientoinventarioIdResponsableNavigations)
                .HasForeignKey(d => d.IdResponsable)
                .HasConstraintName("FK_idResponsable");

            entity.HasOne(d => d.IdtipoMovInvNavigation).WithMany(p => p.Movimientoinventarios)
                .HasForeignKey(d => d.IdtipoMovInv)
                .HasConstraintName("fk_idTipoMovInv");
        });

        modelBuilder.Entity<Pais>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("pais");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("persona");

            entity.HasIndex(e => e.IdDocumento, "Fk_idDocumento");

            entity.HasIndex(e => e.IdRolPersona, "Fk_idRolPersona");

            entity.HasIndex(e => e.IdTipoPersona, "Fk_idTipoPersona");

            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .HasColumnName("id");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.IdDocumento).HasColumnName("idDocumento");
            entity.Property(e => e.IdRolPersona).HasColumnName("idRolPersona");
            entity.Property(e => e.IdTipoPersona).HasColumnName("idTipoPersona");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.Personas)
                .HasForeignKey(d => d.IdDocumento)
                .HasConstraintName("Fk_idDocumento");

            entity.HasOne(d => d.IdRolPersonaNavigation).WithMany(p => p.Personas)
                .HasForeignKey(d => d.IdRolPersona)
                .HasConstraintName("Fk_idRolPersona");

            entity.HasOne(d => d.IdTipoPersonaNavigation).WithMany(p => p.Personas)
                .HasForeignKey(d => d.IdTipoPersona)
                .HasConstraintName("Fk_idTipoPersona");
        });

        modelBuilder.Entity<Presentacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("presentacion");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Cod).HasName("PRIMARY");

            entity.ToTable("producto");

            entity.HasIndex(e => e.Idmarca, "Fk_idmarca");

            entity.Property(e => e.Cod)
                .HasMaxLength(10)
                .HasColumnName("cod");
            entity.Property(e => e.Idmarca).HasColumnName("idmarca");
            entity.Property(e => e.NombreProd)
                .HasMaxLength(100)
                .HasColumnName("nombreProd");

            entity.HasOne(d => d.IdmarcaNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.Idmarca)
                .HasConstraintName("Fk_idmarca");
        });

        modelBuilder.Entity<Rolpersona>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("rolpersona");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Tipocontacto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tipocontacto");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Tipodocumento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tipodocumento");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Tipomovinventario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tipomovinventario");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Tipopersona>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tipopersona");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Ubicacionpersona>(entity =>
        {
            entity.HasKey(e => e.IdDireccion).HasName("PRIMARY");

            entity.ToTable("ubicacionpersona");

            entity.HasIndex(e => e.IdCiudad, "FK_idCiudad");

            entity.HasIndex(e => e.IdPersona, "FK_idPersona");

            entity.Property(e => e.IdDireccion).HasColumnName("idDireccion");
            entity.Property(e => e.Bis)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("bis");
            entity.Property(e => e.Cardinal)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("cardinal");
            entity.Property(e => e.CardinalSec)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("cardinalSec");
            entity.Property(e => e.Complemento)
                .HasMaxLength(50)
                .HasColumnName("complemento");
            entity.Property(e => e.IdCiudad).HasColumnName("idCiudad");
            entity.Property(e => e.IdPersona)
                .HasMaxLength(20)
                .HasColumnName("idPersona");
            entity.Property(e => e.Letra)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("letra");
            entity.Property(e => e.LetraSec)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("letraSec");
            entity.Property(e => e.LetraTer)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("letraTer");
            entity.Property(e => e.NumeroPri).HasColumnName("numeroPri");
            entity.Property(e => e.NumeroSec).HasColumnName("numeroSec");
            entity.Property(e => e.NumeroTer).HasColumnName("numeroTer");
            entity.Property(e => e.TipoDeVia)
                .HasMaxLength(50)
                .HasColumnName("tipoDeVia");

            entity.HasOne(d => d.IdCiudadNavigation).WithMany(p => p.Ubicacionpersonas)
                .HasForeignKey(d => d.IdCiudad)
                .HasConstraintName("FK_idCiudad");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Ubicacionpersonas)
                .HasForeignKey(d => d.IdPersona)
                .HasConstraintName("FK_idPersona");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
