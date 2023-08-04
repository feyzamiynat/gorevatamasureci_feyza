using System;
using System.Collections.Generic;
using Bimser.Synergy.Entities.DataSource;
using Bimser.Synergy.Entities.DataSource.Providers;
using Bimser.CSP.FormControls.Base;
using Bimser.CSP.FormControls.Common;
using Bimser.CSP.FormControls.Controls;
using Bimser.CSP.FormControls.RuleManager;
using Bimser.CSP.FormControls.Enums;
using Bimser.Framework.Monitoring;
using Newtonsoft.Json;
using gorevatamasureci_feyza.Entities;

namespace gorevatamasureci_feyza.Forms {

    public partial class Form1 : Form<E_gorevatamasureci_feyza_GorevAtamaSureciEntity> {

        // properties
        Collapse Collapse1 { get; set; }
UserMetadata MDAdSoyad { get; set; }
DateTimePicker DTBitis { get; set; }
RadioList RadioList_GorevOnemDerecesi { get; set; }
DocumentMetadata DocMDdatetime { get; set; }
Tab Collapse_YapilacakAksiyonlar { get; set; }
DateTimePicker DTBaslangic { get; set; }
DocumentMetadata DocMDgorevno { get; set; }
NumberBox NB_KalanSure { get; set; }
Panel Panel1 { get; set; }
Tab Collapse_GorevBilgileri { get; set; }
ComboBox CBGorevlendirilecekPers { get; set; }
TextArea TAGorevTanimi { get; set; }
RelatedDocuments RDGorevDosyalari { get; set; }
DataGrid DG_Tablo1 { get; set; }
Tab Collapse_AtanacakPersBilg { get; set; }
TextBox TBGorevAdi { get; set; }
ListBox LB_GorevSorulari { get; set; }
FormMetadata FormMetadata1 { get; set; }
Rate Rate_TamamlamaYuzdesi { get; set; }


        // constructor
        public Form1(FormHttpParameters httpParameters, ITelemetryCollectorHolder telemetryCollectorHolder = null)
 : base(httpParameters, telemetryCollectorHolder)
        {

        }

