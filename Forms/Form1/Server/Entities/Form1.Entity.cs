//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:3.1.32
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bimser.CSP.FormControls.Entities;
using Bimser.Framework.Attributes.Database;
using Bimser.Framework.Domain;
using Bimser.Framework.Domain.Entities;

namespace gorevatamasureci_feyza.Entities {
    
    
    [TableOptions(TableName="E_gorevatamasureci_feyza_GorevAtamaSureci")]
    public class E_gorevatamasureci_feyza_GorevAtamaSureciEntity : FormEntity<E_gorevatamasureci_feyza_GorevAtamaSureciEntity> {
        
        private Bimser.Framework.Domain.DataField<string> _UserMetadata1;
        
        private Bimser.Framework.Domain.DataField<System.Nullable<System.DateTimeOffset>> _DTBitis;
        
        private Bimser.Framework.Domain.DataField<System.Nullable<System.DateTimeOffset>> _DTBaslangic;
        
        private Bimser.Framework.Domain.DataField<System.Nullable<decimal>> _NB_KalanSure;
        
        private Bimser.Framework.Domain.DataField<System.Nullable<decimal>> _Rate_TamamlamaYuzdesi;
        
        private E_gorevatamasureci_feyza_GorevAtamaSureciVREntity _VersionEntity;
        
        private RDEntityCollection<E_gorevatamasureci_feyza_GorevAtamaSureciRDEntity, E_gorevatamasureci_feyza_GorevAtamaSureciRDMLEntity> _RD;
        
        private RDCEntityCollection<E_gorevatamasureci_feyza_GorevAtamaSureciRDCEntity, E_gorevatamasureci_feyza_GorevAtamaSureciRDCMLEntity> _RDC;
        
        private MLEntityCollection<E_gorevatamasureci_feyza_GorevAtamaSureciMLEntity> _ML;
        
        private SLEntityCollection<E_gorevatamasureci_feyza_GorevAtamaSureciSLEntity, E_gorevatamasureci_feyza_GorevAtamaSureciSLMLEntity> _SL;
        
        private GridEntityCollection<E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1Entity, E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1MLEntity, E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1SLEntity, E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1SLMLEntity> _E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1;
        
        public E_gorevatamasureci_feyza_GorevAtamaSureciEntity() {
            this.ML = new MLEntityCollection<E_gorevatamasureci_feyza_GorevAtamaSureciMLEntity>();
            this.VersionEntity = new E_gorevatamasureci_feyza_GorevAtamaSureciVREntity();
            this.RD = new RDEntityCollection<E_gorevatamasureci_feyza_GorevAtamaSureciRDEntity, E_gorevatamasureci_feyza_GorevAtamaSureciRDMLEntity>();
            this.RDC = new RDCEntityCollection<E_gorevatamasureci_feyza_GorevAtamaSureciRDCEntity, E_gorevatamasureci_feyza_GorevAtamaSureciRDCMLEntity>();
            this.E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1 = new GridEntityCollection<E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1Entity, E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1MLEntity, E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1SLEntity, E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1SLMLEntity>();
            this.E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1.MLEntityEnabled = true;
            this.E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1.SLEntityEnabled = false;
            this.SL = new SLEntityCollection<E_gorevatamasureci_feyza_GorevAtamaSureciSLEntity, E_gorevatamasureci_feyza_GorevAtamaSureciSLMLEntity>();
        }
        
        [ColumnOptionsAttribute(Name="UserMetadata1", Mandatory=false, Size=50)]
        public Bimser.Framework.Domain.DataField<string> UserMetadata1 {
            get {
                return this._UserMetadata1;
            }
            set {
                this._UserMetadata1 = value;
            }
        }
        
        [ColumnOptionsAttribute(Name="DTBitis", Mandatory=false)]
        public Bimser.Framework.Domain.DataField<System.Nullable<System.DateTimeOffset>> DTBitis {
            get {
                return this._DTBitis;
            }
            set {
                this._DTBitis = value;
            }
        }
        
