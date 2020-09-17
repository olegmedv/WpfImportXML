using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

[Serializable]
public class Client : INotifyPropertyChanged
{
public int Id { get; set; }
private String cardcode { get; set; }
private DateTime? startdate { get; set; }
private DateTime? finishdate { get; set; }
private String lastname { get; set; }
private String firstname { get; set; }
private String surname { get; set; }
private String gender { get; set; }
private DateTime? birthday { get; set; }
private String phonehome { get; set; }
private String phonemobil { get; set; }
private String email { get; set; }
private String city { get; set; }
private String street { get; set; }
private String house { get; set; }
private String apartment { get; set; }

public String 	Cardcode	{ get { return 	cardcode; } set { cardcode = value; OnPropertyChanged("Cardcode");}}
public DateTime? Startdate	{ get { return 	startdate; } set { startdate = value; OnPropertyChanged("Startdate");}}
public DateTime? Finishdate	{ get { return 	finishdate; } set { finishdate = value; OnPropertyChanged("Finishdate");}}
public String 	Lastname	{ get { return 	lastname; } set { lastname = value; OnPropertyChanged("Lastname");}}
public String 	Firstname	{ get { return 	firstname; } set { firstname = value; OnPropertyChanged("Firstname");}}
public String 	Surname	{ get { return 	surname; } set { surname = value; OnPropertyChanged("Surname");}}
public String Gender { get { return gender; } set { gender = value; OnPropertyChanged("Gender"); } }
public DateTime? Birthday { get { return birthday; } set { birthday = value; OnPropertyChanged("Birthday"); }}
public String Phonehome { get { return phonehome; } set { phonehome = value; OnPropertyChanged("Phonehome"); }}
public String Phonemobil { get { return phonemobil; } set { phonemobil = value; OnPropertyChanged("Phonemobil"); }}
public String Email { get { return email; } set { email = value; OnPropertyChanged("Email"); }}
public String City { get { return city; } set { city = value; OnPropertyChanged("City"); }}
public String Street { get { return street; } set { street = value; OnPropertyChanged("Street"); }}
public String House { get { return house; } set {house = value; OnPropertyChanged("House");}}
public String Apartment { get { return apartment; } set { apartment = value; OnPropertyChanged("Apartment"); } }



public event PropertyChangedEventHandler PropertyChanged;
public void OnPropertyChanged([CallerMemberName] string prop = "")
{
if (PropertyChanged != null)
PropertyChanged(this, new PropertyChangedEventArgs(prop));
}
}

