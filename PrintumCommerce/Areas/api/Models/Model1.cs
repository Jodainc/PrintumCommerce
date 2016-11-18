namespace PrintumCommerce.Areas.api.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Microsoft.AspNet.Identity.EntityFramework;
    using PrintumCommerce.Models;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public static Model1 Create()
        {
            return new Model1();
        }
        public  DbSet<AspNetRoles> AspNetRoles { get; set; }
        public  DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public  DbSet<AspNetUsers> AspNetUsers { get; set; }
        public  DbSet<Cities> Cities { get; set; }
        public  DbSet<CLI_DIR> CLI_DIR { get; set; }
        public  DbSet<CLI_dIR_OP> CLI_dIR_OP { get; set; }
        public  DbSet<cLI_lINExvENDOR> cLI_lINExvENDOR { get; set; }
        public  DbSet<cLI_pRO_pROPIEDADES> cLI_pRO_pROPIEDADES { get; set; }
        public  DbSet<Clientes> Clientes { get; set; }
        public  DbSet<Clientes_CONTAC> Clientes_CONTAC { get; set; }
        public  DbSet<Clientes_Estadistica> Clientes_Estadistica { get; set; }
        public  DbSet<Clientes_Maquinas> Clientes_Maquinas { get; set; }
        public  DbSet<Companies> Companies { get; set; }
        public  DbSet<Credito> Credito { get; set; }
        public  DbSet<DepartmentModels> DepartmentModels { get; set; }
        public  DbSet<FC_Bancos> FC_Bancos { get; set; }
        public  DbSet<FC_Proveedores> FC_Proveedores { get; set; }
        public  DbSet<FC_Saldo_Ayer> FC_Saldo_Ayer { get; set; }
        public  DbSet<FC_Sem> FC_Sem { get; set; }
        public  DbSet<FC_Creditos> FC_Creditos { get; set; }
        public  DbSet<FC_Gastos> FC_Gastos { get; set; }
        public  DbSet<iMPORTACIONES> iMPORTACIONES { get; set; }
        public  DbSet<iMPORTACIONES_D> iMPORTACIONES_D { get; set; }
        public  DbSet<lQ_fAC_dESCUENTOS_fIN> lQ_fAC_dESCUENTOS_fIN { get; set; }
        public  DbSet<lQ_fIGURAS> lQ_fIGURAS { get; set; }
        public  DbSet<lQ_lIST_dCTOS> lQ_lIST_dCTOS { get; set; }
        public  DbSet<lQ_tpRO> lQ_tpRO { get; set; }
        public  DbSet<Pedidos> Pedidos { get; set; }
        public  DbSet<Pedidos_Productos> Pedidos_Productos { get; set; }
        public  DbSet<Pro_Certificados> Pro_Certificados { get; set; }
        public  DbSet<Pro_Envase> Pro_Envase { get; set; }
        public  DbSet<Pro_Estandar> Pro_Estandar { get; set; }
        public  DbSet<Pro_Existencias> Pro_Existencias { get; set; }
        public  DbSet<Pro_Formula> Pro_Formula { get; set; }
        public  DbSet<Pro_Grupos> Pro_Grupos { get; set; }
        public  DbSet<pRO_hsEG> pRO_hsEG { get; set; }
        public  DbSet<pRO_hsEG_cOMPO> pRO_hsEG_cOMPO { get; set; }
        public  DbSet<pRO_hsEG_ePP> pRO_hsEG_ePP { get; set; }
        public  DbSet<pRO_hsEG_oTRAiNFO> pRO_hsEG_oTRAiNFO { get; set; }
        public  DbSet<Pro_Lineas> Pro_Lineas { get; set; }
        public  DbSet<pRO_lN> pRO_lN { get; set; }
        public  DbSet<Pro_Medicion> Pro_Medicion { get; set; }
        public  DbSet<Pro_MP_Pedidos> Pro_MP_Pedidos { get; set; }
        public  DbSet<PRO_OC> PRO_OC { get; set; }
        public  DbSet<PRO_OC_D> PRO_OC_D { get; set; }
        public  DbSet<PRO_OC_NC> PRO_OC_NC { get; set; }
        public  DbSet<Pro_Presentacion> Pro_Presentacion { get; set; }
        public  DbSet<Pro_pRUEBAS> Pro_pRUEBAS { get; set; }
        public  DbSet<Pro_Salida_Muestras> Pro_Salida_Muestras { get; set; }
        public  DbSet<Pro_Salida_Muestras_D> Pro_Salida_Muestras_D { get; set; }
        public  DbSet<Pro_Salidas_Muestras_fECHAS> Pro_Salidas_Muestras_fECHAS { get; set; }
        public  DbSet<Pro_Tiempo> Pro_Tiempo { get; set; }
        public  DbSet<Pro_Valores> Pro_Valores { get; set; }
        public  DbSet<PRO1_Productos> PRO1_Productos { get; set; }
        public  DbSet<PRO2_Cuenta_con> PRO2_Cuenta_con { get; set; }
        public  DbSet<PRO3_Propiedades_de_Impresión> PRO3_Propiedades_de_Impresión { get; set; }
        public  DbSet<PRO4_Propiedades_de_Aplicación> PRO4_Propiedades_de_Aplicación { get; set; }
        public  DbSet<PRO5_Referencias_Existentes> PRO5_Referencias_Existentes { get; set; }
        public  DbSet<PRO6_Recomendaciones_de_Procesamiento> PRO6_Recomendaciones_de_Procesamiento { get; set; }
        public  DbSet<PRO7_Limpieza> PRO7_Limpieza { get; set; }
        public  DbSet<PRO8_Almacenamiento> PRO8_Almacenamiento { get; set; }
        public  DbSet<PRO9_Instrucciones_de_Seguridad> PRO9_Instrucciones_de_Seguridad { get; set; }
        public  DbSet<PRO91_Unidad_de_Empaque> PRO91_Unidad_de_Empaque { get; set; }
        public  DbSet<PRO92_lAP_Propiedades_medicion_mm> PRO92_lAP_Propiedades_medicion_mm { get; set; }
        public  DbSet<PRO93_lAP_Propiedades_Electricas> PRO93_lAP_Propiedades_Electricas { get; set; }
        public  DbSet<PRO94_Recomendaciones_de_Uso> PRO94_Recomendaciones_de_Uso { get; set; }
        public  DbSet<PRO95_Ventajas> PRO95_Ventajas { get; set; }
        public  DbSet<PRO96_Garantia> PRO96_Garantia { get; set; }
        public  DbSet<PRO97_ServiTec> PRO97_ServiTec { get; set; }
        public  DbSet<PRO98_Propiedades> PRO98_Propiedades { get; set; }
        public  DbSet<PRO99_Pedido> PRO99_Pedido { get; set; }
        public  DbSet<Productos> Productos { get; set; }
        public  DbSet<Proveedores_Productos> Proveedores_Productos { get; set; }
        public  DbSet<Users> Users { get; set; }
        public  DbSet<VT_TRM> VT_TRM { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Cities>()
                .HasMany(e => e.Companies)
                .WithRequired(e => e.Cities)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cities>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Cities)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clientes>()
                .HasMany(e => e.cLI_pRO_pROPIEDADES)
                .WithOptional(e => e.Clientes)
                .HasForeignKey(e => e.IDT);

            modelBuilder.Entity<Companies>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Companies)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DepartmentModels>()
                .HasMany(e => e.Cities)
                .WithRequired(e => e.DepartmentModels)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DepartmentModels>()
                .HasMany(e => e.Companies)
                .WithRequired(e => e.DepartmentModels)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DepartmentModels>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.DepartmentModels)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FC_Sem>()
                .HasMany(e => e.FC_Bancos)
                .WithOptional(e => e.FC_Sem)
                .HasForeignKey(e => e.Fecha);

            modelBuilder.Entity<FC_Sem>()
                .HasMany(e => e.FC_Proveedores)
                .WithOptional(e => e.FC_Sem)
                .HasForeignKey(e => e.Vencimiento);

            modelBuilder.Entity<FC_Sem>()
                .HasMany(e => e.FC_Creditos)
                .WithOptional(e => e.FC_Sem)
                .HasForeignKey(e => e.Fecha_Pago);

            modelBuilder.Entity<FC_Sem>()
                .HasMany(e => e.FC_Gastos)
                .WithOptional(e => e.FC_Sem)
                .HasForeignKey(e => e.Fecha_Pago);

            modelBuilder.Entity<Pedidos>()
                .HasMany(e => e.Pedidos_Productos)
                .WithOptional(e => e.Pedidos)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Pro_Certificados>()
                .HasMany(e => e.Pro_Medicion)
                .WithOptional(e => e.Pro_Certificados)
                .HasForeignKey(e => e.No_Certificado);

            modelBuilder.Entity<pRO_hsEG>()
                .HasMany(e => e.pRO_hsEG_ePP)
                .WithOptional(e => e.pRO_hsEG)
                .HasForeignKey(e => e.C8Codigo);

            modelBuilder.Entity<pRO_hsEG>()
                .HasMany(e => e.pRO_hsEG_oTRAiNFO)
                .WithOptional(e => e.pRO_hsEG)
                .HasForeignKey(e => e.C16Codigo)
                .WillCascadeOnDelete();

            modelBuilder.Entity<pRO_hsEG_cOMPO>()
                .Property(e => e.pro_hsEG_Codigo)
                .IsFixedLength();

            modelBuilder.Entity<PRO_OC>()
                .HasMany(e => e.PRO_OC_D)
                .WithOptional(e => e.PRO_OC)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Pro_Presentacion>()
                .HasMany(e => e.iMPORTACIONES_D)
                .WithOptional(e => e.Pro_Presentacion)
                .HasForeignKey(e => e.rEFERENCIA);

            modelBuilder.Entity<Pro_Presentacion>()
                .HasMany(e => e.Pro_Existencias)
                .WithOptional(e => e.Pro_Presentacion)
                .HasForeignKey(e => e.Cod_Pro);

            modelBuilder.Entity<Pro_Presentacion>()
                .HasOptional(e => e.Pro_Tiempo)
                .WithRequired(e => e.Pro_Presentacion);

            modelBuilder.Entity<Pro_Presentacion>()
                .HasMany(e => e.Proveedores_Productos)
                .WithOptional(e => e.Pro_Presentacion)
                .HasForeignKey(e => e.Cod_MP);

            modelBuilder.Entity<Pro_pRUEBAS>()
                .HasMany(e => e.Pro_Estandar)
                .WithOptional(e => e.Pro_pRUEBAS)
                .HasForeignKey(e => e.COD_PRUEBA);

            modelBuilder.Entity<Productos>()
                .HasMany(e => e.Pro_Certificados)
                .WithOptional(e => e.Productos)
                .HasForeignKey(e => e.Cod_producto);

            modelBuilder.Entity<Productos>()
                .HasMany(e => e.Pro_Estandar)
                .WithOptional(e => e.Productos)
                .HasForeignKey(e => e.CODIGO);

            modelBuilder.Entity<Productos>()
                .HasMany(e => e.Pro_Formula)
                .WithOptional(e => e.Productos)
                .HasForeignKey(e => e.Cod_Producto);

            modelBuilder.Entity<Productos>()
                .HasOptional(e => e.pRO_hsEG)
                .WithRequired(e => e.Productos);

            modelBuilder.Entity<Productos>()
                .HasMany(e => e.Pro_Presentacion)
                .WithOptional(e => e.Productos)
                .HasForeignKey(e => e.CODIGO);

            modelBuilder.Entity<Productos>()
                .HasMany(e => e.PRO1_Productos)
                .WithOptional(e => e.Productos)
                .HasForeignKey(e => e.COD_PRODUCTO);
        }
    }
}
