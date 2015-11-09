using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dag {
	public partial class Form1: Form {
		public Form1 () {
			InitializeComponent ();
		}

		private void dayText_TextChanged (object sender, EventArgs e) {}
		private void monthText_TextChanged (object sender, EventArgs e) {}
		private void yearText_TextChanged (object sender, EventArgs e) {}
		private void day_Click (object sender, EventArgs e) {}
		private void calc_Click (object sender, EventArgs e) {
			if (dayText.Text != "" && monthText.Text != "" && yearText.Text != "") {
				try {
					int dayIn = int.Parse (dayText.Text);
					int monthIn = int.Parse (monthText.Text);
					int yearIn = int.Parse (yearText.Text);

					if (yearIn <= 1582) {
						MessageBox.Show ("The year you entered is invalid. \nEnter a year bigger than 1582", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						return;
					} else {
						int febDays = calcFeb (yearIn);
						febDay.Text = febDays.ToString ();
						if (monthIn <= 0 || monthIn > 12) {
							MessageBox.Show ("The month you entered is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							return;
						} else {
							if (dayIn <= 0 || (dayIn > febDays && monthIn == 2) || (dayIn > 30 && (monthIn == 4 || monthIn == 6 || monthIn == 11 || monthIn == 9) || (dayIn > 30 && (monthIn == 1 || monthIn == 3 || monthIn == 5 || monthIn == 7 || monthIn == 8 || monthIn == 10 || monthIn == 12)))) {
								MessageBox.Show ("The day you entered is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							} else {
								if (monthIn > 2)
									monthIn -= 2;
								else {
									monthIn += 10;
									yearIn --;
								}
								int cent = (int)(yearIn/100);
								int year = yearIn - cent*100;
								int dayOfWeek = ((13 * monthIn - 1) / 5 + cent / 4 + year / 4 + dayIn + year - 2 * cent + 700) % 7;
								string dOW = "";
								switch (dayOfWeek) {
									case 0:
										dOW = "Sunday";
										break;
									case 1:
										dOW = "Monday";
										break;
									case 2:
										dOW = "Tuesday";
										break;
									case 3:
										dOW = "Wednesday";
										break;
									case 4:
										dOW = "Thursday";
										break;
									case 5:
										dOW = "Friday";
										break;
									case 6:
										dOW = "Saturday";
										break;
								}
								day.Text = dOW + ".";
							}
						}
					}
				}
				catch (FormatException ex) {
					MessageBox.Show ("Enter numbers in each field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
			} else if (yearText.Text != "") {
				try {
					int yearIn = int.Parse (yearText.Text);

					if (yearIn <= 1582) {
						MessageBox.Show ("The year you entered is invalid. \nEnter a year bigger than 1582", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						return;
					} else {
						MessageBox.Show ("You only entered a year. Only the number of days in the month February of that year will be displayed.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						febDay.Text = calcFeb (yearIn).ToString ();
					}
				} catch (FormatException ex) {}
			} else {
				MessageBox.Show ("Enter data in each field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
		}
		private int calcFeb (int year) {
			return (year % 400 == 0 || (year % 4 == 0 && !(year % 100 == 0))) ? 29 : 28; ;
		}
	}
}
