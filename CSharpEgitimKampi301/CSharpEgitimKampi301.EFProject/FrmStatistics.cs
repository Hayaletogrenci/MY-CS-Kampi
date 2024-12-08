using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
	public partial class FrmStatistics : Form
	{
		public FrmStatistics()
		{
			InitializeComponent();
		}

		EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
		private void FrmStatistics_Load(object sender, EventArgs e)
		{
			
			//Toplam Lokasyon Sayısı
			lblLocationCount.Text = db.Location.Count().ToString();

			//Turdaki Toplam Kapasite
			lblSumCapacity.Text = db.Location.Sum(x => x.Capacity).ToString();

			//Toplam rehber sayısı
			lblGuideCount.Text=db.Guide.Count().ToString();
			
			//Ortalama kapasite
			decimal avgCapacity=(decimal)db.Location.Average(x => x.Capacity);
			lblAvgCapacity.Text = avgCapacity.ToString("F2");

			//Ortalama Tur Fiyatı
			decimal avgPrice = (decimal)db.Location.Average(x => x.Price);
			lblAvgLocationPrice.Text = avgPrice.ToString("N2") + " ₺";

			//Son eklenen Ülke
			int lasCountryId = db.Location.Max(x => x.LocationId);
			lblLastCountryName.Text = db.Location.Where(x => x.LocationId == lasCountryId).Select(y => y.Country).FirstOrDefault();

			//Kapodokya tur kapasitesi
			lblCappadociaLocationCapacity.Text = db.Location.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();

			//Türkye Turları Ortalama Kapasite
			lblTurkiyeCapacityAvg.Text=db.Location.Where(x=>x.Country=="Türkiye").Average(y=>y.Capacity).ToString();

			//Roma Gezisi Rehberinin İsmi
			var romeGuideId = db.Location.Where(x => x.City == "Roma Turistik").Select(y => y.GuideId).FirstOrDefault();
			lblRomeGuideName.Text=db.Guide.Where(x=>x.GuideId==romeGuideId).Select(y=>y.GuideName+" "+y.GuideSurname).FirstOrDefault().ToString();

			//En yüksek kapasiteli tur
			var maxCapacity = db.Location.Max(x => x.Capacity);
			lblMaxCapacityLocation.Text = db.Location.Where(x => x.Capacity == maxCapacity).Select(y => y.City).FirstOrDefault().ToString();

			//En Pahalı Tur
			var maxPrice = db.Location.Max(x => x.Price);
			lblMaxPriceLocation.Text=db.Location.Where(x=>x.Price==maxPrice).Select(y=>y.City).FirstOrDefault().ToString();

			//Ayşegül Çınar Tur sayısı
			var guideIdByNameAysegulCinar=db.Guide.Where(x=>x.GuideName=="Ayşegül" && x.GuideSurname=="Çınar").Select(y=>y.GuideId).FirstOrDefault();
			lblAysegulCinarLocation.Text = db.Location.Where(x => x.GuideId == guideIdByNameAysegulCinar).Count().ToString();

		}

		
	}
}