        [ColumnOptionsAttribute(Name="DTBaslangic", Mandatory=false)]
        public Bimser.Framework.Domain.DataField<System.Nullable<System.DateTimeOffset>> DTBaslangic {
            get {
                return this._DTBaslangic;
            }
            set {
                this._DTBaslangic = value;
            }
        }
        
        [ColumnOptionsAttribute(Name="NB_KalanSure", Mandatory=false)]
        public Bimser.Framework.Domain.DataField<System.Nullable<decimal>> NB_KalanSure {
            get {
                return this._NB_KalanSure;
            }
            set {
                this._NB_KalanSure = value;
            }
        }
        
        [ColumnOptionsAttribute(Name="Rate_TamamlamaYuzdesi", Mandatory=false)]
        public Bimser.Framework.Domain.DataField<System.Nullable<decimal>> Rate_TamamlamaYuzdesi {
            get {
                return this._Rate_TamamlamaYuzdesi;
            }
            set {
                this._Rate_TamamlamaYuzdesi = value;
            }
        }
        
        public E_gorevatamasureci_feyza_GorevAtamaSureciVREntity VersionEntity {
            get {
                return this._VersionEntity;
            }
            set {
                this._VersionEntity = value;
            }
        }
        
        public RDEntityCollection<E_gorevatamasureci_feyza_GorevAtamaSureciRDEntity, E_gorevatamasureci_feyza_GorevAtamaSureciRDMLEntity> RD {
            get {
                return this._RD;
            }
            set {
                this._RD = value;
            }
        }
        
        public RDCEntityCollection<E_gorevatamasureci_feyza_GorevAtamaSureciRDCEntity, E_gorevatamasureci_feyza_GorevAtamaSureciRDCMLEntity> RDC {
            get {
                return this._RDC;
            }
            set {
                this._RDC = value;
            }
        }
        
        public MLEntityCollection<E_gorevatamasureci_feyza_GorevAtamaSureciMLEntity> ML {
            get {
                return this._ML;
            }
            set {
                this._ML = value;
            }
        }
        
        public SLEntityCollection<E_gorevatamasureci_feyza_GorevAtamaSureciSLEntity, E_gorevatamasureci_feyza_GorevAtamaSureciSLMLEntity> SL {
            get {
                return this._SL;
            }
            set {
                this._SL = value;
            }
        }
        
        public GridEntityCollection<E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1Entity, E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1MLEntity, E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1SLEntity, E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1SLMLEntity> E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1 {
            get {
                return this._E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1;
            }
            set {
                this._E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1 = value;
            }
        }
    }
    
    [TableOptions(TableName="E_gorevatamasureci_feyza_GorevAtamaSureciML")]
    public class E_gorevatamasureci_feyza_GorevAtamaSureciMLEntity : MLEntity<E_gorevatamasureci_feyza_GorevAtamaSureciMLEntity> {
        
        private Bimser.Framework.Domain.DataField<string> _TAGorevTanimi;
        
        private Bimser.Framework.Domain.DataField<string> _TBGorevAdi;
        
        [ColumnOptionsAttribute(Name="TAGorevTanimi", Mandatory=false, Size=50)]
        public Bimser.Framework.Domain.DataField<string> TAGorevTanimi {
            get {
                return this._TAGorevTanimi;
            }
            set {
                this._TAGorevTanimi = value;
            }
        }
        
        [ColumnOptionsAttribute(Name="TBGorevAdi", Mandatory=false, Size=50)]
        public Bimser.Framework.Domain.DataField<string> TBGorevAdi {
            get {
                return this._TBGorevAdi;
            }
            set {
                this._TBGorevAdi = value;
            }
        }
    }
    
    [TableOptions(TableName="E_gorevatamasureci_feyza_GorevAtamaSureciSL")]
    public class E_gorevatamasureci_feyza_GorevAtamaSureciSLEntity : SLEntity<E_gorevatamasureci_feyza_GorevAtamaSureciSLEntity, E_gorevatamasureci_feyza_GorevAtamaSureciSLMLEntity> {
    }
    