        // initialize members
        public override void InitMembers ()
        {
            
BaseComponent default_column8Component = new BaseComponent {
Id = "Column8",
Type = "Column",
ParentId = "Section8",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Collapse1",
"Panel1",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_column8Component);

BaseComponent default_column9Component = new BaseComponent {
Id = "Column9",
Type = "Column",
ParentId = "Section3",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"DocMDdatetime",
"DocMDgorevno",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_column9Component);

Collapse1 = new Collapse {
ControlId = "19888a6e-fec4-76d6-8de0-6cd58285fbe3",
Name = "Collapse1",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Collapse1" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
ReadOnly = false,
DefaultReadOnly = false,
Items = new List<TabItem> {
new TabItem {
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Atanacak Personel Bilgileri" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Key = "Collapse_AtanacakPersBilg",
Enabled = true,
Icon = "general",
OrderNo = 0,
Selected = true
},
new TabItem {
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Yapılacak Aksiyonlar" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Key = "Collapse_YapilacakAksiyonlar",
Enabled = true,
Icon = "general",
OrderNo = 1,
Selected = false
},
new TabItem {
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Görev Bilgileri" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Key = "Collapse_GorevBilgileri",
Enabled = true,
Icon = "general",
OrderNo = 2,
Selected = false
},
},
SelectedIndex = 0,
TabPosition = Position.Top,
HasScrollbar = false,
Accordion = false,
ToolboxItems = new List<ToolboxItem> {
},
};

Controls.Add(Collapse1);

BaseComponent default_collapse1Component = new BaseComponent {
Id = "Collapse1",
Type = "Collapse",
ParentId = "Column8",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Collapse_GorevBilgileri",
"Collapse_YapilacakAksiyonlar",
"Collapse_AtanacakPersBilg",
},
Properties = Collapse1,
ViewProperties = "",
};

AddToViewItems("default", default_collapse1Component);

MDAdSoyad = new UserMetadata {
ControlId = "3792f923-4ccb-403c-6ba9-9c217c5e46b6",
Name = "MDAdSoyad",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Amir Adı" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "UserMetadata1",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
MetadataType = UserMetadataType.NameAndSurname,
CustomMetadataName = "",
SizeType = null,
PropertyType = UserMetadataOptionTypes.Text,
LocationDataType = LocationDataType.Coordinates,
};

Controls.Add(MDAdSoyad);

BaseComponent default_mdadsoyadComponent = new BaseComponent {
Id = "MDAdSoyad",
Type = "UserMetadata",
ParentId = "Column3",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = MDAdSoyad,
ViewProperties = "",
};

AddToViewItems("default", default_mdadsoyadComponent);

DTBitis = new DateTimePicker {
ControlId = "58acb94a-6c27-e83e-3c5f-0211b7e037cf",
Name = "DTBitis",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
new EventItem {
Name = "OnValueChanged",
MethodName = "DTBitis_OnValueChanged",
Async = null
},
new EventItem {
Name = "OnValueChanging",
MethodName = "DTBitis_OnValueChanging",
Async = null
},
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Görev Bitiş Tarihi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "DTBitis",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
Format = "",
SetTodayAsDefault = false,
ShowTime = false,
ShowToday = false,
AllowClear = true,
DisableBefore = new DisableDate(){
Enabled = true,
Years = 0,
Months = 0,
Days = 0,
},
DisableAfter = new DisableDate(){
Enabled = false,
Years = 0,
Months = 0,
Days = 0,
},
SizeType = null,
};

Controls.Add(DTBitis);

BaseComponent default_dtbitisComponent = new BaseComponent {
Id = "DTBitis",
Type = "DateTimePicker",
ParentId = "Column2",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = DTBitis,
ViewProperties = "",
};

AddToViewItems("default", default_dtbitisComponent);

RadioList_GorevOnemDerecesi = new RadioList {
ControlId = "eb4c436d-0fc5-af9b-e4cf-da0073bd0131",
Name = "RadioList_GorevOnemDerecesi",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Görev Önem Derecesi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "SL.RadioList_GorevOnemDerecesi",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
TabIndex = 0,
Value = null,
DataSource = new DataSource {
},
DataSourceType = DataSourceType.Static,
ValueType = PrimitiveType.String,
DateValueFormat = "",
DecimalValuePrecision = 0,
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
AllowClear = true,
Direction = Direction.Vertical,
ButtonType = RadioListButtonType.Radio,
ShowSearch = false,
};

Controls.Add(RadioList_GorevOnemDerecesi);
RadioList_GorevOnemDerecesi.Items = new ListItemCollection();

RadioList_GorevOnemDerecesi.Items.Add(new ListItem {
Value = "rl_dusuk",
Key = "rl_dusuk",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Düşük" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

RadioList_GorevOnemDerecesi.Items.Add(new ListItem {
Value = "rl_orta",
Key = "rl_orta",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Orta" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

RadioList_GorevOnemDerecesi.Items.Add(new ListItem {
Value = "rl_yüksek",
Key = "rl_yüksek",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Yüksek" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

RadioList_GorevOnemDerecesi.Items.Add(new ListItem {
Value = "rl_kritik",
Key = "rl_kritik",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Kritik" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

BaseComponent default_radiolist_gorevonemderecesiComponent = new BaseComponent {
Id = "RadioList_GorevOnemDerecesi",
Type = "RadioList",
ParentId = "Column2",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = RadioList_GorevOnemDerecesi,
ViewProperties = "",
};

AddToViewItems("default", default_radiolist_gorevonemderecesiComponent);

DocMDdatetime = new DocumentMetadata {
ControlId = "3cfcfd94-5878-7c03-dd41-59732094f14b",
Name = "DocMDdatetime",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Görev Başlangıç Tarihi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "CREATEDAT",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
MetadataType = DocumentMetadataType.CreateDate,
DateFormat = "DD.MM.YYYY",
PullNumberOnStart = false,
PullNewNumber = false,
SizeType = null,
};

Controls.Add(DocMDdatetime);

BaseComponent default_docmddatetimeComponent = new BaseComponent {
Id = "DocMDdatetime",
Type = "DocumentMetadata",
ParentId = "Column9",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = DocMDdatetime,
ViewProperties = "",
};

AddToViewItems("default", default_docmddatetimeComponent);

Collapse_YapilacakAksiyonlar = new Tab {
ControlId = "d9b9bcc5-c9ee-717e-e446-63e8ef347f85",
Name = "Collapse_YapilacakAksiyonlar",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "10px 15px 10px 15px",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Yapılacak Aksiyonlar" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
ReadOnly = false,
DefaultReadOnly = false,
HeaderMode = HeaderMode.Titled,
CollapsedDefault = false,
TitleFont = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "12",
Color = "",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Key = "",
Selected = false,
Icon = "general",
OrderNo = 1
};

Controls.Add(Collapse_YapilacakAksiyonlar);

BaseComponent default_collapse_yapilacakaksiyonlarComponent = new BaseComponent {
Id = "Collapse_YapilacakAksiyonlar",
Type = "Tab",
ParentId = "Collapse1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Section4",
},
Properties = Collapse_YapilacakAksiyonlar,
ViewProperties = "",
};

AddToViewItems("default", default_collapse_yapilacakaksiyonlarComponent);

DTBaslangic = new DateTimePicker {
ControlId = "55f8601a-2168-5029-0d17-fef3554de4f2",
Name = "DTBaslangic",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
new EventItem {
Name = "OnValueChanged",
MethodName = "DTBaslangic_OnValueChanged",
Async = null
},
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Görev Başlangıç Tarihi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "DTBaslangic",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
Format = "",
SetTodayAsDefault = false,
ShowTime = false,
ShowToday = false,
AllowClear = true,
DisableBefore = new DisableDate(){
Enabled = false,
Years = 0,
Months = 0,
Days = 0,
},
DisableAfter = new DisableDate(){
Enabled = false,
Years = 0,
Months = 0,
Days = 0,
},
SizeType = null,
};

Controls.Add(DTBaslangic);

BaseComponent default_dtbaslangicComponent = new BaseComponent {
Id = "DTBaslangic",
Type = "DateTimePicker",
ParentId = "Column2",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = DTBaslangic,
ViewProperties = "",
};

AddToViewItems("default", default_dtbaslangicComponent);

BaseComponent default_section2Component = new BaseComponent {
Id = "Section2",
Type = "Section",
ParentId = "Collapse_AtanacakPersBilg",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column2",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_section2Component);

DocMDgorevno = new DocumentMetadata {
ControlId = "8809181d-98a3-04c4-fbad-4bd657564468",
Name = "DocMDgorevno",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Görev No" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "UNIQUEID",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
MetadataType = DocumentMetadataType.Id,
DateFormat = "",
PullNumberOnStart = true,
PullNewNumber = false,
SizeType = null,
};

Controls.Add(DocMDgorevno);

BaseComponent default_docmdgorevnoComponent = new BaseComponent {
Id = "DocMDgorevno",
Type = "DocumentMetadata",
ParentId = "Column9",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = DocMDgorevno,
ViewProperties = "",
};

AddToViewItems("default", default_docmdgorevnoComponent);

NB_KalanSure = new NumberBox {
ControlId = "3e85a343-9fc4-7abb-32e0-6d272b29d90c",
Name = "NB_KalanSure",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
new EventItem {
Name = "OnValueChanged",
MethodName = "NB_KalanSure_OnValueChanged",
Async = null
},
new EventItem {
Name = "OnLoad",
MethodName = "NB_KalanSure_OnLoad",
Async = null
},
new EventItem {
Name = "OnClick",
MethodName = "NB_KalanSure_OnClick",
Async = null
},
},
Visible = true,
ClientVisible = false,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Görev İçin Kalan Süre (Gün)" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "rgb(0, 0, 0)",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "NB_KalanSure",
ReadOnly = true,
DefaultReadOnly = true,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Right,
Min = null,
Max = 99999999999999M,
Step = 1M,
Precision = 0,
UseThousandSeparator = false,
OnlyNumber = false,
SizeType = null,
};

Controls.Add(NB_KalanSure);

BaseComponent default_nb_kalansureComponent = new BaseComponent {
Id = "NB_KalanSure",
Type = "NumberBox",
ParentId = "Column10",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = NB_KalanSure,
ViewProperties = "",
};

AddToViewItems("default", default_nb_kalansureComponent);

Panel1 = new Panel {
ControlId = "8b209cb9-1817-529a-9aa7-9613c0f3ac84",
Name = "Panel1",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "10px 15px 10px 15px",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Panel1" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
ReadOnly = true,
DefaultReadOnly = true,
HeaderMode = HeaderMode.None,
CollapsedDefault = false,
TitleFont = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "12",
Color = "",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
};

Controls.Add(Panel1);

BaseComponent default_panel1Component = new BaseComponent {
Id = "Panel1",
Type = "Panel",
ParentId = "Column8",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Section9",
},
Properties = Panel1,
ViewProperties = "",
};

AddToViewItems("default", default_panel1Component);

ClientVisible = true;
ProjectName = "gorevatamasureci_feyza";
ProjectId = "157aefb6-a94d-4c58-885b-f9cf3cb4c079";
EntityPath = "";
ActiveView = "default";
Version = 10;
ReadOnly = false;
DefaultReadOnly = false;
Text = new Dictionary<string, string> {
{ "tr-TR", "Form1" },
{ "en-US", "Form1" },
};
Name = "Form1";
FormId = "6bc26f74-d244-4439-aeec-9bea8fecd91e";
FormType = FormType.Standard;
ServerEvents = new List<EventItem> {
};
ClientEvents = new List<EventItem> {
new EventItem {
Name = "OnBeforeSave",
MethodName = "Form1_OnBeforeSave",
Async = null
},
};
Statuses = new List<DocumentStatus> {
};
IdentityFormat = "gorevnumarasi_feyza";
IdentityFormatId = 135;
PrintingEnabled = false;
PrintView = "default";
CopyPasteEnabled = false;
VersioningEnabled = false;
CanSaveAsDraft = false;
PanelSize = 2;
Style = new Style {
Padding = "10px 20px 10px 20px",
BackgroundColor = "rgba(255, 255, 255, 0)",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
};
PublicFields = new List<FormPublicField> {
};
ToolbarButtons = new List<ToolbarButton> {
new ToolbarButton {
Key = "toolbarSaveButton",
Name = "Kaydet",
Icon = "save",
Enabled = true,
DefaultEnabled = true,
Validate = false,
Caption = new Dictionary<string, string> {
{ "tr-TR", "Kaydet" },
{ "en-US", "Save" },
},
View = "",
IsServerPrint = false,
},
};
Variables = new Dictionary<string, object> {
};
Rules = new Dictionary<string, Rule> {
{
"6af49538-438f-32fc-9554-d178a4acf0e4",
new Rule {
Id = "6af49538-438f-32fc-9554-d178a4acf0e4",
Name = "Pozisyon1'e gelene kadar visible kapalı",
Enabled = true,
OrderNo = 0,
Statements = new List<BaseStatement> {
new IfStatement {
Id = "d66b6503-8Panel1c4-bbf1-0c46-dea159f575be",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValueAssignActionWithEntry {
Id = "7345f243-696Panel1-daa7-b14f-c3561bd50987",
Name = "Eylem 1",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "DG_Tablo1",
PropertyName = "clientVisible",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "bdPanel1ef29a-8ce9-fd0f-f58e-95f5f678251e",
Name = "Eylem 2",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "NB_KalanSure",
PropertyName = "clientVisible",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "1f228e39-5573-e378-3319-68f2e6106500",
Name = "Eylem 3",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "Rate_TamamlamaYuzdesi",
PropertyName = "clientVisible",
Type = FieldValueType.Boolean,
},
Value = true
},
},
ConditionGroup = new AndConditionGroup {
Id = "3343a6cd-d926-2f67-aa9a-3c8149252075",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "7Panel1564d33-9f80-af59-49d3-d7585f8e3b13",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "Form1",
PropertyName = "responseParameters.workflowInfo.currentStep.name",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "Position1"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
},
Actions = new List<BaseAction> {
new ValueAssignActionWithEntry {
Id = "7345f243-696Panel1-daa7-b14f-c3561bd50987",
Name = "Eylem 1",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "DG_Tablo1",
PropertyName = "clientVisible",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "bdPanel1ef29a-8ce9-fd0f-f58e-95f5f678251e",
Name = "Eylem 2",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "NB_KalanSure",
PropertyName = "clientVisible",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "1f228e39-5573-e378-3319-68f2e6106500",
Name = "Eylem 3",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "Rate_TamamlamaYuzdesi",
PropertyName = "clientVisible",
Type = FieldValueType.Boolean,
},
Value = true
},
},
TriggerEvents = new List<string> {
"Form1.client.OnLoad",
}
}
},
{
"FormRequiredFields",
new Rule {
Id = "FormRequiredFields",
Name = "Personel Adı Boş Olamaz",
Enabled = true,
OrderNo = 0,
Statements = new List<BaseStatement> {
new IfStatement {
Id = "FormRequiredFields_StPanel1tement_default_CBGorevlendirilecekPers",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToPanel1sterMessage_default_CBGorevlendirilecekPers",
Name = "Uyarı",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Görevlendirilecek personel değeri boş olamaz."
},
{
"en-US",
"Görevlendirilecek Personel: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"CBGorevlendirilecekPers",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_default_CBGorevlendirilecekPers",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FormRequiredFields_Condition_defPanel1ult_CBGorevlendirilecekPers_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "CBGorevlendirilecekPers",
PropertyName = "value",
Type = FieldValueType.String,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FormRequiredFields_View_Condition_defPanel1ult_CBGorevlendirilecekPers",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "Form1",
PropertyName = "activeView",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "default"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
},
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToPanel1sterMessage_default_CBGorevlendirilecekPers",
Name = "Uyarı",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Görevlendirilecek personel değeri boş olamaz."
},
{
"en-US",
"Görevlendirilecek Personel: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"CBGorevlendirilecekPers",
},
},
},
TriggerEvents = new List<string> {
"Form1.client.OnBeforeSave",
"Form1.server.OnBeforeSave",
"Form1.client.OnToolbarButtonClicked",
"Form1.server.OnToolbarButtonClicked",
}
}
},
{
"d2ebd3e8-644d-b142-8f9a-9872be9f64aa",
new Rule {
Id = "d2ebd3e8-644d-b142-8f9a-9872be9f64aa",
Name = "Başlangıç ve Bitiş Tarihi Boş Olamaz",
Enabled = true,
OrderNo = 2,
Statements = new List<BaseStatement> {
new IfStatement {
Id = "df185a57-7940-ef63-7c7b-f5b430923a6b",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "d42fdd59-62a6-79d8-e30d-beab17c10b2c",
Name = "Uyarı",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Başlangıç tarihi değeri boş olamaz."
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"DTBaslangic",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "5ce3ead7-f2ac-df22-47eb-dfd3b7eb7c05",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "97cf0de9-9c5e-3a1d-5c1b-feaf10977da1",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "DTBaslangic",
PropertyName = "text",
Type = FieldValueType.String,
},
Operation = OperationType.Null,
Value = "null"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new IfStatement {
Id = "e0fef923-bb00-6e90-b7fd-afd893fe5866",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "dfbb750d-b906-47ea-ab81-859ab419f54d",
Name = "Uyar",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Bitiş tarihi değeri boş olamaz."
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"DTBitis",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "b820e516-9c7c-1b8f-f563-eda2c79cb55d",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "e0440da5-0677-9a43-4858-555c3d4964e6",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "DTBitis",
PropertyName = "text",
Type = FieldValueType.String,
},
Operation = OperationType.Null,
Value = null
},
},
Children = new List<BaseConditionGroup> {
},
},
},
},
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "d42fdd59-62a6-79d8-e30d-beab17c10b2c",
Name = "Uyarı",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Başlangıç tarihi değeri boş olamaz."
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"DTBaslangic",
},
},
new ValidationFailureAction {
Id = "dfbb750d-b906-47ea-ab81-859ab419f54d",
Name = "Uyar",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Bitiş tarihi değeri boş olamaz."
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"DTBitis",
},
},
},
TriggerEvents = new List<string> {
"Form1.client.OnBeforeSave",
}
}
},
{
"bd909c3c-1a28-c113-cf2e-ead1b27b0ace",
new Rule {
Id = "bd909c3c-1a28-c113-cf2e-ead1b27b0ace",
Name = "PanelAktiflestirme",
Enabled = true,
OrderNo = 3,
Statements = new List<BaseStatement> {
new IfStatement {
Id = "ce33e64f-7be8-95d8-332d-f30dcff0870e",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValueAssignActionWithEntry {
Id = "a604bad2-b700-5a2a-81e9-0121e794c7a2",
Name = "collapse nesnesi",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "Collapse1",
PropertyName = "readOnly",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "2c99d238-3c28-b97a-ef31-d7ffe00b9866",
Name = "başlangıç",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "DTBaslangic",
PropertyName = "readOnly",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "fc76060c-ec72-a1d4-6a86-72f512a83528",
Name = "bitiş",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "DTBitis",
PropertyName = "readOnly",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "360cf69c-c78c-9dc6-3860-2b9337ba45e4",
Name = "ratelist",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "RadioList_GorevOnemDerecesi",
PropertyName = "readOnly",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "f35f20a1-a658-d4c5-bdc6-93d1a18ebb74",
Name = "listbox",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "LB_GorevSorulari",
PropertyName = "readOnly",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "8a29272c-badc-7722-ac35-2f39291dbe7f",
Name = "görev adı",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "TBGorevAdi",
PropertyName = "readOnly",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "aa49585e-b5fb-026d-0694-2a32d99d94d5",
Name = "görev tanımı",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "TAGorevTanimi",
PropertyName = "readOnly",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "b5adf3c6-1033-7304-e160-a48936f4f18f",
Name = "dosyalar",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "RDGorevDosyalari",
PropertyName = "readOnly",
Type = FieldValueType.Boolean,
},
Value = true
},
},
ConditionGroup = new AndConditionGroup {
Id = "cc90d3ec-5be3-1ce0-992d-f61c59ad8736",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "51274136-f2cc-b55a-dc2c-9eff770cd0b3",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "Form1",
PropertyName = "responseParameters.workflowInfo.currentStep.name",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "Position1"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
},
Actions = new List<BaseAction> {
new ValueAssignActionWithEntry {
Id = "a604bad2-b700-5a2a-81e9-0121e794c7a2",
Name = "collapse nesnesi",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "Collapse1",
PropertyName = "readOnly",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "2c99d238-3c28-b97a-ef31-d7ffe00b9866",
Name = "başlangıç",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "DTBaslangic",
PropertyName = "readOnly",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "fc76060c-ec72-a1d4-6a86-72f512a83528",
Name = "bitiş",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "DTBitis",
PropertyName = "readOnly",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "360cf69c-c78c-9dc6-3860-2b9337ba45e4",
Name = "ratelist",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "RadioList_GorevOnemDerecesi",
PropertyName = "readOnly",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "f35f20a1-a658-d4c5-bdc6-93d1a18ebb74",
Name = "listbox",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "LB_GorevSorulari",
PropertyName = "readOnly",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "8a29272c-badc-7722-ac35-2f39291dbe7f",
Name = "görev adı",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "TBGorevAdi",
PropertyName = "readOnly",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "aa49585e-b5fb-026d-0694-2a32d99d94d5",
Name = "görev tanımı",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "TAGorevTanimi",
PropertyName = "readOnly",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "b5adf3c6-1033-7304-e160-a48936f4f18f",
Name = "dosyalar",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "RDGorevDosyalari",
PropertyName = "readOnly",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "44bef98a-ebaf-29ad-3fe7-1921b432acc0",
Name = "panel",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "Panel1",
PropertyName = "readOnly",
Type = FieldValueType.Boolean,
},
Value = false
},
},
TriggerEvents = new List<string> {
"Form1.client.OnLoad",
}
}
},
{
"45a52270-f7de-213f-3007-8304f0a8486e",
new Rule {
Id = "45a52270-f7de-213f-3007-8304f0a8486e",
Name = "Başlangıç Tarihi Bitiş Tarihinden Büyük Olamaz",
Enabled = true,
OrderNo = 4,
Statements = new List<BaseStatement> {
new IfStatement {
Id = "2ab21bc0-4970-b7d5-9356-f7e15c32c50c",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "6f0f3bf6-3e4f-27aa-43e5-c6258931a1e9",
Name = "Uyarı",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Başlangıç tarihi bitiş tarihinden büyük olamaz."
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"DTBitis",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "3b4d5de8-eb4b-7518-aaf6-0af569d48c50",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new FieldSelectionCondition {
Id = "ed35645c-13a3-472e-32b7-959807a4584d",
TypeName = ConditionType.FieldSelectionCondition,
Field = new ConditionField {
Name = "DTBaslangic",
PropertyName = "value",
Type = FieldValueType.Date,
},
Operation = OperationType.GreaterThan,
SelectedField = new ConditionField {
Name = "DTBitis",
PropertyName = "value",
Type = FieldValueType.Date,
}
},
},
Children = new List<BaseConditionGroup> {
},
},
},
},
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "6f0f3bf6-3e4f-27aa-43e5-c6258931a1e9",
Name = "Uyarı",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Başlangıç tarihi bitiş tarihinden büyük olamaz."
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"DTBitis",
},
},
},
TriggerEvents = new List<string> {
"Form1.client.OnBeforeSave",
}
}
},
{
"4028bd0e-d2fd-d29c-9705-ac0b8aca859e",
new Rule {
Id = "4028bd0e-d2fd-d29c-9705-ac0b8aca859e",
Name = "Amir Görünürlük Ayarları",
Enabled = true,
OrderNo = 5,
Statements = new List<BaseStatement> {
new IfStatement {
Id = "f7a24949-6bb8-ac36-fabd-f8cd5ea0b59f",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValueAssignActionWithEntry {
Id = "8eba871c-0ec6-d85a-f8cf-8ef1589faf5d",
Name = "dg görünürlük",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "DG_Tablo1",
PropertyName = "clientVisible",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "751073aa-da7d-4fef-e7dd-34911c733c43",
Name = "kalan süre görünürlük",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "NB_KalanSure",
PropertyName = "clientVisible",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "a28894b2-83f3-347a-d475-e1ea871ec9a1",
Name = "yıldız görünürlük",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "Rate_TamamlamaYuzdesi",
PropertyName = "clientVisible",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "7c47eba9-90d3-eb33-2ab7-4d8c466c61f8",
Name = "panel görünürlük",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "Panel1",
PropertyName = "clientVisible",
Type = FieldValueType.Boolean,
},
Value = true
},
},
ConditionGroup = new AndConditionGroup {
Id = "300882c8-22a0-2225-6068-14e53991ccf6",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "dcfe130a-b1e6-0ca9-5772-ae74dfd50272",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "Form1",
PropertyName = "responseParameters.workflowInfo.currentStep.name",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "Position2"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
},
Actions = new List<BaseAction> {
new ValueAssignActionWithEntry {
Id = "8eba871c-0ec6-d85a-f8cf-8ef1589faf5d",
Name = "dg görünürlük",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "DG_Tablo1",
PropertyName = "clientVisible",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "751073aa-da7d-4fef-e7dd-34911c733c43",
Name = "kalan süre görünürlük",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "NB_KalanSure",
PropertyName = "clientVisible",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "a28894b2-83f3-347a-d475-e1ea871ec9a1",
Name = "yıldız görünürlük",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "Rate_TamamlamaYuzdesi",
PropertyName = "clientVisible",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "7c47eba9-90d3-eb33-2ab7-4d8c466c61f8",
Name = "panel görünürlük",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "Panel1",
PropertyName = "clientVisible",
Type = FieldValueType.Boolean,
},
Value = true
},
},
TriggerEvents = new List<string> {
"Form1.client.OnLoad",
}
}
},
};
CheckInCheckOut = new CheckInCheckOutOptions {
Enabled = false,
Timeout = 10,
AdditionalTime = 5,
};
SizeType = SizeType.Middle;
PaddingType = SizeType.Middle;
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "GorevAtamaSureci" },{ "en-US", "GorevAtamaSureci" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
};

