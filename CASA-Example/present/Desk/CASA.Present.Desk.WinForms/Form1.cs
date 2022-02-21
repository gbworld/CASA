using CASA.Core;
using CASA.Core.Contracts;
using CASA.Framework.Authentication;
using CASA.Framework.Authentication.Contracts;
using CASA.Framework.ClientRouting;
using CASA.Framework.ClientRouting.Contracts;
using CASA.Persist.PostalCode;
using CASA.Persist.PostalCode.Contracts;
using System.ComponentModel;

namespace CASA.Present.Desk.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // TODO: Pull from Dependecy Injection
            // NOTE: This is the Presentation knowing configuartion
            //              (a different UI might do things differently)
            IPostalCodeRepository postalCodeRepository = new PostalCodeRepository();
            ICountryRepository countryRepository = new CountryRepository();
            IStateRepository stateRepository = new StateRepository();
            IClientRouter clientRouter = new ExampleClientRouter();
            IUserAuthenticator userAuthenticator = new DatabaseUserAutheticator();

            // Set connection strings for things not needing faking the client routing
            // Why not in config? Because these would not exist in the real world
            //      Client Routing would utilize another method
            string connectionString = "Server=(local);Database=PostalCode;TRUSTED_CONNECTION=True;";
            countryRepository.SetConnectionString(connectionString);
            stateRepository.SetConnectionString(connectionString);

            IPostalCodeDataPackService service = new PostalCodeDataPackService(postalCodeRepository
                , countryRepository, stateRepository, clientRouter, userAuthenticator);

            string postalCode = postalCodeTextbox.Text;
            string userName = userComboBox.Text;

            var dataToBind = service.GetPostalCodeListByPostalCode(postalCode, userName, NearbyCheckBox.Checked);

            PostalGridView.DataSource = dataToBind;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userComboBox.SelectedIndex = 1;
        }
    }
}