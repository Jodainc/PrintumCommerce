namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=AccessDBases")
        {
        }

        public virtual DbSet<C2016vENTAS> C2016vENTAS { get; set; }
        public virtual DbSet<aDMIN_fORMULARIOS> aDMIN_fORMULARIOS { get; set; }
        public virtual DbSet<aTUALIZACION> aTUALIZACION { get; set; }
        public virtual DbSet<cHEQUES> cHEQUES { get; set; }
        public virtual DbSet<Ciudades> Ciudades { get; set; }
        public virtual DbSet<CLI_DIR> CLI_DIR { get; set; }
        public virtual DbSet<CLI_dIR_OP> CLI_dIR_OP { get; set; }
        public virtual DbSet<cLI_lINExvENDOR> cLI_lINExvENDOR { get; set; }
        public virtual DbSet<cLI_pRO_pROPIEDADES> cLI_pRO_pROPIEDADES { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Clientes_CONTAC> Clientes_CONTAC { get; set; }
        public virtual DbSet<Clientes_Estadistica> Clientes_Estadistica { get; set; }
        public virtual DbSet<Clientes_Maquinas> Clientes_Maquinas { get; set; }
        public virtual DbSet<Credito> Credito { get; set; }
        public virtual DbSet<CSeguimiento> CSeguimiento { get; set; }
        public virtual DbSet<CTZ> CTZ { get; set; }
        public virtual DbSet<CTZ_D> CTZ_D { get; set; }
        public virtual DbSet<EC_fORMATOS> EC_fORMATOS { get; set; }
        public virtual DbSet<FC_Bancos> FC_Bancos { get; set; }
        public virtual DbSet<FC_Proveedores> FC_Proveedores { get; set; }
        public virtual DbSet<FC_Saldo_Ayer> FC_Saldo_Ayer { get; set; }
        public virtual DbSet<FC_Sem> FC_Sem { get; set; }
        public virtual DbSet<FC_Creditos> FC_Creditos { get; set; }
        public virtual DbSet<FC_Gastos> FC_Gastos { get; set; }
        public virtual DbSet<iMPORTACIONES> iMPORTACIONES { get; set; }
        public virtual DbSet<iMPORTACIONES_D> iMPORTACIONES_D { get; set; }
        public virtual DbSet<LG_rEMISION> LG_rEMISION { get; set; }
        public virtual DbSet<LG_rEMISION_D> LG_rEMISION_D { get; set; }
        public virtual DbSet<lQ_fAC_dESCUENTOS_fIN> lQ_fAC_dESCUENTOS_fIN { get; set; }
        public virtual DbSet<lQ_fIGURAS> lQ_fIGURAS { get; set; }
        public virtual DbSet<lQ_lIST_dCTOS> lQ_lIST_dCTOS { get; set; }
        public virtual DbSet<lQ_tpRO> lQ_tpRO { get; set; }
        public virtual DbSet<Pedidos> Pedidos { get; set; }
        public virtual DbSet<Pedidos_Productos> Pedidos_Productos { get; set; }
        public virtual DbSet<pRESUPUESTO__> pRESUPUESTO__ { get; set; }
        public virtual DbSet<pRESUPUESTO_C> pRESUPUESTO_C { get; set; }
        public virtual DbSet<Pro_Certificados> Pro_Certificados { get; set; }
        public virtual DbSet<Pro_Envase> Pro_Envase { get; set; }
        public virtual DbSet<Pro_Estandar> Pro_Estandar { get; set; }
        public virtual DbSet<Pro_Existencias> Pro_Existencias { get; set; }
        public virtual DbSet<Pro_Formula> Pro_Formula { get; set; }
        public virtual DbSet<Pro_Grupos> Pro_Grupos { get; set; }
        public virtual DbSet<pRO_hsEG> pRO_hsEG { get; set; }
        public virtual DbSet<pRO_hsEG_cOMPO> pRO_hsEG_cOMPO { get; set; }
        public virtual DbSet<pRO_hsEG_ePP> pRO_hsEG_ePP { get; set; }
        public virtual DbSet<pRO_hsEG_oTRAiNFO> pRO_hsEG_oTRAiNFO { get; set; }
        public virtual DbSet<Pro_Lineas> Pro_Lineas { get; set; }
        public virtual DbSet<pRO_lN> pRO_lN { get; set; }
        public virtual DbSet<Pro_Medicion> Pro_Medicion { get; set; }
        public virtual DbSet<Pro_MP_Pedidos> Pro_MP_Pedidos { get; set; }
        public virtual DbSet<PRO_OC> PRO_OC { get; set; }
        public virtual DbSet<PRO_OC_D> PRO_OC_D { get; set; }
        public virtual DbSet<PRO_OC_NC> PRO_OC_NC { get; set; }
        public virtual DbSet<Pro_Presentacion> Pro_Presentacion { get; set; }
        public virtual DbSet<Pro_pRUEBAS> Pro_pRUEBAS { get; set; }
        public virtual DbSet<Pro_Salida_Muestras> Pro_Salida_Muestras { get; set; }
        public virtual DbSet<Pro_Salida_Muestras_D> Pro_Salida_Muestras_D { get; set; }
        public virtual DbSet<Pro_Salidas_Muestras_fECHAS> Pro_Salidas_Muestras_fECHAS { get; set; }
        public virtual DbSet<Pro_Tiempo> Pro_Tiempo { get; set; }
        public virtual DbSet<Pro_Valores> Pro_Valores { get; set; }
        public virtual DbSet<PRO1_Productos> PRO1_Productos { get; set; }
        public virtual DbSet<PRO2_Cuenta_con> PRO2_Cuenta_con { get; set; }
        public virtual DbSet<PRO3_Propiedades_de_Impresión> PRO3_Propiedades_de_Impresión { get; set; }
        public virtual DbSet<PRO4_Propiedades_de_Aplicación> PRO4_Propiedades_de_Aplicación { get; set; }
        public virtual DbSet<PRO5_Referencias_Existentes> PRO5_Referencias_Existentes { get; set; }
        public virtual DbSet<PRO6_Recomendaciones_de_Procesamiento> PRO6_Recomendaciones_de_Procesamiento { get; set; }
        public virtual DbSet<PRO7_Limpieza> PRO7_Limpieza { get; set; }
        public virtual DbSet<PRO8_Almacenamiento> PRO8_Almacenamiento { get; set; }
        public virtual DbSet<PRO9_Instrucciones_de_Seguridad> PRO9_Instrucciones_de_Seguridad { get; set; }
        public virtual DbSet<PRO91_Unidad_de_Empaque> PRO91_Unidad_de_Empaque { get; set; }
        public virtual DbSet<PRO92_lAP_Propiedades_medicion_mm> PRO92_lAP_Propiedades_medicion_mm { get; set; }
        public virtual DbSet<PRO93_lAP_Propiedades_Electricas> PRO93_lAP_Propiedades_Electricas { get; set; }
        public virtual DbSet<PRO93_LAP_DIAGRAMA> PRO93_lAP_DIAGRAMA { get; set; }
        public virtual DbSet<PRO94_Recomendaciones_de_Uso> PRO94_Recomendaciones_de_Uso { get; set; }
        public virtual DbSet<PRO95_Ventajas> PRO95_Ventajas { get; set; }
        public virtual DbSet<PRO96_Garantia> PRO96_Garantia { get; set; }
        public virtual DbSet<PRO97_ServiTec> PRO97_ServiTec { get; set; }
        public virtual DbSet<PRO98_Propiedades> PRO98_Propiedades { get; set; }
        public virtual DbSet<PRO99_Pedido> PRO99_Pedido { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<pRODUCTOS_cLASS> pRODUCTOS_cLASS { get; set; }
        public virtual DbSet<Proveedores_Productos> Proveedores_Productos { get; set; }
        public virtual DbSet<rECIBOSdEcAJA> rECIBOSdEcAJA { get; set; }
        public virtual DbSet<Registro> Registro { get; set; }
        public virtual DbSet<RH_CEL> RH_CEL { get; set; }
        public virtual DbSet<RH_cESANTIAS> RH_cESANTIAS { get; set; }
        public virtual DbSet<RH_Conformacion> RH_Conformacion { get; set; }
        public virtual DbSet<RH_CONTRA_Aumentos_SB> RH_CONTRA_Aumentos_SB { get; set; }
        public virtual DbSet<RH_Contra_Sueldos> RH_Contra_Sueldos { get; set; }
        public virtual DbSet<RH_Contratos> RH_Contratos { get; set; }
        public virtual DbSet<RH_Dotacion> RH_Dotacion { get; set; }
        public virtual DbSet<RH_EM_cRITERIOS> RH_EM_cRITERIOS { get; set; }
        public virtual DbSet<RH_EmpleadosPRTN> RH_EmpleadosPRTN { get; set; }
        public virtual DbSet<RH_EPP> RH_EPP { get; set; }
        public virtual DbSet<RH_EPP_D> RH_EPP_D { get; set; }
        public virtual DbSet<RH_eVALUACIONES> RH_eVALUACIONES { get; set; }
        public virtual DbSet<RH_eVALUACIONES_D> RH_eVALUACIONES_D { get; set; }
        public virtual DbSet<RH_EXAMENES> RH_EXAMENES { get; set; }
        public virtual DbSet<RH_Experiencia> RH_Experiencia { get; set; }
        public virtual DbSet<RH_fORMATOS> RH_fORMATOS { get; set; }
        public virtual DbSet<RH_HV_bRIGADA> RH_HV_bRIGADA { get; set; }
        public virtual DbSet<RH_lIQUIDACIONES> RH_lIQUIDACIONES { get; set; }
        public virtual DbSet<RH_MEMORANDOS> RH_MEMORANDOS { get; set; }
        public virtual DbSet<RH_MF> RH_MF { get; set; }
        public virtual DbSet<RH_MF_DF> RH_MF_DF { get; set; }
        public virtual DbSet<RH_MF_EER> RH_MF_EER { get; set; }
        public virtual DbSet<RH_MF_HE_FC> RH_MF_HE_FC { get; set; }
        public virtual DbSet<RH_MF_HE_HE> RH_MF_HE_HE { get; set; }
        public virtual DbSet<RH_MF_HE_IM> RH_MF_HE_IM { get; set; }
        public virtual DbSet<RH_MF_IND> RH_MF_IND { get; set; }
        public virtual DbSet<RH_MF_PP> RH_MF_PP { get; set; }
        public virtual DbSet<RH_MF_RC> RH_MF_RC { get; set; }
        public virtual DbSet<RH_MF_RC_EX> RH_MF_RC_EX { get; set; }
        public virtual DbSet<RH_MF_RC_FA> RH_MF_RC_FA { get; set; }
        public virtual DbSet<RH_MF_RC_RH> RH_MF_RC_RH { get; set; }
        public virtual DbSet<RH_nOTAS> RH_nOTAS { get; set; }
        public virtual DbSet<RH_PAGOS> RH_PAGOS { get; set; }
        public virtual DbSet<RH_PC> RH_PC { get; set; }
        public virtual DbSet<RH_PERMISOS> RH_PERMISOS { get; set; }
        public virtual DbSet<RH_POP> RH_POP { get; set; }
        public virtual DbSet<RH_POP_D> RH_POP_D { get; set; }
        public virtual DbSet<RH_Ref_FAM> RH_Ref_FAM { get; set; }
        public virtual DbSet<RH_Ref_PER> RH_Ref_PER { get; set; }
        public virtual DbSet<RH_T_cARGO> RH_T_cARGO { get; set; }
        public virtual DbSet<RH_T_dEPTOS> RH_T_dEPTOS { get; set; }
        public virtual DbSet<RH_T_H_tRABAJO> RH_T_H_tRABAJO { get; set; }
        public virtual DbSet<RH_tOMAiNDICADORES> RH_tOMAiNDICADORES { get; set; }
        public virtual DbSet<RH_tOMAiNDICADORES_D> RH_tOMAiNDICADORES_D { get; set; }
        public virtual DbSet<RH_tOOLS> RH_tOOLS { get; set; }
        public virtual DbSet<RH_Vacaciones> RH_Vacaciones { get; set; }
        public virtual DbSet<RH_Viaticos> RH_Viaticos { get; set; }
        public virtual DbSet<RH_Viaticos_D> RH_Viaticos_D { get; set; }
        public virtual DbSet<rRHH_pRESTAMOS> rRHH_pRESTAMOS { get; set; }
        public virtual DbSet<rRHH_pRESTAMOS_pAGOS> rRHH_pRESTAMOS_pAGOS { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
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
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<uSER_fORMeQUIPOS> uSER_fORMeQUIPOS { get; set; }
        public virtual DbSet<uSER_pERMIS> uSER_pERMIS { get; set; }
        public virtual DbSet<vENTAS_rECIBOSdEcAJA> vENTAS_rECIBOSdEcAJA { get; set; }
        public virtual DbSet<VT_cONDICION_pRESUPUESTO> VT_cONDICION_pRESUPUESTO { get; set; }
        public virtual DbSet<VT_R_cARTERA> VT_R_cARTERA { get; set; }
        public virtual DbSet<VT_R_cARTERA1> VT_R_cARTERA1 { get; set; }
        public virtual DbSet<VT_TRM> VT_TRM { get; set; }
        public virtual DbSet<VT_Vlr_Liq> VT_Vlr_Liq { get; set; }
        public virtual DbSet<RH_vACACIONES_aDELANTOS> RH_vACACIONES_aDELANTOS { get; set; }
        public virtual DbSet<tAUX_rEFmEMO> tAUX_rEFmEMO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<aDMIN_fORMULARIOS>()
                .HasMany(e => e.uSER_pERMIS)
                .WithOptional(e => e.aDMIN_fORMULARIOS)
                .HasForeignKey(e => e.fORMUL);

            modelBuilder.Entity<Clientes>()
                .HasMany(e => e.cLI_pRO_pROPIEDADES)
                .WithOptional(e => e.Clientes)
                .HasForeignKey(e => e.IDT);

            modelBuilder.Entity<Clientes>()
                .HasMany(e => e.vENTAS_rECIBOSdEcAJA)
                .WithOptional(e => e.Clientes)
                .HasForeignKey(e => e.ID_TERCERO);

            modelBuilder.Entity<CTZ>()
                .HasMany(e => e.CTZ_D)
                .WithOptional(e => e.CTZ)
                .WillCascadeOnDelete();

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
                .HasMany(e => e.C2016vENTAS)
                .WithOptional(e => e.Pro_Presentacion)
                .HasForeignKey(e => e.CODIGO);

            modelBuilder.Entity<Pro_Presentacion>()
                .HasMany(e => e.CTZ_D)
                .WithOptional(e => e.Pro_Presentacion)
                .HasForeignKey(e => e.cOD_pRO);

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
                .HasMany(e => e.pRODUCTOS_cLASS)
                .WithOptional(e => e.Pro_Presentacion)
                .HasForeignKey(e => e.cOD_pRE);

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

            modelBuilder.Entity<RH_Contra_Sueldos>()
                .HasMany(e => e.RH_Contratos)
                .WithOptional(e => e.RH_Contra_Sueldos)
                .HasForeignKey(e => e.Salario);

            modelBuilder.Entity<RH_EmpleadosPRTN>()
                .HasMany(e => e.RH_cESANTIAS)
                .WithOptional(e => e.RH_EmpleadosPRTN)
                .HasForeignKey(e => e.iD_E);

            modelBuilder.Entity<RH_EmpleadosPRTN>()
                .HasMany(e => e.RH_Contratos)
                .WithOptional(e => e.RH_EmpleadosPRTN)
                .HasForeignKey(e => e.Id_Empleado);

            modelBuilder.Entity<RH_EmpleadosPRTN>()
                .HasMany(e => e.RH_tOMAiNDICADORES)
                .WithOptional(e => e.RH_EmpleadosPRTN)
                .HasForeignKey(e => e.ID_E);

            modelBuilder.Entity<RH_EmpleadosPRTN>()
                .HasMany(e => e.User)
                .WithOptional(e => e.RH_EmpleadosPRTN)
                .HasForeignKey(e => e.IDHV);

            modelBuilder.Entity<RH_EPP>()
                .HasMany(e => e.RH_EPP_D)
                .WithOptional(e => e.RH_EPP)
                .WillCascadeOnDelete();

            modelBuilder.Entity<RH_MF>()
                .HasMany(e => e.RH_CONTRA_Aumentos_SB)
                .WithOptional(e => e.RH_MF)
                .HasForeignKey(e => e.MF);

            modelBuilder.Entity<RH_MF>()
                .HasMany(e => e.RH_Contratos)
                .WithOptional(e => e.RH_MF)
                .HasForeignKey(e => e.MF);

            modelBuilder.Entity<RH_Viaticos>()
                .HasMany(e => e.RH_Viaticos_D)
                .WithOptional(e => e.RH_Viaticos)
                .WillCascadeOnDelete();

            modelBuilder.Entity<User>()
                .HasMany(e => e.C2016vENTAS)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.VENDEDOR);

            modelBuilder.Entity<User>()
                .HasMany(e => e.cLI_lINExvENDOR)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.iDV);

            modelBuilder.Entity<User>()
                .HasMany(e => e.CTZ)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.vENDOR);

            modelBuilder.Entity<User>()
                .HasMany(e => e.pRESUPUESTO__)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.ID_vENDEDOR);

            modelBuilder.Entity<User>()
                .HasMany(e => e.pRESUPUESTO_C)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.ID_vENDEDOR);

            modelBuilder.Entity<User>()
                .HasMany(e => e.uSER_pERMIS)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.uSER);
        }
        /*
      public System.Data.Entity.DbSet<PrintumCommerce.Areas.api.Models.Users> Users { get; set; }

      public System.Data.Entity.DbSet<PrintumCommerce.Areas.api.Models.Cities> Cities { get; set; }

      public System.Data.Entity.DbSet<PrintumCommerce.Areas.api.Models.Companies> Companies { get; set; }

      public System.Data.Entity.DbSet<PrintumCommerce.Areas.api.Models.DepartmentModels> DepartmentModels { get; set; }
  */
    }
}