Controls.Add(this);

BaseComponent default_form1Component = new BaseComponent {
Id = "Form1",
Type = "Form",
ParentId = "",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Section3",
"Section8",
},
Properties = this,
ViewProperties = "",
};

AddToViewItems("default", default_form1Component);

Collapse_GorevBilgileri = new Tab {
ControlId = "522bc0ec-0700-3a53-141c-ca820876cc36",
Name = "Collapse_GorevBilgileri",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "10px 15px 10px 15px",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Görev Bilgileri" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
ReadOnly = false,
DefaultReadOnly = false,
HeaderMode = HeaderMode.Titled,
CollapsedDefault = false,
TitleFont = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "12",
Color = "",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Key = "",
Selected = false,
Icon = "general",
OrderNo = 2
};

Controls.Add(Collapse_GorevBilgileri);

BaseComponent default_collapse_gorevbilgileriComponent = new BaseComponent {
Id = "Collapse_GorevBilgileri",
Type = "Tab",
ParentId = "Collapse1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Section5",
},
Properties = Collapse_GorevBilgileri,
ViewProperties = "",
};

AddToViewItems("default", default_collapse_gorevbilgileriComponent);

BaseComponent default_section3Component = new BaseComponent {
Id = "Section3",
Type = "Section",
ParentId = "Form1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column3",
"Column9",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_section3Component);

