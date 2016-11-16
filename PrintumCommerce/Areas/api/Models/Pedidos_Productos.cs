namespace PrintumCommerce.Areas.api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pedidos_Productos
    {
        [Key]
        public int CODPED { get; set; }

        public int? No_Pedido { get; set; }

        public double? ID_Cliente { get; set; }

        [StringLength(255)]
        public string Cod_Producto { get; set; }

        public double? Cantidad { get; set; }

        [StringLength(255)]
        public string EnviadoaProduccion { get; set; }

        public DateTime? F_Enviado_Pro { get; set; }

        public DateTime? H_Enviado_Pro { get; set; }

        [StringLength(255)]
        public string Termino_Produccion { get; set; }

        public DateTime? F_Entrega_Pro { get; set; }

        public DateTime? H_Entrega_Pro { get; set; }

        [StringLength(255)]
        public string Estado { get; set; }

        [StringLength(255)]
        public string iNFO_1 { get; set; }

        [StringLength(255)]
        public string iNFO_2 { get; set; }

        [StringLength(255)]
        public string iNFO_3 { get; set; }

        [StringLength(255)]
        public string iNFO_4 { get; set; }

        [StringLength(255)]
        public string iNFO_5 { get; set; }

        [StringLength(255)]
        public string iNFO_6 { get; set; }

        [StringLength(255)]
        public string iNFO_7 { get; set; }

        [Column(TypeName = "ntext")]
        public string iNFO_8 { get; set; }

        [Column(TypeName = "ntext")]
        public string nUEVO_pRO { get; set; }

        [Column(TypeName = "ntext")]
        public string mODI_pRiNtUm { get; set; }

        [Column(TypeName = "ntext")]
        public string mODI_cLIENTE { get; set; }

        public double? nEW_cANTIDAD { get; set; }

        public int? nOoP { get; set; }

        public DateTime? HINICIOPRO { get; set; }

        public double? VARAC1 { get; set; }

        public double? VARAC2 { get; set; }

        public double? VARAC3 { get; set; }

        public double? VARAC4 { get; set; }

        [Column(TypeName = "ntext")]
        public string sOPORoP { get; set; }

        public  Pedidos Pedidos { get; set; }

        public  Pro_Presentacion Pro_Presentacion { get; set; }
    }
}
