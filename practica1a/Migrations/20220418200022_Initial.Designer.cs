﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using practica1a.Data;

namespace practica1a.Migrations
{
    [DbContext(typeof(practicaDbContext))]
    [Migration("20220418200022_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("practica1a.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TipoCategoria")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TipoCategoria = "harinas"
                        });
                });

            modelBuilder.Entity("practica1a.Models.Compra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("DetalleCompraId")
                        .HasColumnType("int");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("DetalleCompraId");

                    b.HasIndex("ProductoId");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("practica1a.Models.ComprasProveedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<int>("DetalleComprasProveedorId")
                        .HasColumnType("int");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Producto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("SubTotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("DetalleComprasProveedorId");

                    b.ToTable("ComprasProveedor");
                });

            modelBuilder.Entity("practica1a.Models.DetalleCompra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Archivo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fecha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<string>("Verificada")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("DetalleCompras");
                });

            modelBuilder.Entity("practica1a.Models.DetalleComprasProveedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FechaDeCompra")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProveedoresId")
                        .HasColumnType("int");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProveedoresId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("DetalleComprasProveedor");
                });

            modelBuilder.Entity("practica1a.Models.DetalleVenta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApellidoCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CedulaCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fecha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("DetalleVentas");
                });

            modelBuilder.Entity("practica1a.Models.Direcciones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Direcciones");
                });

            modelBuilder.Entity("practica1a.Models.HistorialCategoriaEliminada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Fecha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCategoriaEliminada")
                        .HasColumnType("int");

                    b.Property<string>("NombreCategoriaEliminada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("HistorialCategoriaEliminadas");
                });

            modelBuilder.Entity("practica1a.Models.HistorialDetalleCompraEliminada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Fecha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdDetalleCompraEliminada")
                        .HasColumnType("int");

                    b.Property<string>("NombreUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("HistorialDetalleCompraEliminadas");
                });

            modelBuilder.Entity("practica1a.Models.HistorialProductosEliminados", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Fecha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdProductoEliminado")
                        .HasColumnType("int");

                    b.Property<string>("NombreProductoEliminado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("HistorialProductosEliminados");
                });

            modelBuilder.Entity("practica1a.Models.HistorialProveedorEliminado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Fecha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdProveedorEliminado")
                        .HasColumnType("int");

                    b.Property<string>("NombreProveedorEliminado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("HistorialProveedorEliminados");
                });

            modelBuilder.Entity("practica1a.Models.HistorialUsuariosEliminados", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Fecha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdUsuarioEliminado")
                        .HasColumnType("int");

                    b.Property<string>("NombreUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreUsuarioEliminado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("HistorialUsuariosEliminados");
                });

            modelBuilder.Entity("practica1a.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("practica1a.Models.ProveedorCategoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<int>("ProveedorId")
                        .HasColumnType("int");

                    b.HasKey("CategoriaId", "ProveedorId");

                    b.HasIndex("ProveedorId");

                    b.ToTable("ProveedorCategorias");
                });

            modelBuilder.Entity("practica1a.Models.Proveedores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Empresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rif")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Rif")
                        .IsUnique()
                        .HasFilter("[Rif] IS NOT NULL");

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("practica1a.Models.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rols");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Tipo = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Tipo = "Cliente"
                        },
                        new
                        {
                            Id = 3,
                            Tipo = "Empleado"
                        });
                });

            modelBuilder.Entity("practica1a.Models.RolUsuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.HasKey("UsuarioId", "RolId");

                    b.HasIndex("RolId");

                    b.ToTable("RolsUsuarios");

                    b.HasData(
                        new
                        {
                            UsuarioId = 1,
                            RolId = 1
                        });
                });

            modelBuilder.Entity("practica1a.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("UsuarioSessionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Username")
                        .IsUnique()
                        .HasFilter("[Username] IS NOT NULL");

                    b.HasIndex("UsuarioSessionId")
                        .IsUnique()
                        .HasFilter("[UsuarioSessionId] IS NOT NULL");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellido = "Granados",
                            Direccion = "La concordia",
                            Foto = "data:image/jpeg;base64,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",
                            Nombre = "Jesus",
                            Password = "$2a$11$atoNmsDhyF2RIqlir32g/O/PamCxrKc..rwxIMFDrQpGfHWzQRyWm",
                            Username = "jesus",
                            UsuarioSessionId = 1
                        });
                });

            modelBuilder.Entity("practica1a.Models.UsuarioSession", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RolId");

                    b.ToTable("UsuariosSessions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RolId = 1,
                            UsuarioId = 1
                        });
                });

            modelBuilder.Entity("practica1a.Models.Venta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("DetalleVentaId")
                        .HasColumnType("int");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("DetalleVentaId");

                    b.HasIndex("ProductoId");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("practica1a.Models.Compra", b =>
                {
                    b.HasOne("practica1a.Models.DetalleCompra", "DetalleCompra")
                        .WithMany("Compras")
                        .HasForeignKey("DetalleCompraId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("practica1a.Models.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DetalleCompra");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("practica1a.Models.ComprasProveedor", b =>
                {
                    b.HasOne("practica1a.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("practica1a.Models.DetalleComprasProveedor", "DetalleComprasProveedor")
                        .WithMany("ComprasProveedores")
                        .HasForeignKey("DetalleComprasProveedorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("DetalleComprasProveedor");
                });

            modelBuilder.Entity("practica1a.Models.DetalleCompra", b =>
                {
                    b.HasOne("practica1a.Models.Usuario", "Usuarios")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("practica1a.Models.DetalleComprasProveedor", b =>
                {
                    b.HasOne("practica1a.Models.Proveedores", "Proveedores")
                        .WithMany()
                        .HasForeignKey("ProveedoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("practica1a.Models.Usuario", "Usuarios")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proveedores");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("practica1a.Models.DetalleVenta", b =>
                {
                    b.HasOne("practica1a.Models.Usuario", "Usuarios")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("practica1a.Models.Direcciones", b =>
                {
                    b.HasOne("practica1a.Models.Usuario", "Usuario")
                        .WithMany("Direcciones")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("practica1a.Models.Producto", b =>
                {
                    b.HasOne("practica1a.Models.Categoria", "Categorias")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categorias");
                });

            modelBuilder.Entity("practica1a.Models.ProveedorCategoria", b =>
                {
                    b.HasOne("practica1a.Models.Categoria", "Categoria")
                        .WithMany("ProveedorCategorias")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("practica1a.Models.Proveedores", "Proveedores")
                        .WithMany("ProveedorCategorias")
                        .HasForeignKey("ProveedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Proveedores");
                });

            modelBuilder.Entity("practica1a.Models.RolUsuario", b =>
                {
                    b.HasOne("practica1a.Models.Rol", "Rol")
                        .WithMany("RolsUsuarios")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("practica1a.Models.Usuario", "Usuario")
                        .WithMany("RolsUsuarios")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("practica1a.Models.Usuario", b =>
                {
                    b.HasOne("practica1a.Models.UsuarioSession", "UsuariosSession")
                        .WithOne("Usuarios")
                        .HasForeignKey("practica1a.Models.Usuario", "UsuarioSessionId");

                    b.Navigation("UsuariosSession");
                });

            modelBuilder.Entity("practica1a.Models.UsuarioSession", b =>
                {
                    b.HasOne("practica1a.Models.Rol", "Rols")
                        .WithMany()
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rols");
                });

            modelBuilder.Entity("practica1a.Models.Venta", b =>
                {
                    b.HasOne("practica1a.Models.DetalleVenta", "DetalleVenta")
                        .WithMany("Ventas")
                        .HasForeignKey("DetalleVentaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("practica1a.Models.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DetalleVenta");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("practica1a.Models.Categoria", b =>
                {
                    b.Navigation("ProveedorCategorias");
                });

            modelBuilder.Entity("practica1a.Models.DetalleCompra", b =>
                {
                    b.Navigation("Compras");
                });

            modelBuilder.Entity("practica1a.Models.DetalleComprasProveedor", b =>
                {
                    b.Navigation("ComprasProveedores");
                });

            modelBuilder.Entity("practica1a.Models.DetalleVenta", b =>
                {
                    b.Navigation("Ventas");
                });

            modelBuilder.Entity("practica1a.Models.Proveedores", b =>
                {
                    b.Navigation("ProveedorCategorias");
                });

            modelBuilder.Entity("practica1a.Models.Rol", b =>
                {
                    b.Navigation("RolsUsuarios");
                });

            modelBuilder.Entity("practica1a.Models.Usuario", b =>
                {
                    b.Navigation("Direcciones");

                    b.Navigation("RolsUsuarios");
                });

            modelBuilder.Entity("practica1a.Models.UsuarioSession", b =>
                {
                    b.Navigation("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