BaseComponent default_section4Component = new BaseComponent {
Id = "Section4",
Type = "Section",
ParentId = "Collapse_YapilacakAksiyonlar",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column4",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_section4Component);

BaseComponent default_section5Component = new BaseComponent {
Id = "Section5",
Type = "Section",
ParentId = "Collapse_GorevBilgileri",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column5",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_section5Component);

CBGorevlendirilecekPers = new ComboBox {
ControlId = "2f5fe92b-60ec-782b-616d-ca5d6ee0cade",
Name = "CBGorevlendirilecekPers",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Görevlendirilecek Personel" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "SL.CBGorevlendirilecekPers",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
TabIndex = 0,
Value = null,
DataSource = new DataSource {
Name = "DataSource_PersonelBilgileri",
ValueMember = "ID",
DisplayMember = new List<string>{
"FIRSTNAME",
"LASTNAME",
},
DisplayFormat = "{{ FIRSTNAME }} {{ LASTNAME }}",
Culture = "",
CultureMember = "",
MultiLanguagePath = "",
RunAtServer = false,
Field = "",
Parameters = new List<DataSourceParameter>{
},
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
ConnectionType = DataSourceConnectionType.MSSQL,
},
DataSourceType = DataSourceType.Dynamic,
ValueType = PrimitiveType.String,
DateValueFormat = "",
DecimalValuePrecision = 0,
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
AllowClear = true,
ShowSearch = false,
SizeType = null,
IconMatchers = new List<IconMatchers>{
},
IconExpr = "",
};

Controls.Add(CBGorevlendirilecekPers);
CBGorevlendirilecekPers.Items = new ListItemCollection();

BaseComponent default_cbgorevlendirilecekpersComponent = new BaseComponent {
Id = "CBGorevlendirilecekPers",
Type = "ComboBox",
ParentId = "Column2",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = CBGorevlendirilecekPers,
ViewProperties = "",
};

AddToViewItems("default", default_cbgorevlendirilecekpersComponent);

TAGorevTanimi = new TextArea {
ControlId = "0b5b38de-5c5a-63db-efcc-f9718ca34a7e",
Name = "TAGorevTanimi",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Görev Tanımı" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "ML.TAGorevTanimi",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
MaxLength = 50,
IsSecretData = false,
EnableMultiLanguageText = false,
ShowCharacterCounter = false,
MultiLanguageText = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Rows = 3
};

Controls.Add(TAGorevTanimi);

BaseComponent default_tagorevtanimiComponent = new BaseComponent {
Id = "TAGorevTanimi",
Type = "TextArea",
ParentId = "Column5",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = TAGorevTanimi,
ViewProperties = "",
};

AddToViewItems("default", default_tagorevtanimiComponent);

BaseComponent default_section8Component = new BaseComponent {
Id = "Section8",
Type = "Section",
ParentId = "Form1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column8",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_section8Component);

RDGorevDosyalari = new RelatedDocuments {
ControlId = "8d27f12a-d1ea-c8b2-2f50-ece7951b3cd7",
Name = "RDGorevDosyalari",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Görev ile İlgili Dosyalar" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "RD.RDGorevDosyalari",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
Categories = new List<RelatedDocumentCategory> {
new RelatedDocumentCategory {
Id = 0,
CategoryId = "8cdc7a6d-994e-4b01-1950-e4190f50a91e",
Name = new Dictionary<string, string> {
{ "tr-TR", "Varsayılan" },
},
Description = new Dictionary<string, string> {
{ "tr-TR", "Varsayılan" },
},
MinFilesCount = 0,
MaxFilesCount = null,
MaxFileSize = null,
AllowedFileExtensions = new List<string> {
},
Enabled = true,
Path = "",
TargetId = ""
},
},
Files = new List<RelatedDocumentFile> {
},
AddingMode = RelatedDocumentsAddingMode.All,
ViewType = RelatedDocumentsViewType.Card,
AddNewEnabled = true,
DeleteEnabled = true,
Viewable = true,
CreateEnabled = false,
Path = "",
ShowCategoryDescription = false,
ShowFileDescription = false,
FileDescriptionIsRequired = false,
ShowContentForImageFiles = false,
ShowCreateDate = true,
ShowCreator = false,
ShowFileExtension = true,
ShowPath = true,
TargetId = "",
};

Controls.Add(RDGorevDosyalari);

BaseComponent default_rdgorevdosyalariComponent = new BaseComponent {
Id = "RDGorevDosyalari",
Type = "RelatedDocuments",
ParentId = "Column5",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = RDGorevDosyalari,
ViewProperties = "",
};

AddToViewItems("default", default_rdgorevdosyalariComponent);

BaseComponent default_section9Component = new BaseComponent {
Id = "Section9",
Type = "Section",
ParentId = "Panel1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column10",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_section9Component);

BaseComponent default_column10Component = new BaseComponent {
Id = "Column10",
Type = "Column",
ParentId = "Section9",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"NB_KalanSure",
"Rate_TamamlamaYuzdesi",
"DG_Tablo1",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_column10Component);

DG_Tablo1 = new DataGrid {
ControlId = "11cfc2c9-2e1c-29b1-c55e-e1f5ed0a360c",
Name = "DG_Tablo1",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
new EventItem {
Name = "OnRowInserting",
MethodName = "DG_Tablo1_OnRowInserting",
Async = null
},
new EventItem {
Name = "OnRowInserted",
MethodName = "DG_Tablo1_OnRowInserted",
Async = null
},
new EventItem {
Name = "OnRowUpdated",
MethodName = "DG_Tablo1_OnRowUpdated",
Async = null
},
},
Visible = true,
ClientVisible = false,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "DG_Tablo" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "E_gorevatamasureci_feyza_GorevAtamaSureci_DG_Tablo1",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
DisplayType = DataGridDisplayType.AutoGrow,
Columns = new DataGridColumnCollection {
new GridColumn() {
EditControl = 
new NumberBox {
Visible = true,
EntityPath = "ML.column_id"
},
DbType = new ColumnDbType() {
ColumnName = "column_id",
Type = "string"
},
FormatType = new ColumnFormatType {
Type = "label",
Format = ""
},
DisableToExport = false,
Precision = 0,
UseThousandSeparator = false,
Align = HorizontalAlign.Left,
Caption = new Dictionary<string, string> {
{ "tr-TR", "ID" },
},
AllowHiding = true,
AllowNull = true,
HeaderFilterEnabled = false,
Style = new Dictionary<string, object> {
},
EditType = ColumnEditType.NumberBox,
EditingEnabled = true,
ShowEditorAlways = false,
Filtering = new DataGridColumnFilteringOptions {
Enabled = false,
Operation = DataGridFilteringOperation.Contains,
Value = "",
},
Index = 0,
Name = "column_id",
Sorting = new DataGridColumnSortingOptions {
Enabled = true,
Index = 0,
Order = DataGridSortingDirection.Asc,
},
SummaryTypes = new List<DataGridSummaryType> {
},
SummaryTypePrefixes = new List<DataGridColumnSummary> {
},
Width = "100",
WordWrapEnabled = false,
IsPrimaryKey = true,
IsGeneratedColumn = false,
Visible = false,
HidingPriority = null,
SourceType = GridColumnSourceType.Base64,
EnlargeOnClick = false,
ImageWidth = 100,
SizeUnit = GridColumnSizeUnit.Pixels,
ImageType = GridColumnImageType.SmallImage,
IconMatchers = new List<IconMatchers>{
},
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
AutoIncrement = true,
},
new GridColumn() {
EditControl = 
new DateTimePicker {
Visible = true,
EntityPath = "column_date",
Format = "",
},
DbType = new ColumnDbType() {
ColumnName = "column_date",
Type = "date"
},
FormatType = new ColumnFormatType {
Type = "label",
Format = ""
},
DisableToExport = false,
Precision = 0,
UseThousandSeparator = false,
Align = HorizontalAlign.Center,
Caption = new Dictionary<string, string> {
{ "tr-TR", "Tarih" },
},
AllowHiding = true,
AllowNull = true,
HeaderFilterEnabled = false,
Style = new Dictionary<string, object> {
},
EditType = ColumnEditType.DatePicker,
EditingEnabled = false,
ShowEditorAlways = false,
Filtering = new DataGridColumnFilteringOptions {
Enabled = false,
Operation = DataGridFilteringOperation.Contains,
Value = "",
},
Index = 0,
Name = "column_date",
Sorting = new DataGridColumnSortingOptions {
Enabled = true,
Index = 0,
Order = DataGridSortingDirection.Asc,
},
SummaryTypes = new List<DataGridSummaryType> {
},
SummaryTypePrefixes = new List<DataGridColumnSummary> {
},
Width = "100",
WordWrapEnabled = false,
IsPrimaryKey = false,
IsGeneratedColumn = false,
Visible = true,
HidingPriority = null,
SourceType = GridColumnSourceType.Base64,
EnlargeOnClick = false,
ImageWidth = 100,
SizeUnit = GridColumnSizeUnit.Pixels,
ImageType = GridColumnImageType.SmallImage,
IconMatchers = new List<IconMatchers>{
},
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
AutoIncrement = false,
},
new GridColumn() {
EditControl = 
new NumberBox {
Visible = true,
EntityPath = "ML.column_asama"
},
DbType = new ColumnDbType() {
ColumnName = "column_asama",
Type = "string"
},
FormatType = new ColumnFormatType {
Type = "label",
Format = ""
},
DisableToExport = false,
Precision = 0,
UseThousandSeparator = false,
Align = HorizontalAlign.Center,
Caption = new Dictionary<string, string> {
{ "tr-TR", "Aşama (%)" },
},
AllowHiding = true,
AllowNull = true,
HeaderFilterEnabled = false,
Style = new Dictionary<string, object> {
},
EditType = ColumnEditType.NumberBox,
EditingEnabled = false,
ShowEditorAlways = false,
Filtering = new DataGridColumnFilteringOptions {
Enabled = false,
Operation = DataGridFilteringOperation.Contains,
Value = "",
},
Index = 0,
Name = "column_asama",
Sorting = new DataGridColumnSortingOptions {
Enabled = true,
Index = 0,
Order = DataGridSortingDirection.Asc,
},
SummaryTypes = new List<DataGridSummaryType> {
},
SummaryTypePrefixes = new List<DataGridColumnSummary> {
},
Width = "100",
WordWrapEnabled = false,
IsPrimaryKey = false,
IsGeneratedColumn = false,
Visible = true,
HidingPriority = null,
SourceType = GridColumnSourceType.Base64,
EnlargeOnClick = false,
ImageWidth = 100,
SizeUnit = GridColumnSizeUnit.Pixels,
ImageType = GridColumnImageType.SmallImage,
IconMatchers = new List<IconMatchers>{
},
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
AutoIncrement = false,
},
new GridColumn() {
EditControl = 
new TextBox {
Value = "",
Text = "",
EntityPath = "ML.column_asamayorumu",
MaxLength = 50
},
DbType = new ColumnDbType() {
ColumnName = "column_asamayorumu",
Type = "string"
},
FormatType = new ColumnFormatType {
Type = "label",
Format = ""
},
DisableToExport = false,
Precision = 0,
UseThousandSeparator = false,
Align = HorizontalAlign.Center,
Caption = new Dictionary<string, string> {
{ "tr-TR", "Aşama Yorumu" },
},
AllowHiding = true,
AllowNull = true,
HeaderFilterEnabled = false,
Style = new Dictionary<string, object> {
},
EditType = ColumnEditType.TextBox,
EditingEnabled = true,
ShowEditorAlways = false,
Filtering = new DataGridColumnFilteringOptions {
Enabled = false,
Operation = DataGridFilteringOperation.Contains,
Value = "",
},
Index = 0,
Name = "column_asamayorumu",
Sorting = new DataGridColumnSortingOptions {
Enabled = true,
Index = 0,
Order = DataGridSortingDirection.Asc,
},
SummaryTypes = new List<DataGridSummaryType> {
},
SummaryTypePrefixes = new List<DataGridColumnSummary> {
},
Width = "100",
WordWrapEnabled = false,
IsPrimaryKey = false,
IsGeneratedColumn = false,
Visible = true,
HidingPriority = null,
SourceType = GridColumnSourceType.Base64,
EnlargeOnClick = false,
ImageWidth = 100,
SizeUnit = GridColumnSizeUnit.Pixels,
ImageType = GridColumnImageType.SmallImage,
IconMatchers = new List<IconMatchers>{
},
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
AutoIncrement = false,
},
},
Rows = new DataGridRowCollection {

},
DataSource = new DataSource {
Name = "",
ValueMember = "",
DisplayMember = new List<string>{
},
DisplayFormat = "",
Culture = "",
CultureMember = "",
MultiLanguagePath = "",
RunAtServer = false,
Field = "",
Parameters = new List<DataSourceParameter>{
},
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
ConnectionType = null,
},
ColumnSettings = new DataGridColumnOptions {
Orderable = false,
Resizeable = false,
ShowColumnChooser = false,
},
DetailRow = new DataGridDetailRowOptions {
Enabled = false,
},
Editing = new DataGridEditingOptions {
Enabled = false,
ShowAddCommand = true,
ShowEditCommand = true,
ShowDeleteCommand = true,
Mode = DataGridEditingModeType.Row,
},
Filtering = new DataGridFilteringOptions {
Enabled = false,
ShowOperationChooser = false,
HeaderFilterEnabled = false,
},
Grouping = new DataGridGroupingOptions {
Enabled = false,
},
Paging = new DataGridPagingOptions {
Enabled = true,
CurrentPage = 1,
PageSize = 10,
PagingSizes = new List<int> {
10,
20,
30,
40,
},
},
Searching = new DataGridSearchingOptions {
Enabled = false,
},
Selection = new DataGridSelectionOptions {
Enabled = false,
Mode = DataGridSelectionMode.Single,
SelectAllMode = DataGridSelectAllMode.Page,
ShowCheckBoxesMode = DataGridShowCheckBoxMode.OnClick,
ShowSelectAll = false,
Type = DataGridSelectionType.Rowselect,
DisabledValueColumnName = "",
DisabledValueMatchers = new List<object>{
},},
Sorting = new DataGridSortingOptions {
Enabled = false,
AllSortingColumns = true,
Mode = DataGridSortingMode.None,
},
TreeView = new DataGridTreeViewOptions {
Enabled = false,
Id = "",
ParentId = "",
},
AlternateColor = new DataGridAlternateColorOptions {
Enabled = true,
Color = "rgba(33, 150, 243, 0.05)",
},
RowDragging = new DataGridRowDraggingOptions {
Enabled = false,
ShowDragIcons = false,
},
ToolbarActionButtons = new List<ExecuteActionButton> {
},
FillForm = null,
Height = null,
ExportToExcel = false,
GridBorder = true,
ColumnVerticalBorder = true,
VirtualScrolling = false,
HoverStateEnabled = false,
ShowClearAllButton = false,
ColumnAutoWidth = true,
SaveAction = false,
WordWrapEnabled = false,
ColumnHidingEnabled = false,
ColumnFixingEnabled = false,
GridLines = DataGridLineType.Horizontal,
DataSourceType = DataSourceType.Dynamic,
HiddenRowColumnName = null,
HiddenRowValueMatchers = new DataGridHiddenRowValueOptions {
},
};

Controls.Add(DG_Tablo1);

BaseComponent default_dg_tablo1Component = new BaseComponent {
Id = "DG_Tablo1",
Type = "DataGrid",
ParentId = "Column10",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = DG_Tablo1,
ViewProperties = "",
};

AddToViewItems("default", default_dg_tablo1Component);

Collapse_AtanacakPersBilg = new Tab {
ControlId = "07a1b04f-3caf-ae4a-e837-b5a61398178e",
Name = "Collapse_AtanacakPersBilg",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "10px 15px 10px 15px",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Atanacak Personel Bilgileri" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
ReadOnly = false,
DefaultReadOnly = false,
HeaderMode = HeaderMode.Titled,
CollapsedDefault = false,
TitleFont = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "12",
Color = "",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Key = "",
Selected = true,
Icon = "general",
OrderNo = 0
};

Controls.Add(Collapse_AtanacakPersBilg);

BaseComponent default_collapse_atanacakpersbilgComponent = new BaseComponent {
Id = "Collapse_AtanacakPersBilg",
Type = "Tab",
ParentId = "Collapse1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Section2",
},
Properties = Collapse_AtanacakPersBilg,
ViewProperties = "",
};

