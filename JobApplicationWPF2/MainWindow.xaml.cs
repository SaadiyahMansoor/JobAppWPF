using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JobApplicationWPF2;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    string name;
    string role;
    string salary;
    string availability;
    string worktype;

    List<string> skills = new List<string>();

    public MainWindow()
    {
        InitializeComponent();
    }

    private void btnSubmit_Click(object sender, RoutedEventArgs e)
    {
        name = txtFullName.Text;
        role = txtRole.Text;
        salary = txtExpectedSalary.Text;

        if (chkCSharp.IsChecked == true)
        {
            skills.Add(chkCSharp.Content.ToString());
        }

        if (chkPython.IsChecked == true)
        {
            skills.Add(chkPython.Content.ToString());
        }

        if (chkSQL.IsChecked == true)
        {
            skills.Add(chkSQL.Content.ToString());
        }


        availability = cmbAvailability.Text;

        worktype = radOnSite.IsChecked == true ? radOnSite.Content.ToString() : radRemote.Content.ToString();


        InfoOutput.Text = "Application Submitted\n\n" +
                          $"Name: {name}\n" +
                          $"Role: {role}\n" +
                          $"Expected Salary: R {salary}\n" +
                          $"Skills: {string.Join(", ", skills)}\n" +
                          $"Availability: {availability}\n" +
                          $"Work Type: {worktype}";

    }
}