using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SoftwareConfigurationManagementDBApp
{
    class AttributeControl
    {
        private int mSoftware_ID;
        private String _connectionString;

        public AttributeControl()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["SCMDatabaseConnectionString"].ConnectionString;
        }

        public void openAttributeForm()
        {
            Attribute_s_ AddAttributes = new Attribute_s_();
            AddAttributes.Show();
        }
        public void submitSoftDoc(SoftwareDoc aDoc)
        {

        }

        public void submitCI(CI aCI)
        {

        }

        public void submitCIDoc(CIDocs aCIDoc)
        {

        }
    }
}
