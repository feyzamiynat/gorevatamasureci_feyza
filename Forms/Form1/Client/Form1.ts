let yuzdeDegeri =0;
export default class Form1 extends Form.Designer {


	async DTBaslangic_OnValueChanged(args: Controls.EventArgs.IPropertyChangedEventArgs<Date>) {
        this.tarihHesapla();
	}

	async DTBitis_OnValueChanged(args: Controls.EventArgs.IPropertyChangedEventArgs<Date>) {
        this.tarihHesapla();
	}

    /*async DTBitis_OnValueChanging(args: Controls.EventArgs.IPropertyChangingEventArgs<Date>) {
        if (this.DTBaslangic.value>this.DTBitis.value){
            this.showMessage("UYARI","Başlangıç Tarihi Bitiş Tarihinden Büyük Olamaz.","Warning");
            args.cancel=true; 
        }
	}*/

    async NB_KalanSure_OnValueChanged(args: Controls.EventArgs.IPropertyChangedEventArgs<number>) {
        this.tarihHesapla();
	}

    async NB_KalanSure_OnLoad(args: Controls.EventArgs.ILoadEventArgs) {
        this.tarihHesapla();
	}

    async Rate_TamamlamaYuzdesi_OnValueChanged(args: Controls.EventArgs.IPropertyChangedEventArgs<number>) {
        this.yuzdeHesapla();
	}

    async Rate_TamamlamaYuzdesi_OnValueChanging(args: Controls.EventArgs.IPropertyChangingEventArgs<number>) {
        this.yuzdeHesapla();
	}

    async DG_Tablo1_OnRowInserting(args: Controls.EventArgs.IRowInsertingEventArgs) {
        var dateNow = new Date();
        console.log(dateNow);
        args.row["column_date"]=dateNow;
        yuzdeDegeri = this.Rate_TamamlamaYuzdesi.value*5;
        args.row["column_asama"]=yuzdeDegeri
	}

    /*async DG_Tablo1_OnRowInserted(args: Controls.EventArgs.IRowInsertedEventArgs) {
        console.log(this.Rate_TamamlamaYuzdesi.value);
        args.row["column_asama"]=this.Rate_TamamlamaYuzdesi.value;
	}*/
    
    tarihHesapla () {
        const startDate = new Date(this.DTBaslangic.value);
        const endDate = new Date(this.DTBitis.value);
        const differenceInMilliseconds = endDate.getTime() - startDate.getTime();
        console.log('Difference in milliseconds:', differenceInMilliseconds);
        // Farkı gün cinsinden almak için
        const differenceInDays = differenceInMilliseconds / (1000 * 60 * 60 * 24);
        console.log('Difference in days:', differenceInDays);
        this.NB_KalanSure.value=differenceInDays;

        var dateNow = new Date();
        
        if(endDate > dateNow){
            this.NB_KalanSure.customClassName = "kalanSureVar";
        }
        else {
            this.NB_KalanSure.customClassName = "kalanSureYok";
        }
    }

    yuzdeHesapla () {
        var x = this.Rate_TamamlamaYuzdesi.value * 5 ;
        this.DG_Tablo1.rows[(this.DG_Tablo1.rows.length-1)].cells[2].value=x;
        console.log(x);
    }

	
}
