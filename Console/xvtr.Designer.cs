//=================================================================
// xvtr.cs
//=================================================================
// PowerSDR is a C# implementation of a Software Defined Radio.
// Copyright (C) 2003-2013  FlexRadio Systems
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
//
// You may contact us via email at: gpl@flexradio.com.
// Paper mail may be sent to: 
//    FlexRadio Systems
//    4616 W. Howard Lane  Suite 1-150
//    Austin, TX 78728
//    USA
//=================================================================


namespace PowerSDR
{
    public partial class XVTRForm : System.Windows.Forms.Form
    {
        

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XVTRForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkUHFPAEnable = new System.Windows.Forms.CheckBoxTS();
            this.chkVHFPAEnable = new System.Windows.Forms.CheckBoxTS();
            this.chkUHFIFGain = new System.Windows.Forms.CheckBoxTS();
            this.chkVHFIFGain = new System.Windows.Forms.CheckBoxTS();
            this.label_VUModuleNotPresent = new System.Windows.Forms.Label();
            this.label_VUModulePresent = new System.Windows.Forms.Label();
            this.udRXGain1 = new System.Windows.Forms.NumericUpDownTS();
            this.udRXGain0 = new System.Windows.Forms.NumericUpDownTS();
            this.chkXVTRRF1 = new System.Windows.Forms.CheckBoxTS();
            this.chkXVTRRF0 = new System.Windows.Forms.CheckBoxTS();
            this.udPower1 = new System.Windows.Forms.NumericUpDownTS();
            this.udPower0 = new System.Windows.Forms.NumericUpDownTS();
            this.chkRXOnly1 = new System.Windows.Forms.CheckBoxTS();
            this.chkRXOnly0 = new System.Windows.Forms.CheckBoxTS();
            this.udFreqEnd1 = new System.Windows.Forms.NumericUpDownTS();
            this.udFreqEnd0 = new System.Windows.Forms.NumericUpDownTS();
            this.udFreqBegin1 = new System.Windows.Forms.NumericUpDownTS();
            this.udFreqBegin0 = new System.Windows.Forms.NumericUpDownTS();
            this.udLOOffset1 = new System.Windows.Forms.NumericUpDownTS();
            this.udLOOffset0 = new System.Windows.Forms.NumericUpDownTS();
            this.txtButtonText1 = new System.Windows.Forms.TextBoxTS();
            this.txtButtonText0 = new System.Windows.Forms.TextBoxTS();
            this.txtBandButton1 = new System.Windows.Forms.TextBoxTS();
            this.txtBandButton0 = new System.Windows.Forms.TextBoxTS();
            this.chkEnable1 = new System.Windows.Forms.CheckBoxTS();
            this.chkEnable0 = new System.Windows.Forms.CheckBoxTS();
            this.udUCBAddr1 = new System.Windows.Forms.NumericUpDownTS();
            this.udUCBAddr0 = new System.Windows.Forms.NumericUpDownTS();
            this.udLOError0 = new System.Windows.Forms.NumericUpDownTS();
            this.udLOError1 = new System.Windows.Forms.NumericUpDownTS();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chkFlexWire = new System.Windows.Forms.CheckBoxTS();
            this.chkUseXVTRTUNPWR = new System.Windows.Forms.CheckBoxTS();
            this.lblXVTRRF = new System.Windows.Forms.LabelTS();
            this.lblUCBAddress = new System.Windows.Forms.LabelTS();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.chkAlwaysOnTop1 = new System.Windows.Forms.CheckBoxTS();
            this.lblPAEnable = new System.Windows.Forms.LabelTS();
            this.lblIFGain = new System.Windows.Forms.LabelTS();
            this.udRXGain15 = new System.Windows.Forms.NumericUpDownTS();
            this.udRXGain14 = new System.Windows.Forms.NumericUpDownTS();
            this.udRXGain13 = new System.Windows.Forms.NumericUpDownTS();
            this.udRXGain12 = new System.Windows.Forms.NumericUpDownTS();
            this.udRXGain11 = new System.Windows.Forms.NumericUpDownTS();
            this.udRXGain10 = new System.Windows.Forms.NumericUpDownTS();
            this.udRXGain9 = new System.Windows.Forms.NumericUpDownTS();
            this.udRXGain8 = new System.Windows.Forms.NumericUpDownTS();
            this.udRXGain7 = new System.Windows.Forms.NumericUpDownTS();
            this.udRXGain6 = new System.Windows.Forms.NumericUpDownTS();
            this.udRXGain5 = new System.Windows.Forms.NumericUpDownTS();
            this.udRXGain4 = new System.Windows.Forms.NumericUpDownTS();
            this.udRXGain3 = new System.Windows.Forms.NumericUpDownTS();
            this.udRXGain2 = new System.Windows.Forms.NumericUpDownTS();
            this.lblRXGain = new System.Windows.Forms.LabelTS();
            this.chkXVTRRF15 = new System.Windows.Forms.CheckBoxTS();
            this.chkXVTRRF14 = new System.Windows.Forms.CheckBoxTS();
            this.chkXVTRRF13 = new System.Windows.Forms.CheckBoxTS();
            this.chkXVTRRF12 = new System.Windows.Forms.CheckBoxTS();
            this.chkXVTRRF11 = new System.Windows.Forms.CheckBoxTS();
            this.chkXVTRRF10 = new System.Windows.Forms.CheckBoxTS();
            this.chkXVTRRF9 = new System.Windows.Forms.CheckBoxTS();
            this.chkXVTRRF8 = new System.Windows.Forms.CheckBoxTS();
            this.chkXVTRRF7 = new System.Windows.Forms.CheckBoxTS();
            this.chkXVTRRF6 = new System.Windows.Forms.CheckBoxTS();
            this.chkXVTRRF5 = new System.Windows.Forms.CheckBoxTS();
            this.chkXVTRRF4 = new System.Windows.Forms.CheckBoxTS();
            this.chkXVTRRF3 = new System.Windows.Forms.CheckBoxTS();
            this.chkXVTRRF2 = new System.Windows.Forms.CheckBoxTS();
            this.udPower15 = new System.Windows.Forms.NumericUpDownTS();
            this.udPower14 = new System.Windows.Forms.NumericUpDownTS();
            this.udPower13 = new System.Windows.Forms.NumericUpDownTS();
            this.udPower12 = new System.Windows.Forms.NumericUpDownTS();
            this.udPower11 = new System.Windows.Forms.NumericUpDownTS();
            this.udPower10 = new System.Windows.Forms.NumericUpDownTS();
            this.udPower9 = new System.Windows.Forms.NumericUpDownTS();
            this.udPower8 = new System.Windows.Forms.NumericUpDownTS();
            this.udPower7 = new System.Windows.Forms.NumericUpDownTS();
            this.udPower6 = new System.Windows.Forms.NumericUpDownTS();
            this.udPower5 = new System.Windows.Forms.NumericUpDownTS();
            this.udPower4 = new System.Windows.Forms.NumericUpDownTS();
            this.udPower3 = new System.Windows.Forms.NumericUpDownTS();
            this.udPower2 = new System.Windows.Forms.NumericUpDownTS();
            this.lblPower = new System.Windows.Forms.LabelTS();
            this.udLOError15 = new System.Windows.Forms.NumericUpDownTS();
            this.udLOError14 = new System.Windows.Forms.NumericUpDownTS();
            this.udLOError13 = new System.Windows.Forms.NumericUpDownTS();
            this.udLOError12 = new System.Windows.Forms.NumericUpDownTS();
            this.udLOError11 = new System.Windows.Forms.NumericUpDownTS();
            this.udLOError10 = new System.Windows.Forms.NumericUpDownTS();
            this.udLOError9 = new System.Windows.Forms.NumericUpDownTS();
            this.udLOError8 = new System.Windows.Forms.NumericUpDownTS();
            this.udLOError7 = new System.Windows.Forms.NumericUpDownTS();
            this.udLOError6 = new System.Windows.Forms.NumericUpDownTS();
            this.udLOError5 = new System.Windows.Forms.NumericUpDownTS();
            this.udLOError4 = new System.Windows.Forms.NumericUpDownTS();
            this.udLOError3 = new System.Windows.Forms.NumericUpDownTS();
            this.udLOError2 = new System.Windows.Forms.NumericUpDownTS();
            this.lblLOError = new System.Windows.Forms.LabelTS();
            this.chkRXOnly15 = new System.Windows.Forms.CheckBoxTS();
            this.chkRXOnly14 = new System.Windows.Forms.CheckBoxTS();
            this.chkRXOnly13 = new System.Windows.Forms.CheckBoxTS();
            this.chkRXOnly12 = new System.Windows.Forms.CheckBoxTS();
            this.chkRXOnly11 = new System.Windows.Forms.CheckBoxTS();
            this.chkRXOnly10 = new System.Windows.Forms.CheckBoxTS();
            this.chkRXOnly9 = new System.Windows.Forms.CheckBoxTS();
            this.chkRXOnly8 = new System.Windows.Forms.CheckBoxTS();
            this.chkRXOnly7 = new System.Windows.Forms.CheckBoxTS();
            this.chkRXOnly6 = new System.Windows.Forms.CheckBoxTS();
            this.chkRXOnly5 = new System.Windows.Forms.CheckBoxTS();
            this.chkRXOnly4 = new System.Windows.Forms.CheckBoxTS();
            this.chkRXOnly3 = new System.Windows.Forms.CheckBoxTS();
            this.chkRXOnly2 = new System.Windows.Forms.CheckBoxTS();
            this.lblRXOnly = new System.Windows.Forms.LabelTS();
            this.udFreqEnd15 = new System.Windows.Forms.NumericUpDownTS();
            this.udFreqEnd14 = new System.Windows.Forms.NumericUpDownTS();
            this.udFreqEnd13 = new System.Windows.Forms.NumericUpDownTS();
            this.udFreqEnd12 = new System.Windows.Forms.NumericUpDownTS();
            this.udFreqEnd11 = new System.Windows.Forms.NumericUpDownTS();
            this.udFreqEnd10 = new System.Windows.Forms.NumericUpDownTS();
            this.udFreqEnd9 = new System.Windows.Forms.NumericUpDownTS();
            this.udFreqEnd8 = new System.Windows.Forms.NumericUpDownTS();
            this.udFreqEnd7 = new System.Windows.Forms.NumericUpDownTS();
            this.udFreqEnd6 = new System.Windows.Forms.NumericUpDownTS();
            this.udFreqEnd5 = new System.Windows.Forms.NumericUpDownTS();
            this.udFreqEnd4 = new System.Windows.Forms.NumericUpDownTS();
            this.udFreqEnd3 = new System.Windows.Forms.NumericUpDownTS();
            this.udFreqEnd2 = new System.Windows.Forms.NumericUpDownTS();
            this.lblFreqEnd = new System.Windows.Forms.LabelTS();
            this.udFreqBegin15 = new System.Windows.Forms.NumericUpDownTS();
            this.udFreqBegin14 = new System.Windows.Forms.NumericUpDownTS();
            this.udFreqBegin13 = new System.Windows.Forms.NumericUpDownTS();
            this.udFreqBegin12 = new System.Windows.Forms.NumericUpDownTS();
            this.udFreqBegin11 = new System.Windows.Forms.NumericUpDownTS();
            this.udFreqBegin10 = new System.Windows.Forms.NumericUpDownTS();
            this.udFreqBegin9 = new System.Windows.Forms.NumericUpDownTS();
            this.udFreqBegin8 = new System.Windows.Forms.NumericUpDownTS();
            this.udFreqBegin7 = new System.Windows.Forms.NumericUpDownTS();
            this.udFreqBegin6 = new System.Windows.Forms.NumericUpDownTS();
            this.udFreqBegin5 = new System.Windows.Forms.NumericUpDownTS();
            this.udFreqBegin4 = new System.Windows.Forms.NumericUpDownTS();
            this.udFreqBegin3 = new System.Windows.Forms.NumericUpDownTS();
            this.udFreqBegin2 = new System.Windows.Forms.NumericUpDownTS();
            this.lblFreqBegin = new System.Windows.Forms.LabelTS();
            this.udLOOffset15 = new System.Windows.Forms.NumericUpDownTS();
            this.udLOOffset14 = new System.Windows.Forms.NumericUpDownTS();
            this.udLOOffset13 = new System.Windows.Forms.NumericUpDownTS();
            this.udLOOffset12 = new System.Windows.Forms.NumericUpDownTS();
            this.udLOOffset11 = new System.Windows.Forms.NumericUpDownTS();
            this.udLOOffset10 = new System.Windows.Forms.NumericUpDownTS();
            this.udLOOffset9 = new System.Windows.Forms.NumericUpDownTS();
            this.udLOOffset8 = new System.Windows.Forms.NumericUpDownTS();
            this.udLOOffset7 = new System.Windows.Forms.NumericUpDownTS();
            this.udLOOffset6 = new System.Windows.Forms.NumericUpDownTS();
            this.udLOOffset5 = new System.Windows.Forms.NumericUpDownTS();
            this.udLOOffset4 = new System.Windows.Forms.NumericUpDownTS();
            this.udLOOffset3 = new System.Windows.Forms.NumericUpDownTS();
            this.udLOOffset2 = new System.Windows.Forms.NumericUpDownTS();
            this.lblLOOffset = new System.Windows.Forms.LabelTS();
            this.txtButtonText15 = new System.Windows.Forms.TextBoxTS();
            this.txtButtonText14 = new System.Windows.Forms.TextBoxTS();
            this.txtButtonText13 = new System.Windows.Forms.TextBoxTS();
            this.txtButtonText12 = new System.Windows.Forms.TextBoxTS();
            this.txtButtonText11 = new System.Windows.Forms.TextBoxTS();
            this.txtButtonText10 = new System.Windows.Forms.TextBoxTS();
            this.txtButtonText9 = new System.Windows.Forms.TextBoxTS();
            this.txtButtonText8 = new System.Windows.Forms.TextBoxTS();
            this.txtButtonText7 = new System.Windows.Forms.TextBoxTS();
            this.txtButtonText6 = new System.Windows.Forms.TextBoxTS();
            this.txtButtonText5 = new System.Windows.Forms.TextBoxTS();
            this.txtButtonText4 = new System.Windows.Forms.TextBoxTS();
            this.txtButtonText3 = new System.Windows.Forms.TextBoxTS();
            this.txtButtonText2 = new System.Windows.Forms.TextBoxTS();
            this.txtBandButton15 = new System.Windows.Forms.TextBoxTS();
            this.txtBandButton14 = new System.Windows.Forms.TextBoxTS();
            this.txtBandButton13 = new System.Windows.Forms.TextBoxTS();
            this.txtBandButton12 = new System.Windows.Forms.TextBoxTS();
            this.txtBandButton11 = new System.Windows.Forms.TextBoxTS();
            this.txtBandButton10 = new System.Windows.Forms.TextBoxTS();
            this.txtBandButton9 = new System.Windows.Forms.TextBoxTS();
            this.txtBandButton8 = new System.Windows.Forms.TextBoxTS();
            this.txtBandButton7 = new System.Windows.Forms.TextBoxTS();
            this.txtBandButton6 = new System.Windows.Forms.TextBoxTS();
            this.txtBandButton5 = new System.Windows.Forms.TextBoxTS();
            this.txtBandButton4 = new System.Windows.Forms.TextBoxTS();
            this.txtBandButton3 = new System.Windows.Forms.TextBoxTS();
            this.txtBandButton2 = new System.Windows.Forms.TextBoxTS();
            this.lblEnabled = new System.Windows.Forms.LabelTS();
            this.chkEnable15 = new System.Windows.Forms.CheckBoxTS();
            this.chkEnable14 = new System.Windows.Forms.CheckBoxTS();
            this.chkEnable13 = new System.Windows.Forms.CheckBoxTS();
            this.chkEnable12 = new System.Windows.Forms.CheckBoxTS();
            this.chkEnable11 = new System.Windows.Forms.CheckBoxTS();
            this.chkEnable10 = new System.Windows.Forms.CheckBoxTS();
            this.chkEnable9 = new System.Windows.Forms.CheckBoxTS();
            this.chkEnable8 = new System.Windows.Forms.CheckBoxTS();
            this.chkEnable7 = new System.Windows.Forms.CheckBoxTS();
            this.chkEnable6 = new System.Windows.Forms.CheckBoxTS();
            this.chkEnable5 = new System.Windows.Forms.CheckBoxTS();
            this.chkEnable4 = new System.Windows.Forms.CheckBoxTS();
            this.chkEnable3 = new System.Windows.Forms.CheckBoxTS();
            this.chkEnable2 = new System.Windows.Forms.CheckBoxTS();
            this.udUCBAddr15 = new System.Windows.Forms.NumericUpDownTS();
            this.udUCBAddr14 = new System.Windows.Forms.NumericUpDownTS();
            this.udUCBAddr13 = new System.Windows.Forms.NumericUpDownTS();
            this.udUCBAddr12 = new System.Windows.Forms.NumericUpDownTS();
            this.udUCBAddr11 = new System.Windows.Forms.NumericUpDownTS();
            this.udUCBAddr10 = new System.Windows.Forms.NumericUpDownTS();
            this.udUCBAddr9 = new System.Windows.Forms.NumericUpDownTS();
            this.udUCBAddr8 = new System.Windows.Forms.NumericUpDownTS();
            this.udUCBAddr7 = new System.Windows.Forms.NumericUpDownTS();
            this.udUCBAddr6 = new System.Windows.Forms.NumericUpDownTS();
            this.udUCBAddr5 = new System.Windows.Forms.NumericUpDownTS();
            this.udUCBAddr4 = new System.Windows.Forms.NumericUpDownTS();
            this.udUCBAddr3 = new System.Windows.Forms.NumericUpDownTS();
            this.udUCBAddr2 = new System.Windows.Forms.NumericUpDownTS();
            this.lblButtonText = new System.Windows.Forms.LabelTS();
            this.lblBandButton = new System.Windows.Forms.LabelTS();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udRXGain1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRXGain0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPower1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPower0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqEnd1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqEnd0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqBegin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqBegin0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOOffset1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOOffset0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udUCBAddr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udUCBAddr0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOError0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOError1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRXGain15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRXGain14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRXGain13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRXGain12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRXGain11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRXGain10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRXGain9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRXGain8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRXGain7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRXGain6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRXGain5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRXGain4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRXGain3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRXGain2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPower15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPower14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPower13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPower12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPower11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPower10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPower9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPower8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPower7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPower6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPower5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPower4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPower3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPower2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOError15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOError14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOError13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOError12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOError11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOError10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOError9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOError8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOError7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOError6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOError5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOError4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOError3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOError2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqEnd15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqEnd14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqEnd13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqEnd12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqEnd11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqEnd10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqEnd9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqEnd8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqEnd7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqEnd6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqEnd5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqEnd4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqEnd3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqEnd2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqBegin15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqBegin14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqBegin13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqBegin12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqBegin11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqBegin10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqBegin9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqBegin8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqBegin7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqBegin6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqBegin5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqBegin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqBegin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqBegin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOOffset15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOOffset14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOOffset13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOOffset12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOOffset11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOOffset10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOOffset9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOOffset8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOOffset7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOOffset6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOOffset5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOOffset4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOOffset3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOOffset2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udUCBAddr15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udUCBAddr14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udUCBAddr13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udUCBAddr12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udUCBAddr11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udUCBAddr10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udUCBAddr9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udUCBAddr8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udUCBAddr7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udUCBAddr6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udUCBAddr5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udUCBAddr4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udUCBAddr3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udUCBAddr2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkUHFPAEnable);
            this.groupBox1.Controls.Add(this.chkVHFPAEnable);
            this.groupBox1.Controls.Add(this.chkUHFIFGain);
            this.groupBox1.Controls.Add(this.chkVHFIFGain);
            this.groupBox1.Controls.Add(this.label_VUModuleNotPresent);
            this.groupBox1.Controls.Add(this.label_VUModulePresent);
            this.groupBox1.Controls.Add(this.udRXGain1);
            this.groupBox1.Controls.Add(this.udRXGain0);
            this.groupBox1.Controls.Add(this.chkXVTRRF1);
            this.groupBox1.Controls.Add(this.chkXVTRRF0);
            this.groupBox1.Controls.Add(this.udPower1);
            this.groupBox1.Controls.Add(this.udPower0);
            this.groupBox1.Controls.Add(this.chkRXOnly1);
            this.groupBox1.Controls.Add(this.chkRXOnly0);
            this.groupBox1.Controls.Add(this.udFreqEnd1);
            this.groupBox1.Controls.Add(this.udFreqEnd0);
            this.groupBox1.Controls.Add(this.udFreqBegin1);
            this.groupBox1.Controls.Add(this.udFreqBegin0);
            this.groupBox1.Controls.Add(this.udLOOffset1);
            this.groupBox1.Controls.Add(this.udLOOffset0);
            this.groupBox1.Controls.Add(this.txtButtonText1);
            this.groupBox1.Controls.Add(this.txtButtonText0);
            this.groupBox1.Controls.Add(this.txtBandButton1);
            this.groupBox1.Controls.Add(this.txtBandButton0);
            this.groupBox1.Controls.Add(this.chkEnable1);
            this.groupBox1.Controls.Add(this.chkEnable0);
            this.groupBox1.Controls.Add(this.udUCBAddr1);
            this.groupBox1.Controls.Add(this.udUCBAddr0);
            this.groupBox1.Controls.Add(this.udLOError0);
            this.groupBox1.Controls.Add(this.udLOError1);
            this.groupBox1.Location = new System.Drawing.Point(26, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(974, 71);
            this.groupBox1.TabIndex = 205;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VHF/UHF";
            // 
            // chkUHFPAEnable
            // 
            this.chkUHFPAEnable.AutoSize = true;
            this.chkUHFPAEnable.Checked = true;
            this.chkUHFPAEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUHFPAEnable.Image = null;
            this.chkUHFPAEnable.Location = new System.Drawing.Point(936, 44);
            this.chkUHFPAEnable.Name = "chkUHFPAEnable";
            this.chkUHFPAEnable.Size = new System.Drawing.Size(15, 14);
            this.chkUHFPAEnable.TabIndex = 218;
            this.chkUHFPAEnable.UseVisualStyleBackColor = true;
            this.chkUHFPAEnable.CheckedChanged += new System.EventHandler(this.chkUHFPAEnable_CheckedChanged);
            // 
            // chkVHFPAEnable
            // 
            this.chkVHFPAEnable.AutoSize = true;
            this.chkVHFPAEnable.Checked = true;
            this.chkVHFPAEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVHFPAEnable.Image = null;
            this.chkVHFPAEnable.Location = new System.Drawing.Point(936, 18);
            this.chkVHFPAEnable.Name = "chkVHFPAEnable";
            this.chkVHFPAEnable.Size = new System.Drawing.Size(15, 14);
            this.chkVHFPAEnable.TabIndex = 217;
            this.chkVHFPAEnable.UseVisualStyleBackColor = true;
            this.chkVHFPAEnable.CheckedChanged += new System.EventHandler(this.chkVHFPAEnable_CheckedChanged);
            // 
            // chkUHFIFGain
            // 
            this.chkUHFIFGain.AutoSize = true;
            this.chkUHFIFGain.Checked = true;
            this.chkUHFIFGain.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUHFIFGain.Image = null;
            this.chkUHFIFGain.Location = new System.Drawing.Point(881, 44);
            this.chkUHFIFGain.Name = "chkUHFIFGain";
            this.chkUHFIFGain.Size = new System.Drawing.Size(15, 14);
            this.chkUHFIFGain.TabIndex = 216;
            this.chkUHFIFGain.UseVisualStyleBackColor = true;
            this.chkUHFIFGain.CheckedChanged += new System.EventHandler(this.chkUHFIFGain_CheckedChanged);
            // 
            // chkVHFIFGain
            // 
            this.chkVHFIFGain.AutoSize = true;
            this.chkVHFIFGain.Checked = true;
            this.chkVHFIFGain.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVHFIFGain.Image = null;
            this.chkVHFIFGain.Location = new System.Drawing.Point(881, 18);
            this.chkVHFIFGain.Name = "chkVHFIFGain";
            this.chkVHFIFGain.Size = new System.Drawing.Size(15, 14);
            this.chkVHFIFGain.TabIndex = 215;
            this.chkVHFIFGain.UseVisualStyleBackColor = true;
            this.chkVHFIFGain.CheckedChanged += new System.EventHandler(this.chkVHFIFGain_CheckedChanged);
            // 
            // label_VUModuleNotPresent
            // 
            this.label_VUModuleNotPresent.AutoSize = true;
            this.label_VUModuleNotPresent.ForeColor = System.Drawing.Color.Firebrick;
            this.label_VUModuleNotPresent.Location = new System.Drawing.Point(6, 0);
            this.label_VUModuleNotPresent.Name = "label_VUModuleNotPresent";
            this.label_VUModuleNotPresent.Size = new System.Drawing.Size(152, 13);
            this.label_VUModuleNotPresent.TabIndex = 214;
            this.label_VUModuleNotPresent.Text = "VHF/UHF Module Not Present";
            // 
            // label_VUModulePresent
            // 
            this.label_VUModulePresent.AutoSize = true;
            this.label_VUModulePresent.ForeColor = System.Drawing.Color.Green;
            this.label_VUModulePresent.Location = new System.Drawing.Point(6, 0);
            this.label_VUModulePresent.Name = "label_VUModulePresent";
            this.label_VUModulePresent.Size = new System.Drawing.Size(132, 13);
            this.label_VUModulePresent.TabIndex = 213;
            this.label_VUModulePresent.Text = "VHF/UHF Module Present";
            // 
            // udRXGain1
            // 
            this.udRXGain1.DecimalPlaces = 1;
            this.udRXGain1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udRXGain1.Location = new System.Drawing.Point(638, 45);
            this.udRXGain1.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udRXGain1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.udRXGain1.Name = "udRXGain1";
            this.udRXGain1.Size = new System.Drawing.Size(56, 20);
            this.udRXGain1.TabIndex = 20;
            this.udRXGain1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udRXGain1.ValueChanged += new System.EventHandler(this.udRXGain_ValueChanged);
            // 
            // udRXGain0
            // 
            this.udRXGain0.DecimalPlaces = 1;
            this.udRXGain0.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udRXGain0.Location = new System.Drawing.Point(638, 19);
            this.udRXGain0.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udRXGain0.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.udRXGain0.Name = "udRXGain0";
            this.udRXGain0.Size = new System.Drawing.Size(56, 20);
            this.udRXGain0.TabIndex = 8;
            this.udRXGain0.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udRXGain0.ValueChanged += new System.EventHandler(this.udRXGain_ValueChanged);
            // 
            // chkXVTRRF1
            // 
            this.chkXVTRRF1.Image = null;
            this.chkXVTRRF1.Location = new System.Drawing.Point(820, 46);
            this.chkXVTRRF1.Name = "chkXVTRRF1";
            this.chkXVTRRF1.Size = new System.Drawing.Size(16, 16);
            this.chkXVTRRF1.TabIndex = 23;
            this.chkXVTRRF1.Visible = false;
            this.chkXVTRRF1.CheckedChanged += new System.EventHandler(this.chkXVTRRF_CheckedChanged);
            // 
            // chkXVTRRF0
            // 
            this.chkXVTRRF0.Image = null;
            this.chkXVTRRF0.Location = new System.Drawing.Point(820, 19);
            this.chkXVTRRF0.Name = "chkXVTRRF0";
            this.chkXVTRRF0.Size = new System.Drawing.Size(16, 16);
            this.chkXVTRRF0.TabIndex = 11;
            this.chkXVTRRF0.Visible = false;
            this.chkXVTRRF0.CheckedChanged += new System.EventHandler(this.chkXVTRRF_CheckedChanged);
            // 
            // udPower1
            // 
            this.udPower1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udPower1.Location = new System.Drawing.Point(756, 44);
            this.udPower1.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udPower1.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udPower1.Name = "udPower1";
            this.udPower1.Size = new System.Drawing.Size(40, 20);
            this.udPower1.TabIndex = 22;
            this.udPower1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udPower1.ValueChanged += new System.EventHandler(this.udPower_ValueChanged);
            // 
            // udPower0
            // 
            this.udPower0.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udPower0.Location = new System.Drawing.Point(756, 18);
            this.udPower0.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udPower0.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udPower0.Name = "udPower0";
            this.udPower0.Size = new System.Drawing.Size(40, 20);
            this.udPower0.TabIndex = 10;
            this.udPower0.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udPower0.ValueChanged += new System.EventHandler(this.udPower_ValueChanged);
            // 
            // chkRXOnly1
            // 
            this.chkRXOnly1.Image = null;
            this.chkRXOnly1.Location = new System.Drawing.Point(716, 45);
            this.chkRXOnly1.Name = "chkRXOnly1";
            this.chkRXOnly1.Size = new System.Drawing.Size(16, 16);
            this.chkRXOnly1.TabIndex = 21;
            this.chkRXOnly1.CheckedChanged += new System.EventHandler(this.chkRXOnly1_CheckedChanged);
            // 
            // chkRXOnly0
            // 
            this.chkRXOnly0.Image = null;
            this.chkRXOnly0.Location = new System.Drawing.Point(716, 19);
            this.chkRXOnly0.Name = "chkRXOnly0";
            this.chkRXOnly0.Size = new System.Drawing.Size(16, 16);
            this.chkRXOnly0.TabIndex = 9;
            this.chkRXOnly0.CheckedChanged += new System.EventHandler(this.chkRXOnly0_CheckedChanged);
            // 
            // udFreqEnd1
            // 
            this.udFreqEnd1.DecimalPlaces = 6;
            this.udFreqEnd1.Enabled = false;
            this.udFreqEnd1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udFreqEnd1.Location = new System.Drawing.Point(534, 45);
            this.udFreqEnd1.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udFreqEnd1.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udFreqEnd1.Name = "udFreqEnd1";
            this.udFreqEnd1.Size = new System.Drawing.Size(96, 20);
            this.udFreqEnd1.TabIndex = 19;
            this.udFreqEnd1.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // udFreqEnd0
            // 
            this.udFreqEnd0.DecimalPlaces = 6;
            this.udFreqEnd0.Enabled = false;
            this.udFreqEnd0.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udFreqEnd0.Location = new System.Drawing.Point(534, 19);
            this.udFreqEnd0.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udFreqEnd0.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udFreqEnd0.Name = "udFreqEnd0";
            this.udFreqEnd0.Size = new System.Drawing.Size(96, 20);
            this.udFreqEnd0.TabIndex = 7;
            this.toolTip1.SetToolTip(this.udFreqEnd0, "2m upper edge 148 mhz\r\nbut will go up to 163mhz");
            this.udFreqEnd0.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // udFreqBegin1
            // 
            this.udFreqBegin1.DecimalPlaces = 6;
            this.udFreqBegin1.Enabled = false;
            this.udFreqBegin1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udFreqBegin1.Location = new System.Drawing.Point(430, 45);
            this.udFreqBegin1.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udFreqBegin1.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udFreqBegin1.Name = "udFreqBegin1";
            this.udFreqBegin1.Size = new System.Drawing.Size(96, 20);
            this.udFreqBegin1.TabIndex = 18;
            this.udFreqBegin1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // udFreqBegin0
            // 
            this.udFreqBegin0.DecimalPlaces = 6;
            this.udFreqBegin0.Enabled = false;
            this.udFreqBegin0.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udFreqBegin0.Location = new System.Drawing.Point(430, 19);
            this.udFreqBegin0.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udFreqBegin0.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udFreqBegin0.Name = "udFreqBegin0";
            this.udFreqBegin0.Size = new System.Drawing.Size(96, 20);
            this.udFreqBegin0.TabIndex = 6;
            this.toolTip1.SetToolTip(this.udFreqBegin0, "2m bottom edge = 144mhz");
            this.udFreqBegin0.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // udLOOffset1
            // 
            this.udLOOffset1.DecimalPlaces = 1;
            this.udLOOffset1.Enabled = false;
            this.udLOOffset1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLOOffset1.Location = new System.Drawing.Point(278, 45);
            this.udLOOffset1.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udLOOffset1.Minimum = new decimal(new int[] {
            144,
            0,
            0,
            -2147483648});
            this.udLOOffset1.Name = "udLOOffset1";
            this.udLOOffset1.Size = new System.Drawing.Size(80, 20);
            this.udLOOffset1.TabIndex = 16;
            this.udLOOffset1.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // udLOOffset0
            // 
            this.udLOOffset0.DecimalPlaces = 1;
            this.udLOOffset0.Enabled = false;
            this.udLOOffset0.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLOOffset0.Location = new System.Drawing.Point(278, 19);
            this.udLOOffset0.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udLOOffset0.Minimum = new decimal(new int[] {
            134,
            0,
            0,
            -2147483648});
            this.udLOOffset0.Name = "udLOOffset0";
            this.udLOOffset0.Size = new System.Drawing.Size(80, 20);
            this.udLOOffset0.TabIndex = 4;
            this.toolTip1.SetToolTip(this.udLOOffset0, "125mhz");
            this.udLOOffset0.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLOOffset0.ValueChanged += new System.EventHandler(this.udLOOffset0_ValueChanged);
            // 
            // txtButtonText1
            // 
            this.txtButtonText1.Location = new System.Drawing.Point(198, 45);
            this.txtButtonText1.MaxLength = 5;
            this.txtButtonText1.Name = "txtButtonText1";
            this.txtButtonText1.Size = new System.Drawing.Size(64, 20);
            this.txtButtonText1.TabIndex = 15;
            this.txtButtonText1.Text = "70cm";
            this.txtButtonText1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtButtonText1.TextChanged += new System.EventHandler(this.txtButtonText_TextChanged);
            this.txtButtonText1.MouseHover += new System.EventHandler(this.txtButtonText1_MouseHover);
            // 
            // txtButtonText0
            // 
            this.txtButtonText0.Location = new System.Drawing.Point(198, 19);
            this.txtButtonText0.MaxLength = 5;
            this.txtButtonText0.Name = "txtButtonText0";
            this.txtButtonText0.Size = new System.Drawing.Size(64, 20);
            this.txtButtonText0.TabIndex = 3;
            this.txtButtonText0.Text = "2m";
            this.txtButtonText0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtButtonText0.TextChanged += new System.EventHandler(this.txtButtonText_TextChanged);
            this.txtButtonText0.MouseHover += new System.EventHandler(this.txtButtonText0_MouseHover);
            // 
            // txtBandButton1
            // 
            this.txtBandButton1.Enabled = false;
            this.txtBandButton1.Location = new System.Drawing.Point(46, 45);
            this.txtBandButton1.Name = "txtBandButton1";
            this.txtBandButton1.ReadOnly = true;
            this.txtBandButton1.Size = new System.Drawing.Size(64, 20);
            this.txtBandButton1.TabIndex = 13;
            this.txtBandButton1.Text = "1";
            this.txtBandButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBandButton0
            // 
            this.txtBandButton0.Enabled = false;
            this.txtBandButton0.Location = new System.Drawing.Point(46, 19);
            this.txtBandButton0.Name = "txtBandButton0";
            this.txtBandButton0.ReadOnly = true;
            this.txtBandButton0.Size = new System.Drawing.Size(64, 20);
            this.txtBandButton0.TabIndex = 1;
            this.txtBandButton0.Text = "0";
            this.txtBandButton0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkEnable1
            // 
            this.chkEnable1.Enabled = false;
            this.chkEnable1.Image = null;
            this.chkEnable1.Location = new System.Drawing.Point(6, 47);
            this.chkEnable1.Name = "chkEnable1";
            this.chkEnable1.Size = new System.Drawing.Size(16, 16);
            this.chkEnable1.TabIndex = 12;
            this.chkEnable1.CheckedChanged += new System.EventHandler(this.chkEnable1_CheckedChanged);
            // 
            // chkEnable0
            // 
            this.chkEnable0.Enabled = false;
            this.chkEnable0.Image = null;
            this.chkEnable0.Location = new System.Drawing.Point(6, 21);
            this.chkEnable0.Name = "chkEnable0";
            this.chkEnable0.Size = new System.Drawing.Size(16, 16);
            this.chkEnable0.TabIndex = 0;
            this.chkEnable0.CheckedChanged += new System.EventHandler(this.chkEnable0_CheckedChanged);
            // 
            // udUCBAddr1
            // 
            this.udUCBAddr1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udUCBAddr1.Location = new System.Drawing.Point(134, 45);
            this.udUCBAddr1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.udUCBAddr1.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udUCBAddr1.Name = "udUCBAddr1";
            this.udUCBAddr1.Size = new System.Drawing.Size(40, 20);
            this.udUCBAddr1.TabIndex = 14;
            this.udUCBAddr1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // udUCBAddr0
            // 
            this.udUCBAddr0.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udUCBAddr0.Location = new System.Drawing.Point(134, 19);
            this.udUCBAddr0.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.udUCBAddr0.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udUCBAddr0.Name = "udUCBAddr0";
            this.udUCBAddr0.Size = new System.Drawing.Size(40, 20);
            this.udUCBAddr0.TabIndex = 2;
            this.udUCBAddr0.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udLOError0
            // 
            this.udLOError0.DecimalPlaces = 3;
            this.udLOError0.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLOError0.Location = new System.Drawing.Point(366, 19);
            this.udLOError0.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udLOError0.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.udLOError0.Name = "udLOError0";
            this.udLOError0.Size = new System.Drawing.Size(56, 20);
            this.udLOError0.TabIndex = 5;
            this.udLOError0.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udLOError1
            // 
            this.udLOError1.DecimalPlaces = 3;
            this.udLOError1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLOError1.Location = new System.Drawing.Point(366, 45);
            this.udLOError1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udLOError1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.udLOError1.Name = "udLOError1";
            this.udLOError1.Size = new System.Drawing.Size(56, 20);
            this.udLOError1.TabIndex = 17;
            this.udLOError1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // chkFlexWire
            // 
            this.chkFlexWire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkFlexWire.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkFlexWire.Image = null;
            this.chkFlexWire.Location = new System.Drawing.Point(907, 428);
            this.chkFlexWire.Name = "chkFlexWire";
            this.chkFlexWire.Size = new System.Drawing.Size(88, 24);
            this.chkFlexWire.TabIndex = 331;
            this.chkFlexWire.Text = "FlexWire";
            this.chkFlexWire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.chkFlexWire, resources.GetString("chkFlexWire.ToolTip"));
            this.chkFlexWire.CheckedChanged += new System.EventHandler(this.chkFlexWire_CheckedChanged);
            // 
            // chkUseXVTRTUNPWR
            // 
            this.chkUseXVTRTUNPWR.Image = null;
            this.chkUseXVTRTUNPWR.Location = new System.Drawing.Point(80, 460);
            this.chkUseXVTRTUNPWR.Name = "chkUseXVTRTUNPWR";
            this.chkUseXVTRTUNPWR.Size = new System.Drawing.Size(152, 24);
            this.chkUseXVTRTUNPWR.TabIndex = 204;
            this.chkUseXVTRTUNPWR.Text = "Use XVTR PWR for Tune";
            this.chkUseXVTRTUNPWR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.chkUseXVTRTUNPWR, resources.GetString("chkUseXVTRTUNPWR.ToolTip"));
            this.chkUseXVTRTUNPWR.CheckedChanged += new System.EventHandler(this.chkUseXVTRTUNPWR_CheckedChanged);
            // 
            // lblXVTRRF
            // 
            this.lblXVTRRF.Enabled = false;
            this.lblXVTRRF.Image = null;
            this.lblXVTRRF.Location = new System.Drawing.Point(838, 16);
            this.lblXVTRRF.Name = "lblXVTRRF";
            this.lblXVTRRF.Size = new System.Drawing.Size(40, 32);
            this.lblXVTRRF.TabIndex = 170;
            this.lblXVTRRF.Text = "XVTR RF TX";
            this.toolTip1.SetToolTip(this.lblXVTRRF, resources.GetString("lblXVTRRF.ToolTip"));
            // 
            // lblUCBAddress
            // 
            this.lblUCBAddress.Image = null;
            this.lblUCBAddress.Location = new System.Drawing.Point(144, 24);
            this.lblUCBAddress.Name = "lblUCBAddress";
            this.lblUCBAddress.Size = new System.Drawing.Size(80, 16);
            this.lblUCBAddress.TabIndex = 1;
            this.lblUCBAddress.Text = "UCB Address";
            this.toolTip1.SetToolTip(this.lblUCBAddress, "Universal Control Board I2C 8bit address 0x4C");
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(868, 122);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(235, 278);
            this.richTextBox1.TabIndex = 332;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // chkAlwaysOnTop1
            // 
            this.chkAlwaysOnTop1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAlwaysOnTop1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkAlwaysOnTop1.Image = null;
            this.chkAlwaysOnTop1.Location = new System.Drawing.Point(897, 460);
            this.chkAlwaysOnTop1.Name = "chkAlwaysOnTop1";
            this.chkAlwaysOnTop1.Size = new System.Drawing.Size(103, 24);
            this.chkAlwaysOnTop1.TabIndex = 208;
            this.chkAlwaysOnTop1.Text = "Always On Top";
            this.chkAlwaysOnTop1.CheckedChanged += new System.EventHandler(this.ChkAlwaysOnTop1_CheckedChanged);
            // 
            // lblPAEnable
            // 
            this.lblPAEnable.Image = null;
            this.lblPAEnable.Location = new System.Drawing.Point(942, 24);
            this.lblPAEnable.Name = "lblPAEnable";
            this.lblPAEnable.Size = new System.Drawing.Size(58, 16);
            this.lblPAEnable.TabIndex = 207;
            this.lblPAEnable.Text = "PA Enable";
            // 
            // lblIFGain
            // 
            this.lblIFGain.Image = null;
            this.lblIFGain.Location = new System.Drawing.Point(894, 24);
            this.lblIFGain.Name = "lblIFGain";
            this.lblIFGain.Size = new System.Drawing.Size(42, 16);
            this.lblIFGain.TabIndex = 206;
            this.lblIFGain.Text = "IF Gain";
            // 
            // udRXGain15
            // 
            this.udRXGain15.DecimalPlaces = 1;
            this.udRXGain15.Enabled = false;
            this.udRXGain15.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udRXGain15.Location = new System.Drawing.Point(664, 436);
            this.udRXGain15.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udRXGain15.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.udRXGain15.Name = "udRXGain15";
            this.udRXGain15.Size = new System.Drawing.Size(56, 20);
            this.udRXGain15.TabIndex = 188;
            this.udRXGain15.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udRXGain15.ValueChanged += new System.EventHandler(this.udRXGain_ValueChanged);
            // 
            // udRXGain14
            // 
            this.udRXGain14.DecimalPlaces = 1;
            this.udRXGain14.Enabled = false;
            this.udRXGain14.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udRXGain14.Location = new System.Drawing.Point(664, 412);
            this.udRXGain14.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udRXGain14.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.udRXGain14.Name = "udRXGain14";
            this.udRXGain14.Size = new System.Drawing.Size(56, 20);
            this.udRXGain14.TabIndex = 176;
            this.udRXGain14.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udRXGain14.ValueChanged += new System.EventHandler(this.udRXGain_ValueChanged);
            // 
            // udRXGain13
            // 
            this.udRXGain13.DecimalPlaces = 1;
            this.udRXGain13.Enabled = false;
            this.udRXGain13.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udRXGain13.Location = new System.Drawing.Point(664, 388);
            this.udRXGain13.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udRXGain13.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.udRXGain13.Name = "udRXGain13";
            this.udRXGain13.Size = new System.Drawing.Size(56, 20);
            this.udRXGain13.TabIndex = 164;
            this.udRXGain13.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udRXGain13.ValueChanged += new System.EventHandler(this.udRXGain_ValueChanged);
            // 
            // udRXGain12
            // 
            this.udRXGain12.DecimalPlaces = 1;
            this.udRXGain12.Enabled = false;
            this.udRXGain12.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udRXGain12.Location = new System.Drawing.Point(664, 364);
            this.udRXGain12.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udRXGain12.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.udRXGain12.Name = "udRXGain12";
            this.udRXGain12.Size = new System.Drawing.Size(56, 20);
            this.udRXGain12.TabIndex = 152;
            this.udRXGain12.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udRXGain12.ValueChanged += new System.EventHandler(this.udRXGain_ValueChanged);
            // 
            // udRXGain11
            // 
            this.udRXGain11.DecimalPlaces = 1;
            this.udRXGain11.Enabled = false;
            this.udRXGain11.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udRXGain11.Location = new System.Drawing.Point(664, 340);
            this.udRXGain11.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udRXGain11.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.udRXGain11.Name = "udRXGain11";
            this.udRXGain11.Size = new System.Drawing.Size(56, 20);
            this.udRXGain11.TabIndex = 140;
            this.udRXGain11.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udRXGain11.ValueChanged += new System.EventHandler(this.udRXGain_ValueChanged);
            // 
            // udRXGain10
            // 
            this.udRXGain10.DecimalPlaces = 1;
            this.udRXGain10.Enabled = false;
            this.udRXGain10.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udRXGain10.Location = new System.Drawing.Point(664, 316);
            this.udRXGain10.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udRXGain10.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.udRXGain10.Name = "udRXGain10";
            this.udRXGain10.Size = new System.Drawing.Size(56, 20);
            this.udRXGain10.TabIndex = 128;
            this.udRXGain10.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udRXGain10.ValueChanged += new System.EventHandler(this.udRXGain_ValueChanged);
            // 
            // udRXGain9
            // 
            this.udRXGain9.DecimalPlaces = 1;
            this.udRXGain9.Enabled = false;
            this.udRXGain9.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udRXGain9.Location = new System.Drawing.Point(664, 292);
            this.udRXGain9.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udRXGain9.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.udRXGain9.Name = "udRXGain9";
            this.udRXGain9.Size = new System.Drawing.Size(56, 20);
            this.udRXGain9.TabIndex = 116;
            this.udRXGain9.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udRXGain9.ValueChanged += new System.EventHandler(this.udRXGain_ValueChanged);
            // 
            // udRXGain8
            // 
            this.udRXGain8.DecimalPlaces = 1;
            this.udRXGain8.Enabled = false;
            this.udRXGain8.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udRXGain8.Location = new System.Drawing.Point(664, 268);
            this.udRXGain8.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udRXGain8.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.udRXGain8.Name = "udRXGain8";
            this.udRXGain8.Size = new System.Drawing.Size(56, 20);
            this.udRXGain8.TabIndex = 104;
            this.udRXGain8.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udRXGain8.ValueChanged += new System.EventHandler(this.udRXGain_ValueChanged);
            // 
            // udRXGain7
            // 
            this.udRXGain7.DecimalPlaces = 1;
            this.udRXGain7.Enabled = false;
            this.udRXGain7.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udRXGain7.Location = new System.Drawing.Point(664, 244);
            this.udRXGain7.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udRXGain7.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.udRXGain7.Name = "udRXGain7";
            this.udRXGain7.Size = new System.Drawing.Size(56, 20);
            this.udRXGain7.TabIndex = 92;
            this.udRXGain7.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udRXGain7.ValueChanged += new System.EventHandler(this.udRXGain_ValueChanged);
            // 
            // udRXGain6
            // 
            this.udRXGain6.DecimalPlaces = 1;
            this.udRXGain6.Enabled = false;
            this.udRXGain6.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udRXGain6.Location = new System.Drawing.Point(664, 220);
            this.udRXGain6.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udRXGain6.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.udRXGain6.Name = "udRXGain6";
            this.udRXGain6.Size = new System.Drawing.Size(56, 20);
            this.udRXGain6.TabIndex = 80;
            this.udRXGain6.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udRXGain6.ValueChanged += new System.EventHandler(this.udRXGain_ValueChanged);
            // 
            // udRXGain5
            // 
            this.udRXGain5.DecimalPlaces = 1;
            this.udRXGain5.Enabled = false;
            this.udRXGain5.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udRXGain5.Location = new System.Drawing.Point(664, 196);
            this.udRXGain5.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udRXGain5.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.udRXGain5.Name = "udRXGain5";
            this.udRXGain5.Size = new System.Drawing.Size(56, 20);
            this.udRXGain5.TabIndex = 68;
            this.udRXGain5.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udRXGain5.ValueChanged += new System.EventHandler(this.udRXGain_ValueChanged);
            // 
            // udRXGain4
            // 
            this.udRXGain4.DecimalPlaces = 1;
            this.udRXGain4.Enabled = false;
            this.udRXGain4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udRXGain4.Location = new System.Drawing.Point(664, 172);
            this.udRXGain4.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udRXGain4.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.udRXGain4.Name = "udRXGain4";
            this.udRXGain4.Size = new System.Drawing.Size(56, 20);
            this.udRXGain4.TabIndex = 56;
            this.udRXGain4.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udRXGain4.ValueChanged += new System.EventHandler(this.udRXGain_ValueChanged);
            // 
            // udRXGain3
            // 
            this.udRXGain3.DecimalPlaces = 1;
            this.udRXGain3.Enabled = false;
            this.udRXGain3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udRXGain3.Location = new System.Drawing.Point(664, 148);
            this.udRXGain3.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udRXGain3.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.udRXGain3.Name = "udRXGain3";
            this.udRXGain3.Size = new System.Drawing.Size(56, 20);
            this.udRXGain3.TabIndex = 44;
            this.udRXGain3.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udRXGain3.ValueChanged += new System.EventHandler(this.udRXGain_ValueChanged);
            // 
            // udRXGain2
            // 
            this.udRXGain2.DecimalPlaces = 1;
            this.udRXGain2.Enabled = false;
            this.udRXGain2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udRXGain2.Location = new System.Drawing.Point(664, 124);
            this.udRXGain2.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udRXGain2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.udRXGain2.Name = "udRXGain2";
            this.udRXGain2.Size = new System.Drawing.Size(56, 20);
            this.udRXGain2.TabIndex = 32;
            this.udRXGain2.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udRXGain2.ValueChanged += new System.EventHandler(this.udRXGain_ValueChanged);
            // 
            // lblRXGain
            // 
            this.lblRXGain.Enabled = false;
            this.lblRXGain.Image = null;
            this.lblRXGain.Location = new System.Drawing.Point(664, 16);
            this.lblRXGain.Name = "lblRXGain";
            this.lblRXGain.Size = new System.Drawing.Size(56, 32);
            this.lblRXGain.TabIndex = 187;
            this.lblRXGain.Text = "RX Gain (dB)";
            // 
            // chkXVTRRF15
            // 
            this.chkXVTRRF15.Enabled = false;
            this.chkXVTRRF15.Image = null;
            this.chkXVTRRF15.Location = new System.Drawing.Point(846, 436);
            this.chkXVTRRF15.Name = "chkXVTRRF15";
            this.chkXVTRRF15.Size = new System.Drawing.Size(16, 16);
            this.chkXVTRRF15.TabIndex = 191;
            this.chkXVTRRF15.CheckedChanged += new System.EventHandler(this.chkXVTRRF_CheckedChanged);
            // 
            // chkXVTRRF14
            // 
            this.chkXVTRRF14.Enabled = false;
            this.chkXVTRRF14.Image = null;
            this.chkXVTRRF14.Location = new System.Drawing.Point(846, 412);
            this.chkXVTRRF14.Name = "chkXVTRRF14";
            this.chkXVTRRF14.Size = new System.Drawing.Size(16, 16);
            this.chkXVTRRF14.TabIndex = 179;
            this.chkXVTRRF14.CheckedChanged += new System.EventHandler(this.chkXVTRRF_CheckedChanged);
            // 
            // chkXVTRRF13
            // 
            this.chkXVTRRF13.Enabled = false;
            this.chkXVTRRF13.Image = null;
            this.chkXVTRRF13.Location = new System.Drawing.Point(846, 388);
            this.chkXVTRRF13.Name = "chkXVTRRF13";
            this.chkXVTRRF13.Size = new System.Drawing.Size(16, 16);
            this.chkXVTRRF13.TabIndex = 167;
            this.chkXVTRRF13.CheckedChanged += new System.EventHandler(this.chkXVTRRF_CheckedChanged);
            // 
            // chkXVTRRF12
            // 
            this.chkXVTRRF12.Enabled = false;
            this.chkXVTRRF12.Image = null;
            this.chkXVTRRF12.Location = new System.Drawing.Point(846, 364);
            this.chkXVTRRF12.Name = "chkXVTRRF12";
            this.chkXVTRRF12.Size = new System.Drawing.Size(16, 16);
            this.chkXVTRRF12.TabIndex = 155;
            this.chkXVTRRF12.CheckedChanged += new System.EventHandler(this.chkXVTRRF_CheckedChanged);
            // 
            // chkXVTRRF11
            // 
            this.chkXVTRRF11.Enabled = false;
            this.chkXVTRRF11.Image = null;
            this.chkXVTRRF11.Location = new System.Drawing.Point(846, 340);
            this.chkXVTRRF11.Name = "chkXVTRRF11";
            this.chkXVTRRF11.Size = new System.Drawing.Size(16, 16);
            this.chkXVTRRF11.TabIndex = 143;
            this.chkXVTRRF11.CheckedChanged += new System.EventHandler(this.chkXVTRRF_CheckedChanged);
            // 
            // chkXVTRRF10
            // 
            this.chkXVTRRF10.Enabled = false;
            this.chkXVTRRF10.Image = null;
            this.chkXVTRRF10.Location = new System.Drawing.Point(846, 316);
            this.chkXVTRRF10.Name = "chkXVTRRF10";
            this.chkXVTRRF10.Size = new System.Drawing.Size(16, 16);
            this.chkXVTRRF10.TabIndex = 131;
            this.chkXVTRRF10.CheckedChanged += new System.EventHandler(this.chkXVTRRF_CheckedChanged);
            // 
            // chkXVTRRF9
            // 
            this.chkXVTRRF9.Enabled = false;
            this.chkXVTRRF9.Image = null;
            this.chkXVTRRF9.Location = new System.Drawing.Point(846, 292);
            this.chkXVTRRF9.Name = "chkXVTRRF9";
            this.chkXVTRRF9.Size = new System.Drawing.Size(16, 16);
            this.chkXVTRRF9.TabIndex = 119;
            this.chkXVTRRF9.CheckedChanged += new System.EventHandler(this.chkXVTRRF_CheckedChanged);
            // 
            // chkXVTRRF8
            // 
            this.chkXVTRRF8.Enabled = false;
            this.chkXVTRRF8.Image = null;
            this.chkXVTRRF8.Location = new System.Drawing.Point(846, 268);
            this.chkXVTRRF8.Name = "chkXVTRRF8";
            this.chkXVTRRF8.Size = new System.Drawing.Size(16, 16);
            this.chkXVTRRF8.TabIndex = 107;
            this.chkXVTRRF8.CheckedChanged += new System.EventHandler(this.chkXVTRRF_CheckedChanged);
            // 
            // chkXVTRRF7
            // 
            this.chkXVTRRF7.Enabled = false;
            this.chkXVTRRF7.Image = null;
            this.chkXVTRRF7.Location = new System.Drawing.Point(846, 244);
            this.chkXVTRRF7.Name = "chkXVTRRF7";
            this.chkXVTRRF7.Size = new System.Drawing.Size(16, 16);
            this.chkXVTRRF7.TabIndex = 95;
            this.chkXVTRRF7.CheckedChanged += new System.EventHandler(this.chkXVTRRF_CheckedChanged);
            // 
            // chkXVTRRF6
            // 
            this.chkXVTRRF6.Enabled = false;
            this.chkXVTRRF6.Image = null;
            this.chkXVTRRF6.Location = new System.Drawing.Point(846, 220);
            this.chkXVTRRF6.Name = "chkXVTRRF6";
            this.chkXVTRRF6.Size = new System.Drawing.Size(16, 16);
            this.chkXVTRRF6.TabIndex = 83;
            this.chkXVTRRF6.CheckedChanged += new System.EventHandler(this.chkXVTRRF_CheckedChanged);
            // 
            // chkXVTRRF5
            // 
            this.chkXVTRRF5.Enabled = false;
            this.chkXVTRRF5.Image = null;
            this.chkXVTRRF5.Location = new System.Drawing.Point(846, 196);
            this.chkXVTRRF5.Name = "chkXVTRRF5";
            this.chkXVTRRF5.Size = new System.Drawing.Size(16, 16);
            this.chkXVTRRF5.TabIndex = 71;
            this.chkXVTRRF5.CheckedChanged += new System.EventHandler(this.chkXVTRRF_CheckedChanged);
            // 
            // chkXVTRRF4
            // 
            this.chkXVTRRF4.Enabled = false;
            this.chkXVTRRF4.Image = null;
            this.chkXVTRRF4.Location = new System.Drawing.Point(846, 172);
            this.chkXVTRRF4.Name = "chkXVTRRF4";
            this.chkXVTRRF4.Size = new System.Drawing.Size(16, 16);
            this.chkXVTRRF4.TabIndex = 59;
            this.chkXVTRRF4.CheckedChanged += new System.EventHandler(this.chkXVTRRF_CheckedChanged);
            // 
            // chkXVTRRF3
            // 
            this.chkXVTRRF3.Enabled = false;
            this.chkXVTRRF3.Image = null;
            this.chkXVTRRF3.Location = new System.Drawing.Point(846, 148);
            this.chkXVTRRF3.Name = "chkXVTRRF3";
            this.chkXVTRRF3.Size = new System.Drawing.Size(16, 16);
            this.chkXVTRRF3.TabIndex = 47;
            this.chkXVTRRF3.CheckedChanged += new System.EventHandler(this.chkXVTRRF_CheckedChanged);
            // 
            // chkXVTRRF2
            // 
            this.chkXVTRRF2.Enabled = false;
            this.chkXVTRRF2.Image = null;
            this.chkXVTRRF2.Location = new System.Drawing.Point(846, 124);
            this.chkXVTRRF2.Name = "chkXVTRRF2";
            this.chkXVTRRF2.Size = new System.Drawing.Size(16, 16);
            this.chkXVTRRF2.TabIndex = 35;
            this.chkXVTRRF2.CheckedChanged += new System.EventHandler(this.chkXVTRRF_CheckedChanged);
            // 
            // udPower15
            // 
            this.udPower15.Enabled = false;
            this.udPower15.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udPower15.Location = new System.Drawing.Point(782, 436);
            this.udPower15.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udPower15.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udPower15.Name = "udPower15";
            this.udPower15.Size = new System.Drawing.Size(40, 20);
            this.udPower15.TabIndex = 190;
            this.udPower15.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udPower15.ValueChanged += new System.EventHandler(this.udPower_ValueChanged);
            // 
            // udPower14
            // 
            this.udPower14.Enabled = false;
            this.udPower14.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udPower14.Location = new System.Drawing.Point(782, 412);
            this.udPower14.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udPower14.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udPower14.Name = "udPower14";
            this.udPower14.Size = new System.Drawing.Size(40, 20);
            this.udPower14.TabIndex = 178;
            this.udPower14.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udPower14.ValueChanged += new System.EventHandler(this.udPower_ValueChanged);
            // 
            // udPower13
            // 
            this.udPower13.Enabled = false;
            this.udPower13.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udPower13.Location = new System.Drawing.Point(782, 388);
            this.udPower13.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udPower13.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udPower13.Name = "udPower13";
            this.udPower13.Size = new System.Drawing.Size(40, 20);
            this.udPower13.TabIndex = 166;
            this.udPower13.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udPower13.ValueChanged += new System.EventHandler(this.udPower_ValueChanged);
            // 
            // udPower12
            // 
            this.udPower12.Enabled = false;
            this.udPower12.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udPower12.Location = new System.Drawing.Point(782, 364);
            this.udPower12.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udPower12.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udPower12.Name = "udPower12";
            this.udPower12.Size = new System.Drawing.Size(40, 20);
            this.udPower12.TabIndex = 154;
            this.udPower12.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udPower12.ValueChanged += new System.EventHandler(this.udPower_ValueChanged);
            // 
            // udPower11
            // 
            this.udPower11.Enabled = false;
            this.udPower11.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udPower11.Location = new System.Drawing.Point(782, 340);
            this.udPower11.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udPower11.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udPower11.Name = "udPower11";
            this.udPower11.Size = new System.Drawing.Size(40, 20);
            this.udPower11.TabIndex = 142;
            this.udPower11.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udPower11.ValueChanged += new System.EventHandler(this.udPower_ValueChanged);
            // 
            // udPower10
            // 
            this.udPower10.Enabled = false;
            this.udPower10.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udPower10.Location = new System.Drawing.Point(782, 316);
            this.udPower10.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udPower10.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udPower10.Name = "udPower10";
            this.udPower10.Size = new System.Drawing.Size(40, 20);
            this.udPower10.TabIndex = 130;
            this.udPower10.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udPower10.ValueChanged += new System.EventHandler(this.udPower_ValueChanged);
            // 
            // udPower9
            // 
            this.udPower9.Enabled = false;
            this.udPower9.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udPower9.Location = new System.Drawing.Point(782, 292);
            this.udPower9.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udPower9.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udPower9.Name = "udPower9";
            this.udPower9.Size = new System.Drawing.Size(40, 20);
            this.udPower9.TabIndex = 118;
            this.udPower9.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udPower9.ValueChanged += new System.EventHandler(this.udPower_ValueChanged);
            // 
            // udPower8
            // 
            this.udPower8.Enabled = false;
            this.udPower8.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udPower8.Location = new System.Drawing.Point(782, 268);
            this.udPower8.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udPower8.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udPower8.Name = "udPower8";
            this.udPower8.Size = new System.Drawing.Size(40, 20);
            this.udPower8.TabIndex = 106;
            this.udPower8.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udPower8.ValueChanged += new System.EventHandler(this.udPower_ValueChanged);
            // 
            // udPower7
            // 
            this.udPower7.Enabled = false;
            this.udPower7.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udPower7.Location = new System.Drawing.Point(782, 244);
            this.udPower7.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udPower7.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udPower7.Name = "udPower7";
            this.udPower7.Size = new System.Drawing.Size(40, 20);
            this.udPower7.TabIndex = 94;
            this.udPower7.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udPower7.ValueChanged += new System.EventHandler(this.udPower_ValueChanged);
            // 
            // udPower6
            // 
            this.udPower6.Enabled = false;
            this.udPower6.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udPower6.Location = new System.Drawing.Point(782, 220);
            this.udPower6.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udPower6.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udPower6.Name = "udPower6";
            this.udPower6.Size = new System.Drawing.Size(40, 20);
            this.udPower6.TabIndex = 82;
            this.udPower6.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udPower6.ValueChanged += new System.EventHandler(this.udPower_ValueChanged);
            // 
            // udPower5
            // 
            this.udPower5.Enabled = false;
            this.udPower5.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udPower5.Location = new System.Drawing.Point(782, 196);
            this.udPower5.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udPower5.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udPower5.Name = "udPower5";
            this.udPower5.Size = new System.Drawing.Size(40, 20);
            this.udPower5.TabIndex = 70;
            this.udPower5.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udPower5.ValueChanged += new System.EventHandler(this.udPower_ValueChanged);
            // 
            // udPower4
            // 
            this.udPower4.Enabled = false;
            this.udPower4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udPower4.Location = new System.Drawing.Point(782, 172);
            this.udPower4.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udPower4.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udPower4.Name = "udPower4";
            this.udPower4.Size = new System.Drawing.Size(40, 20);
            this.udPower4.TabIndex = 58;
            this.udPower4.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udPower4.ValueChanged += new System.EventHandler(this.udPower_ValueChanged);
            // 
            // udPower3
            // 
            this.udPower3.Enabled = false;
            this.udPower3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udPower3.Location = new System.Drawing.Point(782, 148);
            this.udPower3.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udPower3.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udPower3.Name = "udPower3";
            this.udPower3.Size = new System.Drawing.Size(40, 20);
            this.udPower3.TabIndex = 46;
            this.udPower3.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udPower3.ValueChanged += new System.EventHandler(this.udPower_ValueChanged);
            // 
            // udPower2
            // 
            this.udPower2.Enabled = false;
            this.udPower2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udPower2.Location = new System.Drawing.Point(782, 124);
            this.udPower2.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udPower2.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udPower2.Name = "udPower2";
            this.udPower2.Size = new System.Drawing.Size(40, 20);
            this.udPower2.TabIndex = 34;
            this.udPower2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udPower2.ValueChanged += new System.EventHandler(this.udPower_ValueChanged);
            // 
            // lblPower
            // 
            this.lblPower.Image = null;
            this.lblPower.Location = new System.Drawing.Point(782, 24);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(40, 16);
            this.lblPower.TabIndex = 153;
            this.lblPower.Text = "Power";
            // 
            // udLOError15
            // 
            this.udLOError15.DecimalPlaces = 3;
            this.udLOError15.Enabled = false;
            this.udLOError15.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLOError15.Location = new System.Drawing.Point(392, 436);
            this.udLOError15.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udLOError15.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.udLOError15.Name = "udLOError15";
            this.udLOError15.Size = new System.Drawing.Size(56, 20);
            this.udLOError15.TabIndex = 185;
            this.udLOError15.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udLOError14
            // 
            this.udLOError14.DecimalPlaces = 3;
            this.udLOError14.Enabled = false;
            this.udLOError14.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLOError14.Location = new System.Drawing.Point(392, 412);
            this.udLOError14.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udLOError14.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.udLOError14.Name = "udLOError14";
            this.udLOError14.Size = new System.Drawing.Size(56, 20);
            this.udLOError14.TabIndex = 173;
            this.udLOError14.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udLOError13
            // 
            this.udLOError13.DecimalPlaces = 3;
            this.udLOError13.Enabled = false;
            this.udLOError13.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLOError13.Location = new System.Drawing.Point(392, 388);
            this.udLOError13.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udLOError13.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.udLOError13.Name = "udLOError13";
            this.udLOError13.Size = new System.Drawing.Size(56, 20);
            this.udLOError13.TabIndex = 161;
            this.udLOError13.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udLOError12
            // 
            this.udLOError12.DecimalPlaces = 3;
            this.udLOError12.Enabled = false;
            this.udLOError12.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLOError12.Location = new System.Drawing.Point(392, 364);
            this.udLOError12.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udLOError12.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.udLOError12.Name = "udLOError12";
            this.udLOError12.Size = new System.Drawing.Size(56, 20);
            this.udLOError12.TabIndex = 149;
            this.udLOError12.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udLOError11
            // 
            this.udLOError11.DecimalPlaces = 3;
            this.udLOError11.Enabled = false;
            this.udLOError11.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLOError11.Location = new System.Drawing.Point(392, 340);
            this.udLOError11.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udLOError11.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.udLOError11.Name = "udLOError11";
            this.udLOError11.Size = new System.Drawing.Size(56, 20);
            this.udLOError11.TabIndex = 137;
            this.udLOError11.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udLOError10
            // 
            this.udLOError10.DecimalPlaces = 3;
            this.udLOError10.Enabled = false;
            this.udLOError10.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLOError10.Location = new System.Drawing.Point(392, 316);
            this.udLOError10.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udLOError10.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.udLOError10.Name = "udLOError10";
            this.udLOError10.Size = new System.Drawing.Size(56, 20);
            this.udLOError10.TabIndex = 125;
            this.udLOError10.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udLOError9
            // 
            this.udLOError9.DecimalPlaces = 3;
            this.udLOError9.Enabled = false;
            this.udLOError9.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLOError9.Location = new System.Drawing.Point(392, 292);
            this.udLOError9.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udLOError9.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.udLOError9.Name = "udLOError9";
            this.udLOError9.Size = new System.Drawing.Size(56, 20);
            this.udLOError9.TabIndex = 113;
            this.udLOError9.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udLOError8
            // 
            this.udLOError8.DecimalPlaces = 3;
            this.udLOError8.Enabled = false;
            this.udLOError8.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLOError8.Location = new System.Drawing.Point(392, 268);
            this.udLOError8.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udLOError8.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.udLOError8.Name = "udLOError8";
            this.udLOError8.Size = new System.Drawing.Size(56, 20);
            this.udLOError8.TabIndex = 101;
            this.udLOError8.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udLOError7
            // 
            this.udLOError7.DecimalPlaces = 3;
            this.udLOError7.Enabled = false;
            this.udLOError7.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLOError7.Location = new System.Drawing.Point(392, 244);
            this.udLOError7.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udLOError7.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.udLOError7.Name = "udLOError7";
            this.udLOError7.Size = new System.Drawing.Size(56, 20);
            this.udLOError7.TabIndex = 89;
            this.udLOError7.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udLOError6
            // 
            this.udLOError6.DecimalPlaces = 3;
            this.udLOError6.Enabled = false;
            this.udLOError6.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLOError6.Location = new System.Drawing.Point(392, 220);
            this.udLOError6.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udLOError6.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.udLOError6.Name = "udLOError6";
            this.udLOError6.Size = new System.Drawing.Size(56, 20);
            this.udLOError6.TabIndex = 77;
            this.udLOError6.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udLOError5
            // 
            this.udLOError5.DecimalPlaces = 3;
            this.udLOError5.Enabled = false;
            this.udLOError5.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLOError5.Location = new System.Drawing.Point(392, 196);
            this.udLOError5.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udLOError5.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.udLOError5.Name = "udLOError5";
            this.udLOError5.Size = new System.Drawing.Size(56, 20);
            this.udLOError5.TabIndex = 65;
            this.udLOError5.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udLOError4
            // 
            this.udLOError4.DecimalPlaces = 3;
            this.udLOError4.Enabled = false;
            this.udLOError4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLOError4.Location = new System.Drawing.Point(392, 172);
            this.udLOError4.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udLOError4.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.udLOError4.Name = "udLOError4";
            this.udLOError4.Size = new System.Drawing.Size(56, 20);
            this.udLOError4.TabIndex = 53;
            this.udLOError4.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udLOError3
            // 
            this.udLOError3.DecimalPlaces = 3;
            this.udLOError3.Enabled = false;
            this.udLOError3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLOError3.Location = new System.Drawing.Point(392, 148);
            this.udLOError3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udLOError3.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.udLOError3.Name = "udLOError3";
            this.udLOError3.Size = new System.Drawing.Size(56, 20);
            this.udLOError3.TabIndex = 41;
            this.udLOError3.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udLOError2
            // 
            this.udLOError2.DecimalPlaces = 3;
            this.udLOError2.Enabled = false;
            this.udLOError2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLOError2.Location = new System.Drawing.Point(392, 124);
            this.udLOError2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udLOError2.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.udLOError2.Name = "udLOError2";
            this.udLOError2.Size = new System.Drawing.Size(56, 20);
            this.udLOError2.TabIndex = 29;
            this.udLOError2.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // lblLOError
            // 
            this.lblLOError.Enabled = false;
            this.lblLOError.Image = null;
            this.lblLOError.Location = new System.Drawing.Point(392, 16);
            this.lblLOError.Name = "lblLOError";
            this.lblLOError.Size = new System.Drawing.Size(56, 32);
            this.lblLOError.TabIndex = 136;
            this.lblLOError.Text = "LO Error (kHz)";
            // 
            // chkRXOnly15
            // 
            this.chkRXOnly15.Enabled = false;
            this.chkRXOnly15.Image = null;
            this.chkRXOnly15.Location = new System.Drawing.Point(742, 436);
            this.chkRXOnly15.Name = "chkRXOnly15";
            this.chkRXOnly15.Size = new System.Drawing.Size(16, 16);
            this.chkRXOnly15.TabIndex = 189;
            // 
            // chkRXOnly14
            // 
            this.chkRXOnly14.Enabled = false;
            this.chkRXOnly14.Image = null;
            this.chkRXOnly14.Location = new System.Drawing.Point(742, 412);
            this.chkRXOnly14.Name = "chkRXOnly14";
            this.chkRXOnly14.Size = new System.Drawing.Size(16, 16);
            this.chkRXOnly14.TabIndex = 177;
            // 
            // chkRXOnly13
            // 
            this.chkRXOnly13.Enabled = false;
            this.chkRXOnly13.Image = null;
            this.chkRXOnly13.Location = new System.Drawing.Point(742, 388);
            this.chkRXOnly13.Name = "chkRXOnly13";
            this.chkRXOnly13.Size = new System.Drawing.Size(16, 16);
            this.chkRXOnly13.TabIndex = 165;
            // 
            // chkRXOnly12
            // 
            this.chkRXOnly12.Enabled = false;
            this.chkRXOnly12.Image = null;
            this.chkRXOnly12.Location = new System.Drawing.Point(742, 364);
            this.chkRXOnly12.Name = "chkRXOnly12";
            this.chkRXOnly12.Size = new System.Drawing.Size(16, 16);
            this.chkRXOnly12.TabIndex = 153;
            // 
            // chkRXOnly11
            // 
            this.chkRXOnly11.Enabled = false;
            this.chkRXOnly11.Image = null;
            this.chkRXOnly11.Location = new System.Drawing.Point(742, 340);
            this.chkRXOnly11.Name = "chkRXOnly11";
            this.chkRXOnly11.Size = new System.Drawing.Size(16, 16);
            this.chkRXOnly11.TabIndex = 141;
            // 
            // chkRXOnly10
            // 
            this.chkRXOnly10.Enabled = false;
            this.chkRXOnly10.Image = null;
            this.chkRXOnly10.Location = new System.Drawing.Point(742, 316);
            this.chkRXOnly10.Name = "chkRXOnly10";
            this.chkRXOnly10.Size = new System.Drawing.Size(16, 16);
            this.chkRXOnly10.TabIndex = 129;
            // 
            // chkRXOnly9
            // 
            this.chkRXOnly9.Enabled = false;
            this.chkRXOnly9.Image = null;
            this.chkRXOnly9.Location = new System.Drawing.Point(742, 292);
            this.chkRXOnly9.Name = "chkRXOnly9";
            this.chkRXOnly9.Size = new System.Drawing.Size(16, 16);
            this.chkRXOnly9.TabIndex = 117;
            // 
            // chkRXOnly8
            // 
            this.chkRXOnly8.Enabled = false;
            this.chkRXOnly8.Image = null;
            this.chkRXOnly8.Location = new System.Drawing.Point(742, 268);
            this.chkRXOnly8.Name = "chkRXOnly8";
            this.chkRXOnly8.Size = new System.Drawing.Size(16, 16);
            this.chkRXOnly8.TabIndex = 105;
            // 
            // chkRXOnly7
            // 
            this.chkRXOnly7.Enabled = false;
            this.chkRXOnly7.Image = null;
            this.chkRXOnly7.Location = new System.Drawing.Point(742, 244);
            this.chkRXOnly7.Name = "chkRXOnly7";
            this.chkRXOnly7.Size = new System.Drawing.Size(16, 16);
            this.chkRXOnly7.TabIndex = 93;
            // 
            // chkRXOnly6
            // 
            this.chkRXOnly6.Enabled = false;
            this.chkRXOnly6.Image = null;
            this.chkRXOnly6.Location = new System.Drawing.Point(742, 220);
            this.chkRXOnly6.Name = "chkRXOnly6";
            this.chkRXOnly6.Size = new System.Drawing.Size(16, 16);
            this.chkRXOnly6.TabIndex = 81;
            // 
            // chkRXOnly5
            // 
            this.chkRXOnly5.Enabled = false;
            this.chkRXOnly5.Image = null;
            this.chkRXOnly5.Location = new System.Drawing.Point(742, 196);
            this.chkRXOnly5.Name = "chkRXOnly5";
            this.chkRXOnly5.Size = new System.Drawing.Size(16, 16);
            this.chkRXOnly5.TabIndex = 69;
            // 
            // chkRXOnly4
            // 
            this.chkRXOnly4.Enabled = false;
            this.chkRXOnly4.Image = null;
            this.chkRXOnly4.Location = new System.Drawing.Point(742, 172);
            this.chkRXOnly4.Name = "chkRXOnly4";
            this.chkRXOnly4.Size = new System.Drawing.Size(16, 16);
            this.chkRXOnly4.TabIndex = 57;
            // 
            // chkRXOnly3
            // 
            this.chkRXOnly3.Enabled = false;
            this.chkRXOnly3.Image = null;
            this.chkRXOnly3.Location = new System.Drawing.Point(742, 148);
            this.chkRXOnly3.Name = "chkRXOnly3";
            this.chkRXOnly3.Size = new System.Drawing.Size(16, 16);
            this.chkRXOnly3.TabIndex = 45;
            // 
            // chkRXOnly2
            // 
            this.chkRXOnly2.Enabled = false;
            this.chkRXOnly2.Image = null;
            this.chkRXOnly2.Location = new System.Drawing.Point(742, 124);
            this.chkRXOnly2.Name = "chkRXOnly2";
            this.chkRXOnly2.Size = new System.Drawing.Size(16, 16);
            this.chkRXOnly2.TabIndex = 33;
            // 
            // lblRXOnly
            // 
            this.lblRXOnly.Image = null;
            this.lblRXOnly.Location = new System.Drawing.Point(726, 24);
            this.lblRXOnly.Name = "lblRXOnly";
            this.lblRXOnly.Size = new System.Drawing.Size(48, 16);
            this.lblRXOnly.TabIndex = 119;
            this.lblRXOnly.Text = "RX Only";
            // 
            // udFreqEnd15
            // 
            this.udFreqEnd15.DecimalPlaces = 6;
            this.udFreqEnd15.Enabled = false;
            this.udFreqEnd15.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udFreqEnd15.Location = new System.Drawing.Point(560, 436);
            this.udFreqEnd15.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udFreqEnd15.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udFreqEnd15.Name = "udFreqEnd15";
            this.udFreqEnd15.Size = new System.Drawing.Size(96, 20);
            this.udFreqEnd15.TabIndex = 187;
            this.udFreqEnd15.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udFreqEnd14
            // 
            this.udFreqEnd14.DecimalPlaces = 6;
            this.udFreqEnd14.Enabled = false;
            this.udFreqEnd14.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udFreqEnd14.Location = new System.Drawing.Point(560, 412);
            this.udFreqEnd14.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udFreqEnd14.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udFreqEnd14.Name = "udFreqEnd14";
            this.udFreqEnd14.Size = new System.Drawing.Size(96, 20);
            this.udFreqEnd14.TabIndex = 175;
            this.udFreqEnd14.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udFreqEnd13
            // 
            this.udFreqEnd13.DecimalPlaces = 6;
            this.udFreqEnd13.Enabled = false;
            this.udFreqEnd13.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udFreqEnd13.Location = new System.Drawing.Point(560, 388);
            this.udFreqEnd13.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udFreqEnd13.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udFreqEnd13.Name = "udFreqEnd13";
            this.udFreqEnd13.Size = new System.Drawing.Size(96, 20);
            this.udFreqEnd13.TabIndex = 163;
            this.udFreqEnd13.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udFreqEnd12
            // 
            this.udFreqEnd12.DecimalPlaces = 6;
            this.udFreqEnd12.Enabled = false;
            this.udFreqEnd12.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udFreqEnd12.Location = new System.Drawing.Point(560, 364);
            this.udFreqEnd12.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udFreqEnd12.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udFreqEnd12.Name = "udFreqEnd12";
            this.udFreqEnd12.Size = new System.Drawing.Size(96, 20);
            this.udFreqEnd12.TabIndex = 151;
            this.udFreqEnd12.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udFreqEnd11
            // 
            this.udFreqEnd11.DecimalPlaces = 6;
            this.udFreqEnd11.Enabled = false;
            this.udFreqEnd11.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udFreqEnd11.Location = new System.Drawing.Point(560, 340);
            this.udFreqEnd11.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udFreqEnd11.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udFreqEnd11.Name = "udFreqEnd11";
            this.udFreqEnd11.Size = new System.Drawing.Size(96, 20);
            this.udFreqEnd11.TabIndex = 139;
            this.udFreqEnd11.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udFreqEnd10
            // 
            this.udFreqEnd10.DecimalPlaces = 6;
            this.udFreqEnd10.Enabled = false;
            this.udFreqEnd10.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udFreqEnd10.Location = new System.Drawing.Point(560, 316);
            this.udFreqEnd10.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udFreqEnd10.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udFreqEnd10.Name = "udFreqEnd10";
            this.udFreqEnd10.Size = new System.Drawing.Size(96, 20);
            this.udFreqEnd10.TabIndex = 127;
            this.udFreqEnd10.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udFreqEnd9
            // 
            this.udFreqEnd9.DecimalPlaces = 6;
            this.udFreqEnd9.Enabled = false;
            this.udFreqEnd9.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udFreqEnd9.Location = new System.Drawing.Point(560, 292);
            this.udFreqEnd9.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udFreqEnd9.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udFreqEnd9.Name = "udFreqEnd9";
            this.udFreqEnd9.Size = new System.Drawing.Size(96, 20);
            this.udFreqEnd9.TabIndex = 115;
            this.udFreqEnd9.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udFreqEnd8
            // 
            this.udFreqEnd8.DecimalPlaces = 6;
            this.udFreqEnd8.Enabled = false;
            this.udFreqEnd8.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udFreqEnd8.Location = new System.Drawing.Point(560, 268);
            this.udFreqEnd8.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udFreqEnd8.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udFreqEnd8.Name = "udFreqEnd8";
            this.udFreqEnd8.Size = new System.Drawing.Size(96, 20);
            this.udFreqEnd8.TabIndex = 103;
            this.udFreqEnd8.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udFreqEnd7
            // 
            this.udFreqEnd7.DecimalPlaces = 6;
            this.udFreqEnd7.Enabled = false;
            this.udFreqEnd7.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udFreqEnd7.Location = new System.Drawing.Point(560, 244);
            this.udFreqEnd7.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udFreqEnd7.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udFreqEnd7.Name = "udFreqEnd7";
            this.udFreqEnd7.Size = new System.Drawing.Size(96, 20);
            this.udFreqEnd7.TabIndex = 91;
            this.udFreqEnd7.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udFreqEnd6
            // 
            this.udFreqEnd6.DecimalPlaces = 6;
            this.udFreqEnd6.Enabled = false;
            this.udFreqEnd6.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udFreqEnd6.Location = new System.Drawing.Point(560, 220);
            this.udFreqEnd6.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udFreqEnd6.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udFreqEnd6.Name = "udFreqEnd6";
            this.udFreqEnd6.Size = new System.Drawing.Size(96, 20);
            this.udFreqEnd6.TabIndex = 79;
            this.udFreqEnd6.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udFreqEnd5
            // 
            this.udFreqEnd5.DecimalPlaces = 6;
            this.udFreqEnd5.Enabled = false;
            this.udFreqEnd5.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udFreqEnd5.Location = new System.Drawing.Point(560, 196);
            this.udFreqEnd5.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udFreqEnd5.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udFreqEnd5.Name = "udFreqEnd5";
            this.udFreqEnd5.Size = new System.Drawing.Size(96, 20);
            this.udFreqEnd5.TabIndex = 67;
            this.udFreqEnd5.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udFreqEnd4
            // 
            this.udFreqEnd4.DecimalPlaces = 6;
            this.udFreqEnd4.Enabled = false;
            this.udFreqEnd4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udFreqEnd4.Location = new System.Drawing.Point(560, 172);
            this.udFreqEnd4.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udFreqEnd4.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udFreqEnd4.Name = "udFreqEnd4";
            this.udFreqEnd4.Size = new System.Drawing.Size(96, 20);
            this.udFreqEnd4.TabIndex = 55;
            this.udFreqEnd4.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udFreqEnd3
            // 
            this.udFreqEnd3.DecimalPlaces = 6;
            this.udFreqEnd3.Enabled = false;
            this.udFreqEnd3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udFreqEnd3.Location = new System.Drawing.Point(560, 148);
            this.udFreqEnd3.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udFreqEnd3.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udFreqEnd3.Name = "udFreqEnd3";
            this.udFreqEnd3.Size = new System.Drawing.Size(96, 20);
            this.udFreqEnd3.TabIndex = 43;
            this.udFreqEnd3.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udFreqEnd2
            // 
            this.udFreqEnd2.DecimalPlaces = 6;
            this.udFreqEnd2.Enabled = false;
            this.udFreqEnd2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udFreqEnd2.Location = new System.Drawing.Point(560, 124);
            this.udFreqEnd2.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udFreqEnd2.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udFreqEnd2.Name = "udFreqEnd2";
            this.udFreqEnd2.Size = new System.Drawing.Size(96, 20);
            this.udFreqEnd2.TabIndex = 31;
            this.udFreqEnd2.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // lblFreqEnd
            // 
            this.lblFreqEnd.Image = null;
            this.lblFreqEnd.Location = new System.Drawing.Point(568, 24);
            this.lblFreqEnd.Name = "lblFreqEnd";
            this.lblFreqEnd.Size = new System.Drawing.Size(88, 16);
            this.lblFreqEnd.TabIndex = 102;
            this.lblFreqEnd.Text = "End Freq (MHz)";
            // 
            // udFreqBegin15
            // 
            this.udFreqBegin15.DecimalPlaces = 6;
            this.udFreqBegin15.Enabled = false;
            this.udFreqBegin15.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udFreqBegin15.Location = new System.Drawing.Point(456, 436);
            this.udFreqBegin15.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udFreqBegin15.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udFreqBegin15.Name = "udFreqBegin15";
            this.udFreqBegin15.Size = new System.Drawing.Size(96, 20);
            this.udFreqBegin15.TabIndex = 186;
            this.udFreqBegin15.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udFreqBegin14
            // 
            this.udFreqBegin14.DecimalPlaces = 6;
            this.udFreqBegin14.Enabled = false;
            this.udFreqBegin14.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udFreqBegin14.Location = new System.Drawing.Point(456, 412);
            this.udFreqBegin14.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udFreqBegin14.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udFreqBegin14.Name = "udFreqBegin14";
            this.udFreqBegin14.Size = new System.Drawing.Size(96, 20);
            this.udFreqBegin14.TabIndex = 174;
            this.udFreqBegin14.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udFreqBegin13
            // 
            this.udFreqBegin13.DecimalPlaces = 6;
            this.udFreqBegin13.Enabled = false;
            this.udFreqBegin13.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udFreqBegin13.Location = new System.Drawing.Point(456, 388);
            this.udFreqBegin13.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udFreqBegin13.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udFreqBegin13.Name = "udFreqBegin13";
            this.udFreqBegin13.Size = new System.Drawing.Size(96, 20);
            this.udFreqBegin13.TabIndex = 162;
            this.udFreqBegin13.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udFreqBegin12
            // 
            this.udFreqBegin12.DecimalPlaces = 6;
            this.udFreqBegin12.Enabled = false;
            this.udFreqBegin12.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udFreqBegin12.Location = new System.Drawing.Point(456, 364);
            this.udFreqBegin12.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udFreqBegin12.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udFreqBegin12.Name = "udFreqBegin12";
            this.udFreqBegin12.Size = new System.Drawing.Size(96, 20);
            this.udFreqBegin12.TabIndex = 150;
            this.udFreqBegin12.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udFreqBegin11
            // 
            this.udFreqBegin11.DecimalPlaces = 6;
            this.udFreqBegin11.Enabled = false;
            this.udFreqBegin11.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udFreqBegin11.Location = new System.Drawing.Point(456, 340);
            this.udFreqBegin11.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udFreqBegin11.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udFreqBegin11.Name = "udFreqBegin11";
            this.udFreqBegin11.Size = new System.Drawing.Size(96, 20);
            this.udFreqBegin11.TabIndex = 138;
            this.udFreqBegin11.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udFreqBegin10
            // 
            this.udFreqBegin10.DecimalPlaces = 6;
            this.udFreqBegin10.Enabled = false;
            this.udFreqBegin10.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udFreqBegin10.Location = new System.Drawing.Point(456, 316);
            this.udFreqBegin10.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udFreqBegin10.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udFreqBegin10.Name = "udFreqBegin10";
            this.udFreqBegin10.Size = new System.Drawing.Size(96, 20);
            this.udFreqBegin10.TabIndex = 126;
            this.udFreqBegin10.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udFreqBegin9
            // 
            this.udFreqBegin9.DecimalPlaces = 6;
            this.udFreqBegin9.Enabled = false;
            this.udFreqBegin9.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udFreqBegin9.Location = new System.Drawing.Point(456, 292);
            this.udFreqBegin9.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udFreqBegin9.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udFreqBegin9.Name = "udFreqBegin9";
            this.udFreqBegin9.Size = new System.Drawing.Size(96, 20);
            this.udFreqBegin9.TabIndex = 114;
            this.udFreqBegin9.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udFreqBegin8
            // 
            this.udFreqBegin8.DecimalPlaces = 6;
            this.udFreqBegin8.Enabled = false;
            this.udFreqBegin8.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udFreqBegin8.Location = new System.Drawing.Point(456, 268);
            this.udFreqBegin8.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udFreqBegin8.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udFreqBegin8.Name = "udFreqBegin8";
            this.udFreqBegin8.Size = new System.Drawing.Size(96, 20);
            this.udFreqBegin8.TabIndex = 102;
            this.udFreqBegin8.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udFreqBegin7
            // 
            this.udFreqBegin7.DecimalPlaces = 6;
            this.udFreqBegin7.Enabled = false;
            this.udFreqBegin7.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udFreqBegin7.Location = new System.Drawing.Point(456, 244);
            this.udFreqBegin7.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udFreqBegin7.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udFreqBegin7.Name = "udFreqBegin7";
            this.udFreqBegin7.Size = new System.Drawing.Size(96, 20);
            this.udFreqBegin7.TabIndex = 90;
            this.udFreqBegin7.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udFreqBegin6
            // 
            this.udFreqBegin6.DecimalPlaces = 6;
            this.udFreqBegin6.Enabled = false;
            this.udFreqBegin6.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udFreqBegin6.Location = new System.Drawing.Point(456, 220);
            this.udFreqBegin6.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udFreqBegin6.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udFreqBegin6.Name = "udFreqBegin6";
            this.udFreqBegin6.Size = new System.Drawing.Size(96, 20);
            this.udFreqBegin6.TabIndex = 78;
            this.udFreqBegin6.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udFreqBegin5
            // 
            this.udFreqBegin5.DecimalPlaces = 6;
            this.udFreqBegin5.Enabled = false;
            this.udFreqBegin5.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udFreqBegin5.Location = new System.Drawing.Point(456, 196);
            this.udFreqBegin5.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udFreqBegin5.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udFreqBegin5.Name = "udFreqBegin5";
            this.udFreqBegin5.Size = new System.Drawing.Size(96, 20);
            this.udFreqBegin5.TabIndex = 66;
            this.udFreqBegin5.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udFreqBegin4
            // 
            this.udFreqBegin4.DecimalPlaces = 6;
            this.udFreqBegin4.Enabled = false;
            this.udFreqBegin4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udFreqBegin4.Location = new System.Drawing.Point(456, 172);
            this.udFreqBegin4.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udFreqBegin4.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udFreqBegin4.Name = "udFreqBegin4";
            this.udFreqBegin4.Size = new System.Drawing.Size(96, 20);
            this.udFreqBegin4.TabIndex = 54;
            this.udFreqBegin4.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udFreqBegin3
            // 
            this.udFreqBegin3.DecimalPlaces = 6;
            this.udFreqBegin3.Enabled = false;
            this.udFreqBegin3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udFreqBegin3.Location = new System.Drawing.Point(456, 148);
            this.udFreqBegin3.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udFreqBegin3.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udFreqBegin3.Name = "udFreqBegin3";
            this.udFreqBegin3.Size = new System.Drawing.Size(96, 20);
            this.udFreqBegin3.TabIndex = 42;
            this.udFreqBegin3.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udFreqBegin2
            // 
            this.udFreqBegin2.DecimalPlaces = 6;
            this.udFreqBegin2.Enabled = false;
            this.udFreqBegin2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udFreqBegin2.Location = new System.Drawing.Point(456, 124);
            this.udFreqBegin2.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udFreqBegin2.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udFreqBegin2.Name = "udFreqBegin2";
            this.udFreqBegin2.Size = new System.Drawing.Size(96, 20);
            this.udFreqBegin2.TabIndex = 30;
            this.udFreqBegin2.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // lblFreqBegin
            // 
            this.lblFreqBegin.Image = null;
            this.lblFreqBegin.Location = new System.Drawing.Point(456, 24);
            this.lblFreqBegin.Name = "lblFreqBegin";
            this.lblFreqBegin.Size = new System.Drawing.Size(96, 16);
            this.lblFreqBegin.TabIndex = 85;
            this.lblFreqBegin.Text = "Begin Freq (MHz)";
            // 
            // udLOOffset15
            // 
            this.udLOOffset15.DecimalPlaces = 1;
            this.udLOOffset15.Enabled = false;
            this.udLOOffset15.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLOOffset15.Location = new System.Drawing.Point(304, 436);
            this.udLOOffset15.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udLOOffset15.Minimum = new decimal(new int[] {
            144,
            0,
            0,
            -2147483648});
            this.udLOOffset15.Name = "udLOOffset15";
            this.udLOOffset15.Size = new System.Drawing.Size(80, 20);
            this.udLOOffset15.TabIndex = 184;
            this.udLOOffset15.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udLOOffset14
            // 
            this.udLOOffset14.DecimalPlaces = 1;
            this.udLOOffset14.Enabled = false;
            this.udLOOffset14.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLOOffset14.Location = new System.Drawing.Point(304, 412);
            this.udLOOffset14.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udLOOffset14.Minimum = new decimal(new int[] {
            144,
            0,
            0,
            -2147483648});
            this.udLOOffset14.Name = "udLOOffset14";
            this.udLOOffset14.Size = new System.Drawing.Size(80, 20);
            this.udLOOffset14.TabIndex = 172;
            this.udLOOffset14.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udLOOffset13
            // 
            this.udLOOffset13.DecimalPlaces = 1;
            this.udLOOffset13.Enabled = false;
            this.udLOOffset13.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLOOffset13.Location = new System.Drawing.Point(304, 388);
            this.udLOOffset13.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udLOOffset13.Minimum = new decimal(new int[] {
            144,
            0,
            0,
            -2147483648});
            this.udLOOffset13.Name = "udLOOffset13";
            this.udLOOffset13.Size = new System.Drawing.Size(80, 20);
            this.udLOOffset13.TabIndex = 160;
            this.udLOOffset13.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udLOOffset12
            // 
            this.udLOOffset12.DecimalPlaces = 1;
            this.udLOOffset12.Enabled = false;
            this.udLOOffset12.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLOOffset12.Location = new System.Drawing.Point(304, 364);
            this.udLOOffset12.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udLOOffset12.Minimum = new decimal(new int[] {
            144,
            0,
            0,
            -2147483648});
            this.udLOOffset12.Name = "udLOOffset12";
            this.udLOOffset12.Size = new System.Drawing.Size(80, 20);
            this.udLOOffset12.TabIndex = 148;
            this.udLOOffset12.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udLOOffset11
            // 
            this.udLOOffset11.DecimalPlaces = 1;
            this.udLOOffset11.Enabled = false;
            this.udLOOffset11.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLOOffset11.Location = new System.Drawing.Point(304, 340);
            this.udLOOffset11.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udLOOffset11.Minimum = new decimal(new int[] {
            144,
            0,
            0,
            -2147483648});
            this.udLOOffset11.Name = "udLOOffset11";
            this.udLOOffset11.Size = new System.Drawing.Size(80, 20);
            this.udLOOffset11.TabIndex = 136;
            this.udLOOffset11.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udLOOffset10
            // 
            this.udLOOffset10.DecimalPlaces = 1;
            this.udLOOffset10.Enabled = false;
            this.udLOOffset10.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLOOffset10.Location = new System.Drawing.Point(304, 316);
            this.udLOOffset10.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udLOOffset10.Minimum = new decimal(new int[] {
            144,
            0,
            0,
            -2147483648});
            this.udLOOffset10.Name = "udLOOffset10";
            this.udLOOffset10.Size = new System.Drawing.Size(80, 20);
            this.udLOOffset10.TabIndex = 124;
            this.udLOOffset10.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udLOOffset9
            // 
            this.udLOOffset9.DecimalPlaces = 1;
            this.udLOOffset9.Enabled = false;
            this.udLOOffset9.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLOOffset9.Location = new System.Drawing.Point(304, 292);
            this.udLOOffset9.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udLOOffset9.Minimum = new decimal(new int[] {
            144,
            0,
            0,
            -2147483648});
            this.udLOOffset9.Name = "udLOOffset9";
            this.udLOOffset9.Size = new System.Drawing.Size(80, 20);
            this.udLOOffset9.TabIndex = 112;
            this.udLOOffset9.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udLOOffset8
            // 
            this.udLOOffset8.DecimalPlaces = 1;
            this.udLOOffset8.Enabled = false;
            this.udLOOffset8.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLOOffset8.Location = new System.Drawing.Point(304, 268);
            this.udLOOffset8.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udLOOffset8.Minimum = new decimal(new int[] {
            144,
            0,
            0,
            -2147483648});
            this.udLOOffset8.Name = "udLOOffset8";
            this.udLOOffset8.Size = new System.Drawing.Size(80, 20);
            this.udLOOffset8.TabIndex = 100;
            this.udLOOffset8.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udLOOffset7
            // 
            this.udLOOffset7.DecimalPlaces = 1;
            this.udLOOffset7.Enabled = false;
            this.udLOOffset7.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLOOffset7.Location = new System.Drawing.Point(304, 244);
            this.udLOOffset7.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udLOOffset7.Minimum = new decimal(new int[] {
            144,
            0,
            0,
            -2147483648});
            this.udLOOffset7.Name = "udLOOffset7";
            this.udLOOffset7.Size = new System.Drawing.Size(80, 20);
            this.udLOOffset7.TabIndex = 88;
            this.udLOOffset7.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udLOOffset6
            // 
            this.udLOOffset6.DecimalPlaces = 1;
            this.udLOOffset6.Enabled = false;
            this.udLOOffset6.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLOOffset6.Location = new System.Drawing.Point(304, 220);
            this.udLOOffset6.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udLOOffset6.Minimum = new decimal(new int[] {
            144,
            0,
            0,
            -2147483648});
            this.udLOOffset6.Name = "udLOOffset6";
            this.udLOOffset6.Size = new System.Drawing.Size(80, 20);
            this.udLOOffset6.TabIndex = 76;
            this.udLOOffset6.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udLOOffset5
            // 
            this.udLOOffset5.DecimalPlaces = 1;
            this.udLOOffset5.Enabled = false;
            this.udLOOffset5.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLOOffset5.Location = new System.Drawing.Point(304, 196);
            this.udLOOffset5.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.udLOOffset5.Minimum = new decimal(new int[] {
            144,
            0,
            0,
            -2147483648});
            this.udLOOffset5.Name = "udLOOffset5";
            this.udLOOffset5.Size = new System.Drawing.Size(80, 20);
            this.udLOOffset5.TabIndex = 64;
            this.udLOOffset5.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udLOOffset4
            // 
            this.udLOOffset4.DecimalPlaces = 1;
            this.udLOOffset4.Enabled = false;
            this.udLOOffset4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLOOffset4.Location = new System.Drawing.Point(304, 172);
            this.udLOOffset4.Maximum = new decimal(new int[] {
            2500000,
            0,
            0,
            0});
            this.udLOOffset4.Minimum = new decimal(new int[] {
            144,
            0,
            0,
            -2147483648});
            this.udLOOffset4.Name = "udLOOffset4";
            this.udLOOffset4.Size = new System.Drawing.Size(80, 20);
            this.udLOOffset4.TabIndex = 52;
            this.udLOOffset4.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udLOOffset3
            // 
            this.udLOOffset3.DecimalPlaces = 1;
            this.udLOOffset3.Enabled = false;
            this.udLOOffset3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLOOffset3.Location = new System.Drawing.Point(304, 148);
            this.udLOOffset3.Maximum = new decimal(new int[] {
            2500000,
            0,
            0,
            0});
            this.udLOOffset3.Minimum = new decimal(new int[] {
            144,
            0,
            0,
            -2147483648});
            this.udLOOffset3.Name = "udLOOffset3";
            this.udLOOffset3.Size = new System.Drawing.Size(80, 20);
            this.udLOOffset3.TabIndex = 40;
            this.udLOOffset3.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // udLOOffset2
            // 
            this.udLOOffset2.DecimalPlaces = 1;
            this.udLOOffset2.Enabled = false;
            this.udLOOffset2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLOOffset2.Location = new System.Drawing.Point(304, 124);
            this.udLOOffset2.Maximum = new decimal(new int[] {
            2500000,
            0,
            0,
            0});
            this.udLOOffset2.Minimum = new decimal(new int[] {
            144,
            0,
            0,
            -2147483648});
            this.udLOOffset2.Name = "udLOOffset2";
            this.udLOOffset2.Size = new System.Drawing.Size(80, 20);
            this.udLOOffset2.TabIndex = 28;
            this.udLOOffset2.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // lblLOOffset
            // 
            this.lblLOOffset.Enabled = false;
            this.lblLOOffset.Image = null;
            this.lblLOOffset.Location = new System.Drawing.Point(304, 16);
            this.lblLOOffset.Name = "lblLOOffset";
            this.lblLOOffset.Size = new System.Drawing.Size(72, 32);
            this.lblLOOffset.TabIndex = 68;
            this.lblLOOffset.Text = "LO Offset (MHz)";
            // 
            // txtButtonText15
            // 
            this.txtButtonText15.Enabled = false;
            this.txtButtonText15.Location = new System.Drawing.Point(224, 436);
            this.txtButtonText15.MaxLength = 5;
            this.txtButtonText15.Name = "txtButtonText15";
            this.txtButtonText15.Size = new System.Drawing.Size(64, 20);
            this.txtButtonText15.TabIndex = 183;
            this.txtButtonText15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtButtonText15.Visible = false;
            this.txtButtonText15.TextChanged += new System.EventHandler(this.txtButtonText_TextChanged);
            this.txtButtonText15.MouseHover += new System.EventHandler(this.txtButtonText15_MouseHover);
            // 
            // txtButtonText14
            // 
            this.txtButtonText14.Enabled = false;
            this.txtButtonText14.Location = new System.Drawing.Point(224, 412);
            this.txtButtonText14.MaxLength = 5;
            this.txtButtonText14.Name = "txtButtonText14";
            this.txtButtonText14.Size = new System.Drawing.Size(64, 20);
            this.txtButtonText14.TabIndex = 171;
            this.txtButtonText14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtButtonText14.Visible = false;
            this.txtButtonText14.TextChanged += new System.EventHandler(this.txtButtonText_TextChanged);
            this.txtButtonText14.MouseHover += new System.EventHandler(this.txtButtonText14_MouseHover);
            // 
            // txtButtonText13
            // 
            this.txtButtonText13.Enabled = false;
            this.txtButtonText13.Location = new System.Drawing.Point(224, 388);
            this.txtButtonText13.MaxLength = 5;
            this.txtButtonText13.Name = "txtButtonText13";
            this.txtButtonText13.Size = new System.Drawing.Size(64, 20);
            this.txtButtonText13.TabIndex = 159;
            this.txtButtonText13.Text = "13";
            this.txtButtonText13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtButtonText13.TextChanged += new System.EventHandler(this.txtButtonText_TextChanged);
            this.txtButtonText13.MouseHover += new System.EventHandler(this.txtButtonText13_MouseHover);
            // 
            // txtButtonText12
            // 
            this.txtButtonText12.Enabled = false;
            this.txtButtonText12.Location = new System.Drawing.Point(224, 364);
            this.txtButtonText12.MaxLength = 5;
            this.txtButtonText12.Name = "txtButtonText12";
            this.txtButtonText12.Size = new System.Drawing.Size(64, 20);
            this.txtButtonText12.TabIndex = 147;
            this.txtButtonText12.Text = "12";
            this.txtButtonText12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtButtonText12.TextChanged += new System.EventHandler(this.txtButtonText_TextChanged);
            this.txtButtonText12.MouseHover += new System.EventHandler(this.txtButtonText12_MouseHover);
            // 
            // txtButtonText11
            // 
            this.txtButtonText11.Enabled = false;
            this.txtButtonText11.Location = new System.Drawing.Point(224, 340);
            this.txtButtonText11.MaxLength = 5;
            this.txtButtonText11.Name = "txtButtonText11";
            this.txtButtonText11.Size = new System.Drawing.Size(64, 20);
            this.txtButtonText11.TabIndex = 135;
            this.txtButtonText11.Text = "11";
            this.txtButtonText11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtButtonText11.TextChanged += new System.EventHandler(this.txtButtonText_TextChanged);
            this.txtButtonText11.MouseHover += new System.EventHandler(this.txtButtonText11_MouseHover);
            // 
            // txtButtonText10
            // 
            this.txtButtonText10.Enabled = false;
            this.txtButtonText10.Location = new System.Drawing.Point(224, 316);
            this.txtButtonText10.MaxLength = 5;
            this.txtButtonText10.Name = "txtButtonText10";
            this.txtButtonText10.Size = new System.Drawing.Size(64, 20);
            this.txtButtonText10.TabIndex = 123;
            this.txtButtonText10.Text = "10";
            this.txtButtonText10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtButtonText10.TextChanged += new System.EventHandler(this.txtButtonText_TextChanged);
            this.txtButtonText10.MouseHover += new System.EventHandler(this.txtButtonText10_MouseHover);
            // 
            // txtButtonText9
            // 
            this.txtButtonText9.Enabled = false;
            this.txtButtonText9.Location = new System.Drawing.Point(224, 292);
            this.txtButtonText9.MaxLength = 5;
            this.txtButtonText9.Name = "txtButtonText9";
            this.txtButtonText9.Size = new System.Drawing.Size(64, 20);
            this.txtButtonText9.TabIndex = 111;
            this.txtButtonText9.Text = "9";
            this.txtButtonText9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtButtonText9.TextChanged += new System.EventHandler(this.txtButtonText_TextChanged);
            this.txtButtonText9.MouseHover += new System.EventHandler(this.txtButtonText9_MouseHover);
            // 
            // txtButtonText8
            // 
            this.txtButtonText8.Enabled = false;
            this.txtButtonText8.Location = new System.Drawing.Point(224, 268);
            this.txtButtonText8.MaxLength = 5;
            this.txtButtonText8.Name = "txtButtonText8";
            this.txtButtonText8.Size = new System.Drawing.Size(64, 20);
            this.txtButtonText8.TabIndex = 99;
            this.txtButtonText8.Text = "8";
            this.txtButtonText8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtButtonText8.TextChanged += new System.EventHandler(this.txtButtonText_TextChanged);
            this.txtButtonText8.MouseHover += new System.EventHandler(this.txtButtonText8_MouseHover);
            // 
            // txtButtonText7
            // 
            this.txtButtonText7.Enabled = false;
            this.txtButtonText7.Location = new System.Drawing.Point(224, 244);
            this.txtButtonText7.MaxLength = 5;
            this.txtButtonText7.Name = "txtButtonText7";
            this.txtButtonText7.Size = new System.Drawing.Size(64, 20);
            this.txtButtonText7.TabIndex = 87;
            this.txtButtonText7.Text = "7";
            this.txtButtonText7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtButtonText7.TextChanged += new System.EventHandler(this.txtButtonText_TextChanged);
            this.txtButtonText7.MouseHover += new System.EventHandler(this.txtButtonText7_MouseHover);
            // 
            // txtButtonText6
            // 
            this.txtButtonText6.Enabled = false;
            this.txtButtonText6.Location = new System.Drawing.Point(224, 220);
            this.txtButtonText6.MaxLength = 5;
            this.txtButtonText6.Name = "txtButtonText6";
            this.txtButtonText6.Size = new System.Drawing.Size(64, 20);
            this.txtButtonText6.TabIndex = 75;
            this.txtButtonText6.Text = "6";
            this.txtButtonText6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtButtonText6.TextChanged += new System.EventHandler(this.txtButtonText_TextChanged);
            this.txtButtonText6.MouseHover += new System.EventHandler(this.txtButtonText6_MouseHover);
            // 
            // txtButtonText5
            // 
            this.txtButtonText5.Enabled = false;
            this.txtButtonText5.Location = new System.Drawing.Point(224, 196);
            this.txtButtonText5.MaxLength = 5;
            this.txtButtonText5.Name = "txtButtonText5";
            this.txtButtonText5.Size = new System.Drawing.Size(64, 20);
            this.txtButtonText5.TabIndex = 63;
            this.txtButtonText5.Text = "5";
            this.txtButtonText5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtButtonText5.TextChanged += new System.EventHandler(this.txtButtonText_TextChanged);
            this.txtButtonText5.MouseHover += new System.EventHandler(this.txtButtonText5_MouseHover);
            // 
            // txtButtonText4
            // 
            this.txtButtonText4.Enabled = false;
            this.txtButtonText4.Location = new System.Drawing.Point(224, 172);
            this.txtButtonText4.MaxLength = 5;
            this.txtButtonText4.Name = "txtButtonText4";
            this.txtButtonText4.Size = new System.Drawing.Size(64, 20);
            this.txtButtonText4.TabIndex = 51;
            this.txtButtonText4.Text = "4";
            this.txtButtonText4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtButtonText4.TextChanged += new System.EventHandler(this.txtButtonText_TextChanged);
            this.txtButtonText4.MouseHover += new System.EventHandler(this.txtButtonText4_MouseHover);
            // 
            // txtButtonText3
            // 
            this.txtButtonText3.Enabled = false;
            this.txtButtonText3.Location = new System.Drawing.Point(224, 148);
            this.txtButtonText3.MaxLength = 5;
            this.txtButtonText3.Name = "txtButtonText3";
            this.txtButtonText3.Size = new System.Drawing.Size(64, 20);
            this.txtButtonText3.TabIndex = 39;
            this.txtButtonText3.Text = "3";
            this.txtButtonText3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtButtonText3.TextChanged += new System.EventHandler(this.txtButtonText_TextChanged);
            this.txtButtonText3.MouseHover += new System.EventHandler(this.txtButtonText3_MouseHover);
            // 
            // txtButtonText2
            // 
            this.txtButtonText2.Enabled = false;
            this.txtButtonText2.Location = new System.Drawing.Point(224, 124);
            this.txtButtonText2.MaxLength = 5;
            this.txtButtonText2.Name = "txtButtonText2";
            this.txtButtonText2.Size = new System.Drawing.Size(64, 20);
            this.txtButtonText2.TabIndex = 27;
            this.txtButtonText2.Text = "2";
            this.txtButtonText2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtButtonText2.TextChanged += new System.EventHandler(this.txtButtonText_TextChanged);
            this.txtButtonText2.MouseHover += new System.EventHandler(this.txtButtonText2_MouseHover);
            // 
            // txtBandButton15
            // 
            this.txtBandButton15.Location = new System.Drawing.Point(72, 436);
            this.txtBandButton15.Name = "txtBandButton15";
            this.txtBandButton15.ReadOnly = true;
            this.txtBandButton15.Size = new System.Drawing.Size(64, 20);
            this.txtBandButton15.TabIndex = 181;
            this.txtBandButton15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBandButton15.Visible = false;
            // 
            // txtBandButton14
            // 
            this.txtBandButton14.Location = new System.Drawing.Point(72, 412);
            this.txtBandButton14.Name = "txtBandButton14";
            this.txtBandButton14.ReadOnly = true;
            this.txtBandButton14.Size = new System.Drawing.Size(64, 20);
            this.txtBandButton14.TabIndex = 169;
            this.txtBandButton14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBandButton14.Visible = false;
            // 
            // txtBandButton13
            // 
            this.txtBandButton13.Location = new System.Drawing.Point(72, 388);
            this.txtBandButton13.Name = "txtBandButton13";
            this.txtBandButton13.ReadOnly = true;
            this.txtBandButton13.Size = new System.Drawing.Size(64, 20);
            this.txtBandButton13.TabIndex = 157;
            this.txtBandButton13.Text = "13";
            this.txtBandButton13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBandButton12
            // 
            this.txtBandButton12.Location = new System.Drawing.Point(72, 364);
            this.txtBandButton12.Name = "txtBandButton12";
            this.txtBandButton12.ReadOnly = true;
            this.txtBandButton12.Size = new System.Drawing.Size(64, 20);
            this.txtBandButton12.TabIndex = 145;
            this.txtBandButton12.Text = "12";
            this.txtBandButton12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBandButton11
            // 
            this.txtBandButton11.Location = new System.Drawing.Point(72, 340);
            this.txtBandButton11.Name = "txtBandButton11";
            this.txtBandButton11.ReadOnly = true;
            this.txtBandButton11.Size = new System.Drawing.Size(64, 20);
            this.txtBandButton11.TabIndex = 133;
            this.txtBandButton11.Text = "11";
            this.txtBandButton11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBandButton10
            // 
            this.txtBandButton10.Location = new System.Drawing.Point(72, 316);
            this.txtBandButton10.Name = "txtBandButton10";
            this.txtBandButton10.ReadOnly = true;
            this.txtBandButton10.Size = new System.Drawing.Size(64, 20);
            this.txtBandButton10.TabIndex = 121;
            this.txtBandButton10.Text = "10";
            this.txtBandButton10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBandButton9
            // 
            this.txtBandButton9.Location = new System.Drawing.Point(72, 292);
            this.txtBandButton9.Name = "txtBandButton9";
            this.txtBandButton9.ReadOnly = true;
            this.txtBandButton9.Size = new System.Drawing.Size(64, 20);
            this.txtBandButton9.TabIndex = 109;
            this.txtBandButton9.Text = "9";
            this.txtBandButton9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBandButton8
            // 
            this.txtBandButton8.Location = new System.Drawing.Point(72, 268);
            this.txtBandButton8.Name = "txtBandButton8";
            this.txtBandButton8.ReadOnly = true;
            this.txtBandButton8.Size = new System.Drawing.Size(64, 20);
            this.txtBandButton8.TabIndex = 97;
            this.txtBandButton8.Text = "8";
            this.txtBandButton8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBandButton7
            // 
            this.txtBandButton7.Location = new System.Drawing.Point(72, 244);
            this.txtBandButton7.Name = "txtBandButton7";
            this.txtBandButton7.ReadOnly = true;
            this.txtBandButton7.Size = new System.Drawing.Size(64, 20);
            this.txtBandButton7.TabIndex = 85;
            this.txtBandButton7.Text = "7";
            this.txtBandButton7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBandButton6
            // 
            this.txtBandButton6.Location = new System.Drawing.Point(72, 220);
            this.txtBandButton6.Name = "txtBandButton6";
            this.txtBandButton6.ReadOnly = true;
            this.txtBandButton6.Size = new System.Drawing.Size(64, 20);
            this.txtBandButton6.TabIndex = 73;
            this.txtBandButton6.Text = "6";
            this.txtBandButton6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBandButton5
            // 
            this.txtBandButton5.Location = new System.Drawing.Point(72, 196);
            this.txtBandButton5.Name = "txtBandButton5";
            this.txtBandButton5.ReadOnly = true;
            this.txtBandButton5.Size = new System.Drawing.Size(64, 20);
            this.txtBandButton5.TabIndex = 61;
            this.txtBandButton5.Text = "5";
            this.txtBandButton5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBandButton4
            // 
            this.txtBandButton4.Location = new System.Drawing.Point(72, 172);
            this.txtBandButton4.Name = "txtBandButton4";
            this.txtBandButton4.ReadOnly = true;
            this.txtBandButton4.Size = new System.Drawing.Size(64, 20);
            this.txtBandButton4.TabIndex = 49;
            this.txtBandButton4.Text = "4";
            this.txtBandButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBandButton3
            // 
            this.txtBandButton3.Location = new System.Drawing.Point(72, 148);
            this.txtBandButton3.Name = "txtBandButton3";
            this.txtBandButton3.ReadOnly = true;
            this.txtBandButton3.Size = new System.Drawing.Size(64, 20);
            this.txtBandButton3.TabIndex = 37;
            this.txtBandButton3.Text = "3";
            this.txtBandButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBandButton2
            // 
            this.txtBandButton2.Location = new System.Drawing.Point(72, 124);
            this.txtBandButton2.Name = "txtBandButton2";
            this.txtBandButton2.ReadOnly = true;
            this.txtBandButton2.Size = new System.Drawing.Size(64, 20);
            this.txtBandButton2.TabIndex = 25;
            this.txtBandButton2.Text = "2";
            this.txtBandButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEnabled
            // 
            this.lblEnabled.Image = null;
            this.lblEnabled.Location = new System.Drawing.Point(16, 24);
            this.lblEnabled.Name = "lblEnabled";
            this.lblEnabled.Size = new System.Drawing.Size(48, 16);
            this.lblEnabled.TabIndex = 51;
            this.lblEnabled.Text = "Enabled";
            // 
            // chkEnable15
            // 
            this.chkEnable15.Image = null;
            this.chkEnable15.Location = new System.Drawing.Point(32, 436);
            this.chkEnable15.Name = "chkEnable15";
            this.chkEnable15.Size = new System.Drawing.Size(16, 16);
            this.chkEnable15.TabIndex = 180;
            this.chkEnable15.CheckedChanged += new System.EventHandler(this.chkEnable15_CheckedChanged);
            // 
            // chkEnable14
            // 
            this.chkEnable14.Image = null;
            this.chkEnable14.Location = new System.Drawing.Point(32, 412);
            this.chkEnable14.Name = "chkEnable14";
            this.chkEnable14.Size = new System.Drawing.Size(16, 16);
            this.chkEnable14.TabIndex = 168;
            this.chkEnable14.CheckedChanged += new System.EventHandler(this.chkEnable14_CheckedChanged);
            // 
            // chkEnable13
            // 
            this.chkEnable13.Image = null;
            this.chkEnable13.Location = new System.Drawing.Point(32, 388);
            this.chkEnable13.Name = "chkEnable13";
            this.chkEnable13.Size = new System.Drawing.Size(16, 16);
            this.chkEnable13.TabIndex = 156;
            this.chkEnable13.CheckedChanged += new System.EventHandler(this.chkEnable13_CheckedChanged);
            // 
            // chkEnable12
            // 
            this.chkEnable12.Image = null;
            this.chkEnable12.Location = new System.Drawing.Point(32, 364);
            this.chkEnable12.Name = "chkEnable12";
            this.chkEnable12.Size = new System.Drawing.Size(16, 16);
            this.chkEnable12.TabIndex = 144;
            this.chkEnable12.CheckedChanged += new System.EventHandler(this.chkEnable12_CheckedChanged);
            // 
            // chkEnable11
            // 
            this.chkEnable11.Image = null;
            this.chkEnable11.Location = new System.Drawing.Point(32, 340);
            this.chkEnable11.Name = "chkEnable11";
            this.chkEnable11.Size = new System.Drawing.Size(16, 16);
            this.chkEnable11.TabIndex = 132;
            this.chkEnable11.CheckedChanged += new System.EventHandler(this.chkEnable11_CheckedChanged);
            // 
            // chkEnable10
            // 
            this.chkEnable10.Image = null;
            this.chkEnable10.Location = new System.Drawing.Point(32, 316);
            this.chkEnable10.Name = "chkEnable10";
            this.chkEnable10.Size = new System.Drawing.Size(16, 16);
            this.chkEnable10.TabIndex = 120;
            this.chkEnable10.CheckedChanged += new System.EventHandler(this.chkEnable10_CheckedChanged);
            // 
            // chkEnable9
            // 
            this.chkEnable9.Image = null;
            this.chkEnable9.Location = new System.Drawing.Point(32, 292);
            this.chkEnable9.Name = "chkEnable9";
            this.chkEnable9.Size = new System.Drawing.Size(16, 16);
            this.chkEnable9.TabIndex = 108;
            this.chkEnable9.CheckedChanged += new System.EventHandler(this.chkEnable9_CheckedChanged);
            // 
            // chkEnable8
            // 
            this.chkEnable8.Image = null;
            this.chkEnable8.Location = new System.Drawing.Point(32, 268);
            this.chkEnable8.Name = "chkEnable8";
            this.chkEnable8.Size = new System.Drawing.Size(16, 16);
            this.chkEnable8.TabIndex = 96;
            this.chkEnable8.CheckedChanged += new System.EventHandler(this.chkEnable8_CheckedChanged);
            // 
            // chkEnable7
            // 
            this.chkEnable7.Image = null;
            this.chkEnable7.Location = new System.Drawing.Point(32, 244);
            this.chkEnable7.Name = "chkEnable7";
            this.chkEnable7.Size = new System.Drawing.Size(16, 16);
            this.chkEnable7.TabIndex = 84;
            this.chkEnable7.CheckedChanged += new System.EventHandler(this.chkEnable7_CheckedChanged);
            // 
            // chkEnable6
            // 
            this.chkEnable6.Image = null;
            this.chkEnable6.Location = new System.Drawing.Point(32, 220);
            this.chkEnable6.Name = "chkEnable6";
            this.chkEnable6.Size = new System.Drawing.Size(16, 16);
            this.chkEnable6.TabIndex = 72;
            this.chkEnable6.CheckedChanged += new System.EventHandler(this.chkEnable6_CheckedChanged);
            // 
            // chkEnable5
            // 
            this.chkEnable5.Image = null;
            this.chkEnable5.Location = new System.Drawing.Point(32, 196);
            this.chkEnable5.Name = "chkEnable5";
            this.chkEnable5.Size = new System.Drawing.Size(16, 16);
            this.chkEnable5.TabIndex = 60;
            this.chkEnable5.CheckedChanged += new System.EventHandler(this.chkEnable5_CheckedChanged);
            // 
            // chkEnable4
            // 
            this.chkEnable4.Image = null;
            this.chkEnable4.Location = new System.Drawing.Point(32, 172);
            this.chkEnable4.Name = "chkEnable4";
            this.chkEnable4.Size = new System.Drawing.Size(16, 16);
            this.chkEnable4.TabIndex = 48;
            this.chkEnable4.CheckedChanged += new System.EventHandler(this.chkEnable4_CheckedChanged);
            // 
            // chkEnable3
            // 
            this.chkEnable3.Image = null;
            this.chkEnable3.Location = new System.Drawing.Point(32, 148);
            this.chkEnable3.Name = "chkEnable3";
            this.chkEnable3.Size = new System.Drawing.Size(16, 16);
            this.chkEnable3.TabIndex = 36;
            this.chkEnable3.CheckedChanged += new System.EventHandler(this.chkEnable3_CheckedChanged);
            // 
            // chkEnable2
            // 
            this.chkEnable2.Image = null;
            this.chkEnable2.Location = new System.Drawing.Point(32, 124);
            this.chkEnable2.Name = "chkEnable2";
            this.chkEnable2.Size = new System.Drawing.Size(16, 16);
            this.chkEnable2.TabIndex = 24;
            this.chkEnable2.CheckedChanged += new System.EventHandler(this.chkEnable2_CheckedChanged);
            // 
            // udUCBAddr15
            // 
            this.udUCBAddr15.Enabled = false;
            this.udUCBAddr15.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udUCBAddr15.Location = new System.Drawing.Point(160, 436);
            this.udUCBAddr15.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.udUCBAddr15.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udUCBAddr15.Name = "udUCBAddr15";
            this.udUCBAddr15.Size = new System.Drawing.Size(40, 20);
            this.udUCBAddr15.TabIndex = 182;
            this.udUCBAddr15.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // udUCBAddr14
            // 
            this.udUCBAddr14.Enabled = false;
            this.udUCBAddr14.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udUCBAddr14.Location = new System.Drawing.Point(160, 412);
            this.udUCBAddr14.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.udUCBAddr14.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udUCBAddr14.Name = "udUCBAddr14";
            this.udUCBAddr14.Size = new System.Drawing.Size(40, 20);
            this.udUCBAddr14.TabIndex = 170;
            this.udUCBAddr14.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // udUCBAddr13
            // 
            this.udUCBAddr13.Enabled = false;
            this.udUCBAddr13.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udUCBAddr13.Location = new System.Drawing.Point(160, 388);
            this.udUCBAddr13.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.udUCBAddr13.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udUCBAddr13.Name = "udUCBAddr13";
            this.udUCBAddr13.Size = new System.Drawing.Size(40, 20);
            this.udUCBAddr13.TabIndex = 158;
            this.udUCBAddr13.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            // 
            // udUCBAddr12
            // 
            this.udUCBAddr12.Enabled = false;
            this.udUCBAddr12.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udUCBAddr12.Location = new System.Drawing.Point(160, 364);
            this.udUCBAddr12.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.udUCBAddr12.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udUCBAddr12.Name = "udUCBAddr12";
            this.udUCBAddr12.Size = new System.Drawing.Size(40, 20);
            this.udUCBAddr12.TabIndex = 146;
            this.udUCBAddr12.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // udUCBAddr11
            // 
            this.udUCBAddr11.Enabled = false;
            this.udUCBAddr11.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udUCBAddr11.Location = new System.Drawing.Point(160, 340);
            this.udUCBAddr11.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.udUCBAddr11.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udUCBAddr11.Name = "udUCBAddr11";
            this.udUCBAddr11.Size = new System.Drawing.Size(40, 20);
            this.udUCBAddr11.TabIndex = 134;
            this.udUCBAddr11.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // udUCBAddr10
            // 
            this.udUCBAddr10.Enabled = false;
            this.udUCBAddr10.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udUCBAddr10.Location = new System.Drawing.Point(160, 316);
            this.udUCBAddr10.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.udUCBAddr10.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udUCBAddr10.Name = "udUCBAddr10";
            this.udUCBAddr10.Size = new System.Drawing.Size(40, 20);
            this.udUCBAddr10.TabIndex = 122;
            this.udUCBAddr10.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // udUCBAddr9
            // 
            this.udUCBAddr9.Enabled = false;
            this.udUCBAddr9.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udUCBAddr9.Location = new System.Drawing.Point(160, 292);
            this.udUCBAddr9.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.udUCBAddr9.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udUCBAddr9.Name = "udUCBAddr9";
            this.udUCBAddr9.Size = new System.Drawing.Size(40, 20);
            this.udUCBAddr9.TabIndex = 110;
            this.udUCBAddr9.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // udUCBAddr8
            // 
            this.udUCBAddr8.Enabled = false;
            this.udUCBAddr8.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udUCBAddr8.Location = new System.Drawing.Point(160, 268);
            this.udUCBAddr8.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.udUCBAddr8.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udUCBAddr8.Name = "udUCBAddr8";
            this.udUCBAddr8.Size = new System.Drawing.Size(40, 20);
            this.udUCBAddr8.TabIndex = 98;
            this.udUCBAddr8.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // udUCBAddr7
            // 
            this.udUCBAddr7.Enabled = false;
            this.udUCBAddr7.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udUCBAddr7.Location = new System.Drawing.Point(160, 244);
            this.udUCBAddr7.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.udUCBAddr7.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udUCBAddr7.Name = "udUCBAddr7";
            this.udUCBAddr7.Size = new System.Drawing.Size(40, 20);
            this.udUCBAddr7.TabIndex = 86;
            this.udUCBAddr7.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // udUCBAddr6
            // 
            this.udUCBAddr6.Enabled = false;
            this.udUCBAddr6.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udUCBAddr6.Location = new System.Drawing.Point(160, 220);
            this.udUCBAddr6.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.udUCBAddr6.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udUCBAddr6.Name = "udUCBAddr6";
            this.udUCBAddr6.Size = new System.Drawing.Size(40, 20);
            this.udUCBAddr6.TabIndex = 74;
            this.udUCBAddr6.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // udUCBAddr5
            // 
            this.udUCBAddr5.Enabled = false;
            this.udUCBAddr5.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udUCBAddr5.Location = new System.Drawing.Point(160, 196);
            this.udUCBAddr5.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.udUCBAddr5.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udUCBAddr5.Name = "udUCBAddr5";
            this.udUCBAddr5.Size = new System.Drawing.Size(40, 20);
            this.udUCBAddr5.TabIndex = 62;
            this.udUCBAddr5.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // udUCBAddr4
            // 
            this.udUCBAddr4.Enabled = false;
            this.udUCBAddr4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udUCBAddr4.Location = new System.Drawing.Point(160, 172);
            this.udUCBAddr4.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.udUCBAddr4.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udUCBAddr4.Name = "udUCBAddr4";
            this.udUCBAddr4.Size = new System.Drawing.Size(40, 20);
            this.udUCBAddr4.TabIndex = 50;
            this.udUCBAddr4.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // udUCBAddr3
            // 
            this.udUCBAddr3.Enabled = false;
            this.udUCBAddr3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udUCBAddr3.Location = new System.Drawing.Point(160, 148);
            this.udUCBAddr3.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.udUCBAddr3.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udUCBAddr3.Name = "udUCBAddr3";
            this.udUCBAddr3.Size = new System.Drawing.Size(40, 20);
            this.udUCBAddr3.TabIndex = 38;
            this.udUCBAddr3.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // udUCBAddr2
            // 
            this.udUCBAddr2.Enabled = false;
            this.udUCBAddr2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udUCBAddr2.Location = new System.Drawing.Point(160, 124);
            this.udUCBAddr2.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.udUCBAddr2.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.udUCBAddr2.Name = "udUCBAddr2";
            this.udUCBAddr2.Size = new System.Drawing.Size(40, 20);
            this.udUCBAddr2.TabIndex = 26;
            this.udUCBAddr2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblButtonText
            // 
            this.lblButtonText.Image = null;
            this.lblButtonText.Location = new System.Drawing.Point(224, 24);
            this.lblButtonText.Name = "lblButtonText";
            this.lblButtonText.Size = new System.Drawing.Size(72, 16);
            this.lblButtonText.TabIndex = 2;
            this.lblButtonText.Text = "Button Text";
            // 
            // lblBandButton
            // 
            this.lblBandButton.Image = null;
            this.lblBandButton.Location = new System.Drawing.Point(72, 24);
            this.lblBandButton.Name = "lblBandButton";
            this.lblBandButton.Size = new System.Drawing.Size(72, 16);
            this.lblBandButton.TabIndex = 0;
            this.lblBandButton.Text = "Band Button";
            // 
            // XVTRForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1115, 486);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.chkFlexWire);
            this.Controls.Add(this.chkAlwaysOnTop1);
            this.Controls.Add(this.lblPAEnable);
            this.Controls.Add(this.lblIFGain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkUseXVTRTUNPWR);
            this.Controls.Add(this.udRXGain15);
            this.Controls.Add(this.udRXGain14);
            this.Controls.Add(this.udRXGain13);
            this.Controls.Add(this.udRXGain12);
            this.Controls.Add(this.udRXGain11);
            this.Controls.Add(this.udRXGain10);
            this.Controls.Add(this.udRXGain9);
            this.Controls.Add(this.udRXGain8);
            this.Controls.Add(this.udRXGain7);
            this.Controls.Add(this.udRXGain6);
            this.Controls.Add(this.udRXGain5);
            this.Controls.Add(this.udRXGain4);
            this.Controls.Add(this.udRXGain3);
            this.Controls.Add(this.udRXGain2);
            this.Controls.Add(this.lblRXGain);
            this.Controls.Add(this.chkXVTRRF15);
            this.Controls.Add(this.chkXVTRRF14);
            this.Controls.Add(this.chkXVTRRF13);
            this.Controls.Add(this.chkXVTRRF12);
            this.Controls.Add(this.chkXVTRRF11);
            this.Controls.Add(this.chkXVTRRF10);
            this.Controls.Add(this.chkXVTRRF9);
            this.Controls.Add(this.chkXVTRRF8);
            this.Controls.Add(this.chkXVTRRF7);
            this.Controls.Add(this.chkXVTRRF6);
            this.Controls.Add(this.chkXVTRRF5);
            this.Controls.Add(this.chkXVTRRF4);
            this.Controls.Add(this.chkXVTRRF3);
            this.Controls.Add(this.chkXVTRRF2);
            this.Controls.Add(this.lblXVTRRF);
            this.Controls.Add(this.udPower15);
            this.Controls.Add(this.udPower14);
            this.Controls.Add(this.udPower13);
            this.Controls.Add(this.udPower12);
            this.Controls.Add(this.udPower11);
            this.Controls.Add(this.udPower10);
            this.Controls.Add(this.udPower9);
            this.Controls.Add(this.udPower8);
            this.Controls.Add(this.udPower7);
            this.Controls.Add(this.udPower6);
            this.Controls.Add(this.udPower5);
            this.Controls.Add(this.udPower4);
            this.Controls.Add(this.udPower3);
            this.Controls.Add(this.udPower2);
            this.Controls.Add(this.lblPower);
            this.Controls.Add(this.udLOError15);
            this.Controls.Add(this.udLOError14);
            this.Controls.Add(this.udLOError13);
            this.Controls.Add(this.udLOError12);
            this.Controls.Add(this.udLOError11);
            this.Controls.Add(this.udLOError10);
            this.Controls.Add(this.udLOError9);
            this.Controls.Add(this.udLOError8);
            this.Controls.Add(this.udLOError7);
            this.Controls.Add(this.udLOError6);
            this.Controls.Add(this.udLOError5);
            this.Controls.Add(this.udLOError4);
            this.Controls.Add(this.udLOError3);
            this.Controls.Add(this.udLOError2);
            this.Controls.Add(this.lblLOError);
            this.Controls.Add(this.chkRXOnly15);
            this.Controls.Add(this.chkRXOnly14);
            this.Controls.Add(this.chkRXOnly13);
            this.Controls.Add(this.chkRXOnly12);
            this.Controls.Add(this.chkRXOnly11);
            this.Controls.Add(this.chkRXOnly10);
            this.Controls.Add(this.chkRXOnly9);
            this.Controls.Add(this.chkRXOnly8);
            this.Controls.Add(this.chkRXOnly7);
            this.Controls.Add(this.chkRXOnly6);
            this.Controls.Add(this.chkRXOnly5);
            this.Controls.Add(this.chkRXOnly4);
            this.Controls.Add(this.chkRXOnly3);
            this.Controls.Add(this.chkRXOnly2);
            this.Controls.Add(this.lblRXOnly);
            this.Controls.Add(this.udFreqEnd15);
            this.Controls.Add(this.udFreqEnd14);
            this.Controls.Add(this.udFreqEnd13);
            this.Controls.Add(this.udFreqEnd12);
            this.Controls.Add(this.udFreqEnd11);
            this.Controls.Add(this.udFreqEnd10);
            this.Controls.Add(this.udFreqEnd9);
            this.Controls.Add(this.udFreqEnd8);
            this.Controls.Add(this.udFreqEnd7);
            this.Controls.Add(this.udFreqEnd6);
            this.Controls.Add(this.udFreqEnd5);
            this.Controls.Add(this.udFreqEnd4);
            this.Controls.Add(this.udFreqEnd3);
            this.Controls.Add(this.udFreqEnd2);
            this.Controls.Add(this.lblFreqEnd);
            this.Controls.Add(this.udFreqBegin15);
            this.Controls.Add(this.udFreqBegin14);
            this.Controls.Add(this.udFreqBegin13);
            this.Controls.Add(this.udFreqBegin12);
            this.Controls.Add(this.udFreqBegin11);
            this.Controls.Add(this.udFreqBegin10);
            this.Controls.Add(this.udFreqBegin9);
            this.Controls.Add(this.udFreqBegin8);
            this.Controls.Add(this.udFreqBegin7);
            this.Controls.Add(this.udFreqBegin6);
            this.Controls.Add(this.udFreqBegin5);
            this.Controls.Add(this.udFreqBegin4);
            this.Controls.Add(this.udFreqBegin3);
            this.Controls.Add(this.udFreqBegin2);
            this.Controls.Add(this.lblFreqBegin);
            this.Controls.Add(this.udLOOffset15);
            this.Controls.Add(this.udLOOffset14);
            this.Controls.Add(this.udLOOffset13);
            this.Controls.Add(this.udLOOffset12);
            this.Controls.Add(this.udLOOffset11);
            this.Controls.Add(this.udLOOffset10);
            this.Controls.Add(this.udLOOffset9);
            this.Controls.Add(this.udLOOffset8);
            this.Controls.Add(this.udLOOffset7);
            this.Controls.Add(this.udLOOffset6);
            this.Controls.Add(this.udLOOffset5);
            this.Controls.Add(this.udLOOffset4);
            this.Controls.Add(this.udLOOffset3);
            this.Controls.Add(this.udLOOffset2);
            this.Controls.Add(this.lblLOOffset);
            this.Controls.Add(this.txtButtonText15);
            this.Controls.Add(this.txtButtonText14);
            this.Controls.Add(this.txtButtonText13);
            this.Controls.Add(this.txtButtonText12);
            this.Controls.Add(this.txtButtonText11);
            this.Controls.Add(this.txtButtonText10);
            this.Controls.Add(this.txtButtonText9);
            this.Controls.Add(this.txtButtonText8);
            this.Controls.Add(this.txtButtonText7);
            this.Controls.Add(this.txtButtonText6);
            this.Controls.Add(this.txtButtonText5);
            this.Controls.Add(this.txtButtonText4);
            this.Controls.Add(this.txtButtonText3);
            this.Controls.Add(this.txtButtonText2);
            this.Controls.Add(this.txtBandButton15);
            this.Controls.Add(this.txtBandButton14);
            this.Controls.Add(this.txtBandButton13);
            this.Controls.Add(this.txtBandButton12);
            this.Controls.Add(this.txtBandButton11);
            this.Controls.Add(this.txtBandButton10);
            this.Controls.Add(this.txtBandButton9);
            this.Controls.Add(this.txtBandButton8);
            this.Controls.Add(this.txtBandButton7);
            this.Controls.Add(this.txtBandButton6);
            this.Controls.Add(this.txtBandButton5);
            this.Controls.Add(this.txtBandButton4);
            this.Controls.Add(this.txtBandButton3);
            this.Controls.Add(this.txtBandButton2);
            this.Controls.Add(this.lblEnabled);
            this.Controls.Add(this.chkEnable15);
            this.Controls.Add(this.chkEnable14);
            this.Controls.Add(this.chkEnable13);
            this.Controls.Add(this.chkEnable12);
            this.Controls.Add(this.chkEnable11);
            this.Controls.Add(this.chkEnable10);
            this.Controls.Add(this.chkEnable9);
            this.Controls.Add(this.chkEnable8);
            this.Controls.Add(this.chkEnable7);
            this.Controls.Add(this.chkEnable6);
            this.Controls.Add(this.chkEnable5);
            this.Controls.Add(this.chkEnable4);
            this.Controls.Add(this.chkEnable3);
            this.Controls.Add(this.chkEnable2);
            this.Controls.Add(this.udUCBAddr15);
            this.Controls.Add(this.udUCBAddr14);
            this.Controls.Add(this.udUCBAddr13);
            this.Controls.Add(this.udUCBAddr12);
            this.Controls.Add(this.udUCBAddr11);
            this.Controls.Add(this.udUCBAddr10);
            this.Controls.Add(this.udUCBAddr9);
            this.Controls.Add(this.udUCBAddr8);
            this.Controls.Add(this.udUCBAddr7);
            this.Controls.Add(this.udUCBAddr6);
            this.Controls.Add(this.udUCBAddr5);
            this.Controls.Add(this.udUCBAddr4);
            this.Controls.Add(this.udUCBAddr3);
            this.Controls.Add(this.udUCBAddr2);
            this.Controls.Add(this.lblButtonText);
            this.Controls.Add(this.lblUCBAddress);
            this.Controls.Add(this.lblBandButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XVTRForm";
            this.Text = "XVTR Setup";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.XVTRForm_Closing);
            this.MouseEnter += new System.EventHandler(this.XVTRForm_MouseEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udRXGain1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRXGain0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPower1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPower0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqEnd1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqEnd0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqBegin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqBegin0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOOffset1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOOffset0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udUCBAddr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udUCBAddr0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOError0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOError1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRXGain15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRXGain14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRXGain13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRXGain12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRXGain11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRXGain10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRXGain9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRXGain8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRXGain7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRXGain6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRXGain5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRXGain4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRXGain3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRXGain2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPower15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPower14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPower13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPower12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPower11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPower10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPower9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPower8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPower7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPower6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPower5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPower4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPower3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPower2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOError15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOError14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOError13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOError12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOError11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOError10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOError9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOError8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOError7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOError6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOError5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOError4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOError3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOError2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqEnd15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqEnd14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqEnd13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqEnd12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqEnd11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqEnd10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqEnd9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqEnd8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqEnd7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqEnd6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqEnd5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqEnd4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqEnd3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqEnd2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqBegin15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqBegin14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqBegin13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqBegin12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqBegin11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqBegin10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqBegin9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqBegin8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqBegin7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqBegin6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqBegin5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqBegin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqBegin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreqBegin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOOffset15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOOffset14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOOffset13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOOffset12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOOffset11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOOffset10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOOffset9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOOffset8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOOffset7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOOffset6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOOffset5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOOffset4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOOffset3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLOOffset2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udUCBAddr15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udUCBAddr14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udUCBAddr13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udUCBAddr12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udUCBAddr11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udUCBAddr10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udUCBAddr9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udUCBAddr8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udUCBAddr7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udUCBAddr6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udUCBAddr5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udUCBAddr4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udUCBAddr3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udUCBAddr2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

     

        private System.Windows.Forms.NumericUpDownTS[] ucb_addr;
        private System.Windows.Forms.NumericUpDownTS[] begin;
        private System.Windows.Forms.NumericUpDownTS[] end;
        private System.Windows.Forms.CheckBoxTS[] enabled;
        private System.Windows.Forms.NumericUpDownTS[] lo_offset;
        private System.Windows.Forms.NumericUpDownTS[] lo_error;
        private System.Windows.Forms.NumericUpDownTS[] rx_gain;
        private System.Windows.Forms.CheckBoxTS[] rx_only;
        private System.Windows.Forms.NumericUpDownTS[] power;
        private System.Windows.Forms.CheckBoxTS[] xvtr_rf;

        private System.Windows.Forms.TextBoxTS txtBandButton0;
        private System.Windows.Forms.TextBoxTS txtBandButton1;
        private System.Windows.Forms.TextBoxTS txtBandButton2;
        private System.Windows.Forms.TextBoxTS txtBandButton3;
        private System.Windows.Forms.TextBoxTS txtBandButton4;
        private System.Windows.Forms.TextBoxTS txtBandButton5;
        private System.Windows.Forms.TextBoxTS txtBandButton6;
        private System.Windows.Forms.TextBoxTS txtBandButton7;
        private System.Windows.Forms.TextBoxTS txtBandButton8;
        private System.Windows.Forms.TextBoxTS txtBandButton9;
        private System.Windows.Forms.TextBoxTS txtBandButton10;
        private System.Windows.Forms.TextBoxTS txtBandButton11;
        private System.Windows.Forms.TextBoxTS txtBandButton12;
        private System.Windows.Forms.TextBoxTS txtBandButton13;
        private System.Windows.Forms.TextBoxTS txtBandButton14;
        private System.Windows.Forms.TextBoxTS txtBandButton15;
        private System.Windows.Forms.NumericUpDownTS udUCBAddr0;//
        private System.Windows.Forms.NumericUpDownTS udUCBAddr1;//
        private System.Windows.Forms.NumericUpDownTS udUCBAddr2;
        private System.Windows.Forms.NumericUpDownTS udUCBAddr3;
        private System.Windows.Forms.NumericUpDownTS udUCBAddr4;
        private System.Windows.Forms.NumericUpDownTS udUCBAddr5;
        private System.Windows.Forms.NumericUpDownTS udUCBAddr6;
        private System.Windows.Forms.NumericUpDownTS udUCBAddr7;
        private System.Windows.Forms.NumericUpDownTS udUCBAddr8;
        private System.Windows.Forms.NumericUpDownTS udUCBAddr9;
        private System.Windows.Forms.NumericUpDownTS udUCBAddr10;
        private System.Windows.Forms.NumericUpDownTS udUCBAddr11;
        private System.Windows.Forms.NumericUpDownTS udUCBAddr12;
        private System.Windows.Forms.NumericUpDownTS udUCBAddr13;
        private System.Windows.Forms.NumericUpDownTS udUCBAddr14;
        private System.Windows.Forms.NumericUpDownTS udUCBAddr15;
        private System.Windows.Forms.CheckBoxTS chkEnable0;//
        private System.Windows.Forms.CheckBoxTS chkEnable1;//
        private System.Windows.Forms.CheckBoxTS chkEnable2;
        private System.Windows.Forms.CheckBoxTS chkEnable3;
        private System.Windows.Forms.CheckBoxTS chkEnable4;
        private System.Windows.Forms.CheckBoxTS chkEnable5;
        private System.Windows.Forms.CheckBoxTS chkEnable6;
        private System.Windows.Forms.CheckBoxTS chkEnable7;
        private System.Windows.Forms.CheckBoxTS chkEnable8;
        private System.Windows.Forms.CheckBoxTS chkEnable9;
        private System.Windows.Forms.CheckBoxTS chkEnable10;
        private System.Windows.Forms.CheckBoxTS chkEnable11;
        private System.Windows.Forms.CheckBoxTS chkEnable12;
        private System.Windows.Forms.CheckBoxTS chkEnable13;
        private System.Windows.Forms.CheckBoxTS chkEnable14;
        private System.Windows.Forms.CheckBoxTS chkEnable15;
        private System.Windows.Forms.LabelTS lblBandButton;
        private System.Windows.Forms.LabelTS lblUCBAddress;
        private System.Windows.Forms.LabelTS lblButtonText;
        private System.Windows.Forms.LabelTS lblEnabled;
        private System.Windows.Forms.TextBoxTS txtButtonText15;
        private System.Windows.Forms.TextBoxTS txtButtonText14;
        private System.Windows.Forms.TextBoxTS txtButtonText13;
        private System.Windows.Forms.TextBoxTS txtButtonText12;
        private System.Windows.Forms.TextBoxTS txtButtonText11;
        private System.Windows.Forms.TextBoxTS txtButtonText10;
        private System.Windows.Forms.TextBoxTS txtButtonText9;
        private System.Windows.Forms.TextBoxTS txtButtonText8;
        private System.Windows.Forms.TextBoxTS txtButtonText7;
        private System.Windows.Forms.TextBoxTS txtButtonText6;
        private System.Windows.Forms.TextBoxTS txtButtonText5;
        private System.Windows.Forms.TextBoxTS txtButtonText4;
        private System.Windows.Forms.TextBoxTS txtButtonText3;
        private System.Windows.Forms.TextBoxTS txtButtonText2;
        private System.Windows.Forms.TextBoxTS txtButtonText1;//
        private System.Windows.Forms.TextBoxTS txtButtonText0;//
        private System.Windows.Forms.LabelTS lblLOOffset;
        private System.Windows.Forms.NumericUpDownTS udLOOffset15;
        private System.Windows.Forms.NumericUpDownTS udLOOffset14;
        private System.Windows.Forms.NumericUpDownTS udLOOffset13;
        private System.Windows.Forms.NumericUpDownTS udLOOffset12;
        private System.Windows.Forms.NumericUpDownTS udLOOffset11;
        private System.Windows.Forms.NumericUpDownTS udLOOffset10;
        private System.Windows.Forms.NumericUpDownTS udLOOffset9;
        private System.Windows.Forms.NumericUpDownTS udLOOffset8;
        private System.Windows.Forms.NumericUpDownTS udLOOffset7;
        private System.Windows.Forms.NumericUpDownTS udLOOffset6;
        private System.Windows.Forms.NumericUpDownTS udLOOffset5;
        private System.Windows.Forms.NumericUpDownTS udLOOffset4;
        private System.Windows.Forms.NumericUpDownTS udLOOffset3;
        private System.Windows.Forms.NumericUpDownTS udLOOffset2;
        private System.Windows.Forms.NumericUpDownTS udLOOffset1;//
        private System.Windows.Forms.NumericUpDownTS udLOOffset0;//
        private System.Windows.Forms.NumericUpDownTS udFreqBegin15;
        private System.Windows.Forms.NumericUpDownTS udFreqBegin14;
        private System.Windows.Forms.NumericUpDownTS udFreqBegin13;
        private System.Windows.Forms.NumericUpDownTS udFreqBegin12;
        private System.Windows.Forms.NumericUpDownTS udFreqBegin11;
        private System.Windows.Forms.NumericUpDownTS udFreqBegin10;
        private System.Windows.Forms.NumericUpDownTS udFreqBegin9;
        private System.Windows.Forms.NumericUpDownTS udFreqBegin8;
        private System.Windows.Forms.NumericUpDownTS udFreqBegin7;
        private System.Windows.Forms.NumericUpDownTS udFreqBegin6;
        private System.Windows.Forms.NumericUpDownTS udFreqBegin5;
        private System.Windows.Forms.NumericUpDownTS udFreqBegin4;
        private System.Windows.Forms.NumericUpDownTS udFreqBegin3;
        private System.Windows.Forms.NumericUpDownTS udFreqBegin2;
        private System.Windows.Forms.NumericUpDownTS udFreqBegin1;//
        private System.Windows.Forms.NumericUpDownTS udFreqBegin0;//
        private System.Windows.Forms.LabelTS lblFreqBegin;
        private System.Windows.Forms.LabelTS lblFreqEnd;
        private System.Windows.Forms.NumericUpDownTS udFreqEnd15;
        private System.Windows.Forms.NumericUpDownTS udFreqEnd14;
        private System.Windows.Forms.NumericUpDownTS udFreqEnd13;
        private System.Windows.Forms.NumericUpDownTS udFreqEnd12;
        private System.Windows.Forms.NumericUpDownTS udFreqEnd11;
        private System.Windows.Forms.NumericUpDownTS udFreqEnd10;
        private System.Windows.Forms.NumericUpDownTS udFreqEnd9;
        private System.Windows.Forms.NumericUpDownTS udFreqEnd8;
        private System.Windows.Forms.NumericUpDownTS udFreqEnd7;
        private System.Windows.Forms.NumericUpDownTS udFreqEnd6;
        private System.Windows.Forms.NumericUpDownTS udFreqEnd5;
        private System.Windows.Forms.NumericUpDownTS udFreqEnd4;
        private System.Windows.Forms.NumericUpDownTS udFreqEnd3;
        private System.Windows.Forms.NumericUpDownTS udFreqEnd2;
        private System.Windows.Forms.NumericUpDownTS udFreqEnd1;//
        private System.Windows.Forms.NumericUpDownTS udFreqEnd0;//
        private System.Windows.Forms.LabelTS lblRXOnly;
        private System.Windows.Forms.CheckBoxTS chkRXOnly15;
        private System.Windows.Forms.CheckBoxTS chkRXOnly14;
        private System.Windows.Forms.CheckBoxTS chkRXOnly13;
        private System.Windows.Forms.CheckBoxTS chkRXOnly12;
        private System.Windows.Forms.CheckBoxTS chkRXOnly11;
        private System.Windows.Forms.CheckBoxTS chkRXOnly10;
        private System.Windows.Forms.CheckBoxTS chkRXOnly9;
        private System.Windows.Forms.CheckBoxTS chkRXOnly8;
        private System.Windows.Forms.CheckBoxTS chkRXOnly7;
        private System.Windows.Forms.CheckBoxTS chkRXOnly6;
        private System.Windows.Forms.CheckBoxTS chkRXOnly5;
        private System.Windows.Forms.CheckBoxTS chkRXOnly4;
        private System.Windows.Forms.CheckBoxTS chkRXOnly3;
        private System.Windows.Forms.CheckBoxTS chkRXOnly2;
        private System.Windows.Forms.CheckBoxTS chkRXOnly1;//
        public System.Windows.Forms.CheckBoxTS chkRXOnly0;
        private System.Windows.Forms.NumericUpDownTS udLOError15;
        private System.Windows.Forms.NumericUpDownTS udLOError14;
        private System.Windows.Forms.NumericUpDownTS udLOError13;
        private System.Windows.Forms.NumericUpDownTS udLOError12;
        private System.Windows.Forms.NumericUpDownTS udLOError11;
        private System.Windows.Forms.NumericUpDownTS udLOError10;
        private System.Windows.Forms.NumericUpDownTS udLOError9;
        private System.Windows.Forms.NumericUpDownTS udLOError8;
        private System.Windows.Forms.NumericUpDownTS udLOError7;
        private System.Windows.Forms.NumericUpDownTS udLOError6;
        private System.Windows.Forms.NumericUpDownTS udLOError5;
        private System.Windows.Forms.NumericUpDownTS udLOError4;
        private System.Windows.Forms.NumericUpDownTS udLOError3;
        private System.Windows.Forms.NumericUpDownTS udLOError2;
        private System.Windows.Forms.NumericUpDownTS udLOError1;//
        private System.Windows.Forms.NumericUpDownTS udLOError0;//
        private System.Windows.Forms.LabelTS lblLOError;
        private System.Windows.Forms.NumericUpDownTS udPower15;
        private System.Windows.Forms.NumericUpDownTS udPower14;
        private System.Windows.Forms.NumericUpDownTS udPower13;
        private System.Windows.Forms.NumericUpDownTS udPower12;
        private System.Windows.Forms.NumericUpDownTS udPower11;
        private System.Windows.Forms.NumericUpDownTS udPower10;
        private System.Windows.Forms.NumericUpDownTS udPower9;
        private System.Windows.Forms.NumericUpDownTS udPower8;
        private System.Windows.Forms.NumericUpDownTS udPower7;
        private System.Windows.Forms.NumericUpDownTS udPower6;
        private System.Windows.Forms.NumericUpDownTS udPower5;
        private System.Windows.Forms.NumericUpDownTS udPower4;
        private System.Windows.Forms.NumericUpDownTS udPower3;
        private System.Windows.Forms.NumericUpDownTS udPower2;
        private System.Windows.Forms.NumericUpDownTS udPower1;//
        private System.Windows.Forms.NumericUpDownTS udPower0;//
        private System.Windows.Forms.LabelTS lblPower;
        private System.Windows.Forms.CheckBoxTS chkXVTRRF15;
        private System.Windows.Forms.CheckBoxTS chkXVTRRF14;
        private System.Windows.Forms.CheckBoxTS chkXVTRRF13;
        private System.Windows.Forms.CheckBoxTS chkXVTRRF12;
        private System.Windows.Forms.CheckBoxTS chkXVTRRF11;
        private System.Windows.Forms.CheckBoxTS chkXVTRRF10;
        private System.Windows.Forms.CheckBoxTS chkXVTRRF9;
        private System.Windows.Forms.CheckBoxTS chkXVTRRF8;
        private System.Windows.Forms.CheckBoxTS chkXVTRRF7;
        private System.Windows.Forms.CheckBoxTS chkXVTRRF6;
        private System.Windows.Forms.CheckBoxTS chkXVTRRF5;
        private System.Windows.Forms.CheckBoxTS chkXVTRRF4;
        private System.Windows.Forms.CheckBoxTS chkXVTRRF3;
        private System.Windows.Forms.CheckBoxTS chkXVTRRF2;
        private System.Windows.Forms.CheckBoxTS chkXVTRRF1;//
        private System.Windows.Forms.CheckBoxTS chkXVTRRF0;//
        private System.Windows.Forms.LabelTS lblXVTRRF;
        private System.Windows.Forms.NumericUpDownTS udRXGain15;
        private System.Windows.Forms.NumericUpDownTS udRXGain14;
        private System.Windows.Forms.NumericUpDownTS udRXGain13;
        private System.Windows.Forms.NumericUpDownTS udRXGain12;
        private System.Windows.Forms.NumericUpDownTS udRXGain11;
        private System.Windows.Forms.NumericUpDownTS udRXGain10;
        private System.Windows.Forms.NumericUpDownTS udRXGain9;
        private System.Windows.Forms.NumericUpDownTS udRXGain8;
        private System.Windows.Forms.NumericUpDownTS udRXGain7;
        private System.Windows.Forms.NumericUpDownTS udRXGain6;
        private System.Windows.Forms.NumericUpDownTS udRXGain5;
        private System.Windows.Forms.NumericUpDownTS udRXGain4;
        private System.Windows.Forms.NumericUpDownTS udRXGain3;
        private System.Windows.Forms.NumericUpDownTS udRXGain2;
        private System.Windows.Forms.NumericUpDownTS udRXGain1;//
        private System.Windows.Forms.NumericUpDownTS udRXGain0;//
        private System.Windows.Forms.LabelTS lblRXGain;
        private System.Windows.Forms.CheckBoxTS chkUseXVTRTUNPWR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_VUModuleNotPresent;//
        private System.Windows.Forms.Label label_VUModulePresent;//
        private System.Windows.Forms.LabelTS lblIFGain;//
        private System.Windows.Forms.LabelTS lblPAEnable;//
        private System.Windows.Forms.CheckBoxTS chkVHFIFGain;//
        private System.Windows.Forms.CheckBoxTS chkUHFIFGain;//
        private System.Windows.Forms.CheckBoxTS chkVHFPAEnable;//
        private System.Windows.Forms.CheckBoxTS chkUHFPAEnable;//////
        public System.Windows.Forms.CheckBoxTS chkAlwaysOnTop1;
        private System.Windows.Forms.CheckBoxTS chkFlexWire;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RichTextBox richTextBox1;

        private System.ComponentModel.IContainer components;

        

    }
}
