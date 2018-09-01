/*
 * Created by SharpDevelop.
 * User: Abdurrahman
 * Date: 01/08/2017
 * Time: 10.51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing.Drawing2D;

using System.Globalization;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
	
namespace IRSKY_NEW
{
	/// <summary>
	/// Description of Config.
	/// </summary>
	public partial class Config : Form
	{
		private MainForm bForm;
		MainForm.cMap optMap = new MainForm.cMap();
		MainForm.cAttitude optAttitude = new MainForm.cAttitude();
		MainForm.featuresConf bftConf;
		
		public Config(MainForm refForm)
		{
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.bForm = refForm;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			tbLAT.Text = bForm.gcsLAT;
			tbLNG.Text = bForm.gcsLNG;
		}
		
		void ConfigLoad(object sender, EventArgs e)
		{
			
	
		}
		void BtnCancelClick(object sender, EventArgs e)
		{
			this.Dispose();
	
		}
		void BtnSetPosClick(object sender, EventArgs e)
		{
			
		}
		void RbPyramidCheckedChanged(object sender, EventArgs e)
		{
			optAttitude = MainForm.cAttitude.PYRAMID;
		}
		void RbRocketCheckedChanged(object sender, EventArgs e)
		{
			optAttitude = MainForm.cAttitude.ROCKET;
		}
		void RbSparkfunCheckedChanged(object sender, EventArgs e)
		{
			optAttitude = MainForm.cAttitude.BOX_ARROW;
		}
		void RbSatCheckedChanged(object sender, EventArgs e)
		{
			optMap = MainForm.cMap.SATELLIT;
	
		}
		void RbMapCheckedChanged(object sender, EventArgs e)
		{
			optMap = MainForm.cMap.MAP;
	
		}
		void BtnApplClick(object sender, EventArgs e)
		{
			
			PointLatLng tmp = new PointLatLng( double.Parse(tbLAT.Text), double.Parse(tbLNG.Text));
			bForm.updateGCSloc = tmp;
			
			switch(optMap){
				case MainForm.cMap.MAP:
					bForm.updateView = GMapProviders.GoogleMap;
					break;
				case MainForm.cMap.SATELLIT:
					GMap.NET.MapProviders.GoogleSatelliteMapProvider.Instance.ApiKey = "AIzaSyBjYPEfZ8ZLgjsG-w0ZtfwYs2_tOjbKtJ8";
					bForm.updateView = GMap.NET.MapProviders.GoogleHybridMapProvider.Instance;
					break;
			}
			bftConf._3dModel = cb3DM.Checked;
			bftConf._accChart = cbAccChart.Checked;
			bftConf._altVdist = cbAltvDist.Checked;
			bftConf._compass = cbCMPS.Checked;
			bftConf._map = cbMap.Checked;
			bftConf._odometri = cbOdo.Checked;
			bftConf._saveRC = cbSaveRC.Checked;
			bftConf._UTD = cbUTD.Checked;
			
			bForm.ftConf = bftConf;
			bForm.optMap = optMap;
			bForm.optAttitude = optAttitude;
		}
		void BtnOKClick(object sender, EventArgs e)
		{
            BtnApplClick(null, null);

			if(cbSaveRC.Checked == false){
				DialogResult res;
				res = MessageBox.Show("Are you sure to disable Save to Record Features ?", "Record Option", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				
				if(res == System.Windows.Forms.DialogResult.Yes)
					this.Dispose();
			}
			else
				this.Dispose();
		}
		
		void CbSaveRCCheckedChanged(object sender, EventArgs e)
		{
			if(cbSaveRC.Checked == false){
				DialogResult res;
				res = MessageBox.Show("Are you sure to disable Save to Record Features ?", "Record Option", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				
				if(res == System.Windows.Forms.DialogResult.Yes)
					cbSaveRC.Checked = false;
				else
					cbSaveRC.Checked = true;
			}
	
		}


	}
}