AddToViewItems("default", default_collapse_atanacakpersbilgComponent);

TBGorevAdi = new TextBox {
ControlId = "4227ae85-0c5f-e6e8-d896-872dc69bfa24",
Name = "TBGorevAdi",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Görev Adı" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "ML.TBGorevAdi",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
MaxLength = 50,
IsSecretData = false,
EnableMultiLanguageText = false,
ShowCharacterCounter = false,
MultiLanguageText = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
SizeType = null,
};

Controls.Add(TBGorevAdi);

BaseComponent default_tbgorevadiComponent = new BaseComponent {
Id = "TBGorevAdi",
Type = "TextBox",
ParentId = "Column5",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = TBGorevAdi,
ViewProperties = "",
};

AddToViewItems("default", default_tbgorevadiComponent);

BaseComponent default_column2Component = new BaseComponent {
Id = "Column2",
Type = "Column",
ParentId = "Section2",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"CBGorevlendirilecekPers",
"DTBaslangic",
"DTBitis",
"RadioList_GorevOnemDerecesi",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_column2Component);

LB_GorevSorulari = new ListBox {
ControlId = "9e9d0d44-4ac4-0cd2-c01f-1a28f53892ff",
Name = "LB_GorevSorulari",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Görevlendirilecek personel" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "SL.LB_GorevSorulari",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
TabIndex = 0,
Value = null,
DataSource = new DataSource {
},
DataSourceType = DataSourceType.Static,
ValueType = PrimitiveType.String,
DateValueFormat = "",
DecimalValuePrecision = 0,
TextSeparator = ",",
ValueSeparator = ",",
ShowSearch = false,
Direction = Direction.Vertical,
AllowSelectAll = false
};

