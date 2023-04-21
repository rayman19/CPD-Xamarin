using System;
using Xamarin.Forms;

namespace lab_hamarin
{
	public partial class MainPage : ContentPage
	{
		DateTime date1, date2;
		int count = 0;
		public MainPage()
		{
			InitializeComponent();
		}
		private void datePicker_DateFirstSelected(object sender, DateChangedEventArgs e)
		{
			date1 = DateTime.Parse(e.NewDate.ToString("dd/MM/yyyy"));
		}
		private void datePicker_DateSecondSelected(object sender, DateChangedEventArgs e)
		{
			date2 = DateTime.Parse(e.NewDate.ToString("dd/MM/yyyy"));
		}
		private void Button_Click_Diff(object sender, EventArgs e)
		{
			int days = Math.Abs((date2 - date1).Days);
			result.Text = "Количество дней: " + days.ToString();
		}
		private void Button_Click_Plus(object sender, EventArgs e)
		{
			count = int.Parse(countDays.Text);
			DateTime newdate = date1.AddDays(count);
			result.Text = "Новая дата: " + newdate.ToString("dd/MM/yyyy");
		}
		private void Button_Click_Minus(object sender, EventArgs e)
		{
			count = int.Parse(countDays.Text);
			DateTime newdate = date1.AddDays(-count);
			result.Text = "Новая дата: " + newdate.ToString("dd/MM/yyyy");
		}
	}
}
