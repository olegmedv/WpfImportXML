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
using System.Data.Entity;
using Microsoft.Win32;
using System.Data;
using System.IO;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace WpfImportXML
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApplicationContext db;
        public MainWindow()
        {
            InitializeComponent();
            db = new ApplicationContext();
            db.Clients.Load();
            this.DataContext = db.Clients.Local.ToBindingList();
        }

        private void OpenFileXMLDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                LoadXML(openFileDialog.FileName);
            }
        }
        static DateTime? ConvertToDateTime(string value)
        {
            DateTime convertedDate;
            try
            {
                convertedDate = Convert.ToDateTime(value);
                return convertedDate;

            }
            catch (FormatException)
            {
                return null;
            }
        }


        private void LoadXML(string FileName)
        {
            XDocument xdoc = XDocument.Load(FileName);
            var items = from xe in xdoc.Element("Clients").Elements("Client")
                        select new Client
                        {
                            Cardcode = xe.Attribute("CARDCODE").Value,
                            Startdate = ConvertToDateTime(xe.Attribute("STARTDATE").Value),
                            Finishdate = ConvertToDateTime(xe.Attribute("FINISHDATE").Value),
                            Lastname = xe.Attribute("LASTNAME").Value,
                            Firstname = xe.Attribute("FIRSTNAME").Value,
                            Surname = xe.Attribute("SURNAME").Value,
                            Gender = xe.Attribute("GENDER").Value,
                            Birthday = ConvertToDateTime(xe.Attribute("BIRTHDAY").Value),
                            Phonehome = xe.Attribute("PHONEHOME").Value,
                            Phonemobil = xe.Attribute("PHONEMOBIL").Value,
                            Email = xe.Attribute("EMAIL").Value,
                            City = xe.Attribute("CITY").Value,
                            Street = xe.Attribute("STREET").Value,
                            House = xe.Attribute("HOUSE").Value,
                            Apartment = xe.Attribute("APARTMENT").Value
                        };

            foreach (var item in items)
            {
                db.Clients.Add(item);
                db.SaveChanges();
            }
        }

        private void EditRow()
        {
            if (DataGridXML.SelectedItem == null) return;

            Client client = DataGridXML.SelectedItem as Client;

            ClientWindows clientWindows = new ClientWindows(new Client
            {
                Id = client.Id,
                Cardcode = client.Cardcode,
                Startdate = client.Startdate,
                Finishdate = client.Finishdate,
                Lastname = client.Lastname,
                Firstname = client.Firstname,
                Surname = client.Surname,
                Gender = client.Gender,
                Birthday = client.Birthday,
                Phonehome = client.Phonehome,
                Phonemobil = client.Phonemobil,
                Email = client.Email,
                City = client.City,
                Street = client.Street,
                House = client.House,
                Apartment = client.Apartment
            });

            if (clientWindows.ShowDialog() == true)
            {
                client = db.Clients.Find(clientWindows.Client.Id);
                if (client != null)
                {
                    client.Cardcode = clientWindows.Client.Cardcode;
                    client.Startdate = clientWindows.Client.Startdate;
                    client.Finishdate = clientWindows.Client.Finishdate;
                    client.Lastname = clientWindows.Client.Lastname;
                    client.Firstname = clientWindows.Client.Firstname;
                    client.Surname = clientWindows.Client.Surname;
                    client.Gender = clientWindows.Client.Gender;
                    client.Birthday = clientWindows.Client.Birthday;
                    client.Phonehome = clientWindows.Client.Phonehome;
                    client.Phonemobil = clientWindows.Client.Phonemobil;
                    client.Email = clientWindows.Client.Email;
                    client.City = clientWindows.Client.City;
                    client.Street = clientWindows.Client.Street;
                    client.House = clientWindows.Client.House;
                    client.Apartment = clientWindows.Client.Apartment;

                    db.Entry(client).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }

        private void DeleteRow()
        {
            if (DataGridXML.SelectedItem == null) return;

            MessageBoxResult result = MessageBox.Show(this, "Delete record?",
            "Confirmation", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            if (result == MessageBoxResult.OK)
            {
                Client client = DataGridXML.SelectedItem as Client;
                db.Clients.Remove(client);
                db.SaveChanges();
            }
            else
            {
                // No code here  
            }

        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            OpenFileXMLDialog();
        }
        private void MenuAdd_Click(object sender, RoutedEventArgs e)
        {
            OpenFileXMLDialog();
        }

        private void btn_Edit_Click(object sender, RoutedEventArgs e)
        {
            EditRow();
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            EditRow();
        }

        private void btn_Del_Click(object sender, RoutedEventArgs e)
        {
            DeleteRow();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            DeleteRow();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Close();
        }
    }
}
