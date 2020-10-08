
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serializer
{

    public enum SerializationType { Binary, SOAP_XML, XML };

    public partial class Serializer : Form
    {

        public List<Staff> staffsToSave, staffsToLoad;
        public SerializationType saveType, loadType;

        public Serializer()
        {
            InitializeComponent();

            staffsToSave = new List<Staff>();
            staffsToLoad = new List<Staff>();

            staffsToSave.Add(new Staff(21, "Marketing", "Mark B. Harbour", 6, 20000, 0.5, "973-475-1512", "937-823-2348",
                new Address("Postal", "3971 Ingram Street", "Dayton", "Ohio(OH)", 45402, "USA")));
            staffsToSave.Add(new Staff(23, "Sales", "Charles M Stewart", 6, 22000, 0.03, "740-803-7350", "740-272-9206",
                new Address("Postal", "3483", "Delaware", "Ohio(OH)", 43015, "USA")));
            staffsToSave.Add(new Staff(24, "Sales", "Liz Elbow", 5, 22500, 0.02, "863-474-6774", "305-201-9879",
                new Address("Permanent", "1732 Single Street", "Cambridge", "Massachusetts(MA)", 02141, "USA")));

            upload(lstBxOriginalContent, staffsToSave);

            rdBtnBinary.Checked = rdBtnLoadBinary.Checked = true;
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void upload(ListBox listBox, List<Staff> staffs)
        {
            foreach (Staff staff in staffs)
                listBox.Items.Add(staff);
        }

        private void rdLoad_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdBttnLoad = (RadioButton)sender;

            if (rdBttnLoad.Checked)
            {
                switch (rdBttnLoad.Name)
                {
                    case "rdBtnLoadBinary":
                        loadType = SerializationType.Binary;
                        break;
                    case "rdBtnLoadSoapXml":
                        loadType = SerializationType.SOAP_XML;
                        break;
                    case "rdBtnLoadXML":
                        loadType = SerializationType.XML;
                        break;
                }
            }

        }



        private void rdSave_CheckedChange(object sender, EventArgs e)
        {
            RadioButton rdBttnSave = (RadioButton)sender;

            if (rdBttnSave.Checked)
            {
                switch (rdBttnSave.Name)
                {
                    case "rdBtnBinary":
                        saveType = SerializationType.Binary;
                        break;
                    case "rdBtnSoapXml":
                        saveType = SerializationType.SOAP_XML;
                        break;
                    case "rdBtnXml":
                        saveType = SerializationType.XML;
                        break;
                }
            }
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            Stream st = Stream.Null;

            switch (saveType)
            {
                case SerializationType.Binary:
                    sfdSave.DefaultExt = "*.dat";
                    sfdSave.Filter = "Data files (*.dat)|*.dat|All files (*.*)|*.*";
                    break;
                case SerializationType.SOAP_XML:
                    break;
                case SerializationType.XML:
                    break;
                default:
                    break;
            }

        }













        private void lblLoadedContent_Click(object sender, EventArgs e)
        {

        }
    }
}
