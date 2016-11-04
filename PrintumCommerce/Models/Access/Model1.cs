namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=AccessDBase")
        {
            Database.SetInitializer<Model1>(new CreateDatabaseIfNotExists<Model1>());
        }

        public virtual DbSet<aDMIN_fORMULARIOS> aDMIN_fORMULARIOS { get; set; }
        public virtual DbSet<aTUALIZACION> aTUALIZACIONs { get; set; }
        public virtual DbSet<cHEQUE> cHEQUES { get; set; }
        public virtual DbSet<Ciudade> Ciudades { get; set; }
        public virtual DbSet<CLI_DIR> CLI_DIR { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Credito> Creditoes { get; set; }
        public virtual DbSet<CTZ> CTZs { get; set; }
        public virtual DbSet<EC_fORMATOS> EC_fORMATOS { get; set; }
        public virtual DbSet<FC_Saldo_Ayer> FC_Saldo_Ayer { get; set; }
        public virtual DbSet<FC_Sem> FC_Sem { get; set; }
        public virtual DbSet<iMPORTACIONE> iMPORTACIONES { get; set; }
        public virtual DbSet<LG_rEMISION> LG_rEMISION { get; set; }
        public virtual DbSet<lQ_fAC_dESCUENTOS_fIN> lQ_fAC_dESCUENTOS_fIN { get; set; }
        public virtual DbSet<lQ_fIGURAS> lQ_fIGURAS { get; set; }
        public virtual DbSet<lQ_lIST_dCTOS> lQ_lIST_dCTOS { get; set; }
        public virtual DbSet<lQ_tpRO> lQ_tpRO { get; set; }
        public virtual DbSet<Pedido> Pedidos { get; set; }
        public virtual DbSet<Pedidos_Productos> Pedidos_Productos { get; set; }
        public virtual DbSet<Pro_Certificados> Pro_Certificados { get; set; }
        public virtual DbSet<Pro_Envase> Pro_Envase { get; set; }
        public virtual DbSet<Pro_Grupos> Pro_Grupos { get; set; }
        public virtual DbSet<pRO_hsEG> pRO_hsEG { get; set; }
        public virtual DbSet<pRO_hsEG_cOMPO> pRO_hsEG_cOMPO { get; set; }
        public virtual DbSet<Pro_Lineas> Pro_Lineas { get; set; }
        public virtual DbSet<pRO_lN> pRO_lN { get; set; }
        public virtual DbSet<Pro_MP_Pedidos> Pro_MP_Pedidos { get; set; }
        public virtual DbSet<PRO_OC> PRO_OC { get; set; }
        public virtual DbSet<Pro_Presentacion> Pro_Presentacion { get; set; }
        public virtual DbSet<Pro_pRUEBAS> Pro_pRUEBAS { get; set; }
        public virtual DbSet<Pro_Salida_Muestras> Pro_Salida_Muestras { get; set; }
        public virtual DbSet<Pro_Salida_Muestras_D> Pro_Salida_Muestras_D { get; set; }
        public virtual DbSet<Pro_Tiempo> Pro_Tiempo { get; set; }
        public virtual DbSet<Pro_Valores> Pro_Valores { get; set; }
        public virtual DbSet<PRO1_Productos> PRO1_Productos { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<rECIBOSdEcAJA> rECIBOSdEcAJAs { get; set; }
        public virtual DbSet<RH_Contra_Sueldos> RH_Contra_Sueldos { get; set; }
        public virtual DbSet<RH_Contratos> RH_Contratos { get; set; }
        public virtual DbSet<RH_EM_cRITERIOS> RH_EM_cRITERIOS { get; set; }
        public virtual DbSet<RH_EmpleadosPRTN> RH_EmpleadosPRTN { get; set; }
        public virtual DbSet<RH_EPP> RH_EPP { get; set; }
        public virtual DbSet<RH_eVALUACIONES> RH_eVALUACIONES { get; set; }
        public virtual DbSet<RH_EXAMENES> RH_EXAMENES { get; set; }
        public virtual DbSet<RH_fORMATOS> RH_fORMATOS { get; set; }
        public virtual DbSet<RH_HV_bRIGADA> RH_HV_bRIGADA { get; set; }
        public virtual DbSet<RH_lIQUIDACIONES> RH_lIQUIDACIONES { get; set; }
        public virtual DbSet<RH_MEMORANDOS> RH_MEMORANDOS { get; set; }
        public virtual DbSet<RH_MF> RH_MF { get; set; }
        public virtual DbSet<RH_nOTAS> RH_nOTAS { get; set; }
        public virtual DbSet<RH_PERMISOS> RH_PERMISOS { get; set; }
        public virtual DbSet<RH_POP> RH_POP { get; set; }
        public virtual DbSet<RH_T_cARGO> RH_T_cARGO { get; set; }
        public virtual DbSet<RH_T_dEPTOS> RH_T_dEPTOS { get; set; }
        public virtual DbSet<RH_T_H_tRABAJO> RH_T_H_tRABAJO { get; set; }
        public virtual DbSet<RH_tOMAiNDICADORES> RH_tOMAiNDICADORES { get; set; }
        public virtual DbSet<RH_Viaticos> RH_Viaticos { get; set; }
        public virtual DbSet<rRHH_pRESTAMOS> rRHH_pRESTAMOS { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tAUX_bANCOS> tAUX_bANCOS { get; set; }
        public virtual DbSet<tAUX_cLI_cALIFICACION> tAUX_cLI_cALIFICACION { get; set; }
        public virtual DbSet<tAUX_cLI_rEFcOM> tAUX_cLI_rEFcOM { get; set; }
        public virtual DbSet<tAUX_cLSiNVENTARIO> tAUX_cLSiNVENTARIO { get; set; }
        public virtual DbSet<tAUX_dESPA_jORNADA> tAUX_dESPA_jORNADA { get; set; }
        public virtual DbSet<tAUX_dESPA_tRANSPORTADORA> tAUX_dESPA_tRANSPORTADORA { get; set; }
        public virtual DbSet<tAUX_DIR> tAUX_DIR { get; set; }
        public virtual DbSet<tAUX_DIR_AZ> tAUX_DIR_AZ { get; set; }
        public virtual DbSet<tAUX_DIR_OP> tAUX_DIR_OP { get; set; }
        public virtual DbSet<tAUX_DIR_ZONAS> tAUX_DIR_ZONAS { get; set; }
        public virtual DbSet<tAUX_EPP> tAUX_EPP { get; set; }
        public virtual DbSet<tAUX_eSTADO> tAUX_eSTADO { get; set; }
        public virtual DbSet<tAUX_eSTADO_A_C> tAUX_eSTADO_A_C { get; set; }
        public virtual DbSet<tAUX_eSTADO_pROCESO> tAUX_eSTADO_pROCESO { get; set; }
        public virtual DbSet<tAUX_fORMApAGO> tAUX_fORMApAGO { get; set; }
        public virtual DbSet<tAUX_MPOP> tAUX_MPOP { get; set; }
        public virtual DbSet<tAUX_nICHOS> tAUX_nICHOS { get; set; }
        public virtual DbSet<tAUX_nIVELcARGO> tAUX_nIVELcARGO { get; set; }
        public virtual DbSet<tAUX_nOVEDADES> tAUX_nOVEDADES { get; set; }
        public virtual DbSet<tAUX_OC_nOcONFORMIDAD> tAUX_OC_nOcONFORMIDAD { get; set; }
        public virtual DbSet<tAUX_pAGO> tAUX_pAGO { get; set; }
        public virtual DbSet<tAUX_pD_eSTADO> tAUX_pD_eSTADO { get; set; }
        public virtual DbSet<tAUX_pERIODICIDAD> tAUX_pERIODICIDAD { get; set; }
        public virtual DbSet<tAUX_pERSONA_NJ> tAUX_pERSONA_NJ { get; set; }
        public virtual DbSet<tAUX_pRESTAMOSdES> tAUX_pRESTAMOSdES { get; set; }
        public virtual DbSet<tAUX_pRO_cLAS> tAUX_pRO_cLAS { get; set; }
        public virtual DbSet<tAUX_pRO_fECHAS> tAUX_pRO_fECHAS { get; set; }
        public virtual DbSet<tAUX_pRO_hORAS> tAUX_pRO_hORAS { get; set; }
        public virtual DbSet<tAUX_pRO_oBJETIVO_vISITA> tAUX_pRO_oBJETIVO_vISITA { get; set; }
        public virtual DbSet<tAUX_pRO_tPS> tAUX_pRO_tPS { get; set; }
        public virtual DbSet<tAUX_pROGRA_eSTADO> tAUX_pROGRA_eSTADO { get; set; }
        public virtual DbSet<tAUX_pROPIEDADES_tERCEROS> tAUX_pROPIEDADES_tERCEROS { get; set; }
        public virtual DbSet<tAUX_pROVE_cRITERIOSeVA> tAUX_pROVE_cRITERIOSeVA { get; set; }
        public virtual DbSet<tAUX_rEFvACA> tAUX_rEFvACA { get; set; }
        public virtual DbSet<tAUX_RH_cOMPETENCIAS> tAUX_RH_cOMPETENCIAS { get; set; }
        public virtual DbSet<tAUX_RH_CT_nOVEDADES> tAUX_RH_CT_nOVEDADES { get; set; }
        public virtual DbSet<tAUX_rH_eXAMENTES> tAUX_rH_eXAMENTES { get; set; }
        public virtual DbSet<tAUX_rH_mOTIVOS> tAUX_rH_mOTIVOS { get; set; }
        public virtual DbSet<tAUX_RH_pREGUNTAS_EVA> tAUX_RH_pREGUNTAS_EVA { get; set; }
        public virtual DbSet<tAUX_rH_T_pAGOS> tAUX_rH_T_pAGOS { get; set; }
        public virtual DbSet<tAUX_RH_tCONTRATOS> tAUX_RH_tCONTRATOS { get; set; }
        public virtual DbSet<tAUX_SINO> tAUX_SINO { get; set; }
        public virtual DbSet<tAUX_tIPOpEDIDO> tAUX_tIPOpEDIDO { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<uSER_fORMeQUIPOS> uSER_fORMeQUIPOS { get; set; }
        public virtual DbSet<VT_cONDICION_pRESUPUESTO> VT_cONDICION_pRESUPUESTO { get; set; }
        public virtual DbSet<VT_R_cARTERA> VT_R_cARTERA { get; set; }
        public virtual DbSet<VT_R_cARTERA1> VT_R_cARTERA1 { get; set; }
        public virtual DbSet<VT_TRM> VT_TRM { get; set; }
        public virtual DbSet<VT_Vlr_Liq> VT_Vlr_Liq { get; set; }
        public virtual DbSet<CSeguimiento> CSeguimientoes { get; set; }
        public virtual DbSet<RH_cESANTIAS> RH_cESANTIAS { get; set; }
        public virtual DbSet<RH_vACACIONES_aDELANTOS> RH_vACACIONES_aDELANTOS { get; set; }
        public virtual DbSet<tAUX_rEFmEMO> tAUX_rEFmEMO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pedido>()
                .HasMany(e => e.Pedidos_Productos)
                .WithOptional(e => e.Pedido)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Pro_Presentacion>()
                .HasOptional(e => e.Pro_Tiempo)
                .WithRequired(e => e.Pro_Presentacion);

            modelBuilder.Entity<Producto>()
                .HasMany(e => e.Pro_Certificados)
                .WithOptional(e => e.Producto)
                .HasForeignKey(e => e.Cod_producto);

            modelBuilder.Entity<Producto>()
                .HasOptional(e => e.pRO_hsEG)
                .WithRequired(e => e.Producto);

            modelBuilder.Entity<Producto>()
                .HasMany(e => e.Pro_Presentacion)
                .WithOptional(e => e.Producto)
                .HasForeignKey(e => e.CODIGO);

            modelBuilder.Entity<Producto>()
                .HasMany(e => e.PRO1_Productos)
                .WithOptional(e => e.Producto1)
                .HasForeignKey(e => e.COD_PRODUCTO);

            modelBuilder.Entity<RH_Contra_Sueldos>()
                .HasMany(e => e.RH_Contratos)
                .WithOptional(e => e.RH_Contra_Sueldos)
                .HasForeignKey(e => e.Salario);

            modelBuilder.Entity<RH_EmpleadosPRTN>()
                .HasMany(e => e.RH_Contratos)
                .WithOptional(e => e.RH_EmpleadosPRTN)
                .HasForeignKey(e => e.Id_Empleado);

            modelBuilder.Entity<RH_EmpleadosPRTN>()
                .HasMany(e => e.RH_cESANTIAS)
                .WithOptional(e => e.RH_EmpleadosPRTN)
                .HasForeignKey(e => e.iD_E);

            modelBuilder.Entity<RH_EmpleadosPRTN>()
                .HasMany(e => e.RH_tOMAiNDICADORES)
                .WithOptional(e => e.RH_EmpleadosPRTN)
                .HasForeignKey(e => e.ID_E);

            modelBuilder.Entity<RH_EmpleadosPRTN>()
                .HasMany(e => e.Users)
                .WithOptional(e => e.RH_EmpleadosPRTN)
                .HasForeignKey(e => e.IDHV);

            modelBuilder.Entity<RH_MF>()
                .HasMany(e => e.RH_Contratos)
                .WithOptional(e => e.RH_MF)
                .HasForeignKey(e => e.MF);

            modelBuilder.Entity<User>()
                .HasMany(e => e.CTZs)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.vENDOR);

         
        }
    }
}
