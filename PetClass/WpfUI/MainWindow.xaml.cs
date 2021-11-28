/**
* 11/28/21
* CSC 253
* Adam Lancaster
* Pet Class
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PetClassLib;

namespace WpfUI
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		/// <summary>
		/// on click, save info to storedPet obj.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SaveButton_Click(object sender, RoutedEventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(NameInputTextBox.Text) &&
				!string.IsNullOrWhiteSpace(TypeInputTextBox.Text) &&
				!string.IsNullOrWhiteSpace(AgeInputTextBox.Text))
			{
				Model.StoredPet = new Pet(NameInputTextBox.Text,
										  TypeInputTextBox.Text,
										  AgeInputTextBox.Text);

				NameInputTextBox.Clear();
				TypeInputTextBox.Clear();
				AgeInputTextBox.Clear();
			}
			else
			{
				MessageBox.Show("Invalid Entries.");
			}
		}

		/// <summary>
		/// on click, load and display stored pet data.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LoadButton_Click(object sender, RoutedEventArgs e)
		{
			if (Model.StoredPet != null)
			{
				NameInputTextBox.Text = Model.StoredPet.Name;
				TypeInputTextBox.Text = Model.StoredPet.Type;
				AgeInputTextBox.Text = Model.StoredPet.Age;
			}
			else
			{
				MessageBox.Show("No pet stored yet.");
			}
		}

		/// <summary>
		/// on click, clear fields and data model. 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearButton_Click(object sender, RoutedEventArgs e)
		{
			Model.StoredPet = null;

			NameInputTextBox.Clear();
			TypeInputTextBox.Clear();
			AgeInputTextBox.Clear();
		}

		/// <summary>
		/// on click, close program.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ExitButton_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
	}
}