Controls.Add(LB_GorevSorulari);
LB_GorevSorulari.Items = new ListItemCollection();

LB_GorevSorulari.Items.Add(new ListItem {
Value = "soru1",
Key = "soru1",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Yapılan görev ile ilgili doküman hazırlanacak mı?" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

LB_GorevSorulari.Items.Add(new ListItem {
Value = "soru2",
Key = "soru2",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Eğitim süreci olacak mı?" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

LB_GorevSorulari.Items.Add(new ListItem {
Value = "soru3",
Key = "soru3",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Kod örneği hazırlanacak mı?" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

LB_GorevSorulari.Items.Add(new ListItem {
Value = "soru4",
Key = "soru4",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Müşteri ortamlarına bağlantı yapılması gerekiyor  mu?" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

LB_GorevSorulari.Items.Add(new ListItem {
Value = "soru5",
Key = "soru5",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Geliştirme esnasında müşteriyle paralel mi ilerlenecek?" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

LB_GorevSorulari.Items.Add(new ListItem {
Value = "soru6",
Key = "soru6",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Destek birimleri için talepler oluşturulması gerekli mi?" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

LB_GorevSorulari.Items.Add(new ListItem {
Value = "soru7",
Key = "soru7",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Bilgilendirme maillerinde müşteriler bulunacak mı?" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

BaseComponent default_lb_gorevsorulariComponent = new BaseComponent {
Id = "LB_GorevSorulari",
Type = "ListBox",
ParentId = "Column4",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = LB_GorevSorulari,
ViewProperties = "",
};

AddToViewItems("default", default_lb_gorevsorulariComponent);

BaseComponent default_column3Component = new BaseComponent {
Id = "Column3",
Type = "Column",
ParentId = "Section3",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"FormMetadata1",
"MDAdSoyad",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_column3Component);

FormMetadata1 = new FormMetadata {
ControlId = "4b52ec37-eb0a-8a26-8a72-d454ad17e598",
Name = "FormMetadata1",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "FormMetadata1" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "12",
Color = "",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "GorevAtamaSureci" },{ "en-US", "GorevAtamaSureci" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
MetadataType = FormMetadataType.FormCaption
};

Controls.Add(FormMetadata1);

BaseComponent default_formmetadata1Component = new BaseComponent {
Id = "FormMetadata1",
Type = "FormMetadata",
ParentId = "Column3",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = FormMetadata1,
ViewProperties = "",
};

AddToViewItems("default", default_formmetadata1Component);

BaseComponent default_column4Component = new BaseComponent {
Id = "Column4",
Type = "Column",
ParentId = "Section4",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"LB_GorevSorulari",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_column4Component);

Rate_TamamlamaYuzdesi = new Rate {
ControlId = "0aec52bf-28a5-62f8-47f1-76cb76d2bc33",
Name = "Rate_TamamlamaYuzdesi",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
new EventItem {
Name = "OnValueChanged",
MethodName = "Rate_TamamlamaYuzdesi_OnValueChanged",
Async = null
},
new EventItem {
Name = "OnValueChanging",
MethodName = "Rate_TamamlamaYuzdesi_OnValueChanging",
Async = null
},
},
Visible = true,
ClientVisible = false,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Görev Tamamlanma Yüzdesi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "Rate_TamamlamaYuzdesi",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
TabIndex = 0,
Value = 0M,
AllowClear = false,
AllowHalf = false,
Count = 20,
Tooltips = new List<MultiLanguageText> {
}
};

Controls.Add(Rate_TamamlamaYuzdesi);

BaseComponent default_rate_tamamlamayuzdesiComponent = new BaseComponent {
Id = "Rate_TamamlamaYuzdesi",
Type = "Rate",
ParentId = "Column10",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Rate_TamamlamaYuzdesi,
ViewProperties = "",
};

AddToViewItems("default", default_rate_tamamlamayuzdesiComponent);

BaseComponent default_column5Component = new BaseComponent {
Id = "Column5",
Type = "Column",
ParentId = "Section5",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"TBGorevAdi",
"TAGorevTanimi",
"RDGorevDosyalari",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_column5Component);

        }

        // initialize user events
        public override void InitUserEvents()
        {
            





















        }
    }
}