    [TableOptions(TableName="E_gorevatamasureci_feyza_GorevAtamaSureciSLML")]
    public class E_gorevatamasureci_feyza_GorevAtamaSureciSLMLEntity : SLMLEntity<E_gorevatamasureci_feyza_GorevAtamaSureciSLMLEntity> {
    }
    
    [TableOptions(TableName="E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1")]
    public class E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1Entity : GridEntity<E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1Entity, E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1MLEntity, E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1SLEntity, E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1SLMLEntity> {
        
        private Bimser.Framework.Domain.DataField<System.Nullable<System.DateTimeOffset>> _column_date;
        
        public E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1Entity() {
        }
        
        [ColumnOptionsAttribute(Name="column_date", Mandatory=false)]
        public Bimser.Framework.Domain.DataField<System.Nullable<System.DateTimeOffset>> column_date {
            get {
                return this._column_date;
            }
            set {
                this._column_date = value;
            }
        }
    }
    
    [TableOptions(TableName="E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1ML")]
    public class E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1MLEntity : GridMLEntity<E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1MLEntity> {
        
        private Bimser.Framework.Domain.DataField<string> _column_id;
        
        private Bimser.Framework.Domain.DataField<string> _column_asama;
        
        private Bimser.Framework.Domain.DataField<string> _column_asamayorumu;
        
        [ColumnOptionsAttribute(Name="column_id", Mandatory=false, Size=19)]
        public Bimser.Framework.Domain.DataField<string> column_id {
            get {
                return this._column_id;
            }
            set {
                this._column_id = value;
            }
        }
        
        [ColumnOptionsAttribute(Name="column_asama", Mandatory=false, Size=19)]
        public Bimser.Framework.Domain.DataField<string> column_asama {
            get {
                return this._column_asama;
            }
            set {
                this._column_asama = value;
            }
        }
        
        [ColumnOptionsAttribute(Name="column_asamayorumu", Mandatory=false, Size=50)]
        public Bimser.Framework.Domain.DataField<string> column_asamayorumu {
            get {
                return this._column_asamayorumu;
            }
            set {
                this._column_asamayorumu = value;
            }
        }
    }
    
    [TableOptions(TableName="E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1SL")]
    public class E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1SLEntity : GridSLEntity<E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1SLEntity, E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1SLMLEntity> {
    }
    
    [TableOptions(TableName="E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1SLML")]
    public class E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1SLMLEntity : GridSLMLEntity<E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1SLMLEntity> {
    }
    
    [TableOptions(TableName="E_gorevatamasureci_feyza_GorevAtamaSureciVR")]
    public class E_gorevatamasureci_feyza_GorevAtamaSureciVREntity : VersionEntity<E_gorevatamasureci_feyza_GorevAtamaSureciVREntity> {
    }
    
    [TableOptions(TableName="E_gorevatamasureci_feyza_GorevAtamaSureciRDC")]
    public class E_gorevatamasureci_feyza_GorevAtamaSureciRDCEntity : RDCEntity<E_gorevatamasureci_feyza_GorevAtamaSureciRDCEntity, E_gorevatamasureci_feyza_GorevAtamaSureciRDCMLEntity> {
    }
    
    [TableOptions(TableName="E_gorevatamasureci_feyza_GorevAtamaSureciRDCML")]
    public class E_gorevatamasureci_feyza_GorevAtamaSureciRDCMLEntity : RDCMLEntity<E_gorevatamasureci_feyza_GorevAtamaSureciRDCMLEntity> {
    }
    
    [TableOptions(TableName="E_gorevatamasureci_feyza_GorevAtamaSureciRD")]
    public class E_gorevatamasureci_feyza_GorevAtamaSureciRDEntity : RDEntity<E_gorevatamasureci_feyza_GorevAtamaSureciRDEntity, E_gorevatamasureci_feyza_GorevAtamaSureciRDMLEntity> {
    }
    
    [TableOptions(TableName="E_gorevatamasureci_feyza_GorevAtamaSureciRDML")]
    public class E_gorevatamasureci_feyza_GorevAtamaSureciRDMLEntity : RDMLEntity<E_gorevatamasureci_feyza_GorevAtamaSureciRDMLEntity> {
    }
}




