using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Windows.Forms;
using System.Xml.Serialization;

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

                    if (sfdSave.ShowDialog() == DialogResult.OK)
                    {
                        st = File.Create(sfdSave.FileName);
                        BinaryFormatter bf = new BinaryFormatter();

                        try
                        {
                            bf.Serialize(st, staffsToSave);
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            
                        }
                    }
                    break;
                case SerializationType.SOAP_XML:
                    sfdSave.DefaultExt = "*.xml";
                    sfdSave.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";

                    if (sfdSave.ShowDialog() == DialogResult.OK)
                    {
                        st = File.Create(sfdSave.FileName);
                        SoapFormatter sf = new SoapFormatter();
                        try
                        {
                            sf.Serialize(st, staffsToSave.ToArray()); // SOAP szerializáció nem támogatja a generic-et.
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    break;
                case SerializationType.XML:
                    sfdSave.DefaultExt = "*.xml";
                    sfdSave.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";

                    if (sfdSave.ShowDialog() == DialogResult.OK)
                    {
                        st = File.Create(sfdSave.FileName);
                        XmlSerializer xs = new XmlSerializer(typeof(List<Staff>));
                        try
                        {
                            xs.Serialize(st, staffsToSave);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    break;
                default:
                    break;
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            lstBxLoadedContent.Items.Clear();

            staffsToLoad.Clear();

            Stream st = Stream.Null;

            switch (loadType)
            {
                case SerializationType.Binary:
                    ofdLoad.DefaultExt = "*.dat";
                    ofdLoad.Filter = "Data files (*.dat)|*.dat|All files (*.*)|*.*";
                    if (ofdLoad.ShowDialog() == DialogResult.OK)
                    {
                        st = File.OpenRead(ofdLoad.FileName);
                        BinaryFormatter bf = new BinaryFormatter();
                        try
                        {
                            staffsToLoad = (List<Staff>)bf.Deserialize(st);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case SerializationType.SOAP_XML:
                    ofdLoad.DefaultExt = "*.xml";
                    ofdLoad.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                    if (ofdLoad.ShowDialog() == DialogResult.OK)
                    {
                        st = File.OpenRead(ofdLoad.FileName);
                        SoapFormatter sf = new SoapFormatter();
                        try
                        {
                            Staff[] staffs = (Staff[])sf.Deserialize(st);
                            staffsToLoad = staffs.ToList();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case SerializationType.XML:
                    ofdLoad.DefaultExt = "*.xml";
                    ofdLoad.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                    if (ofdLoad.ShowDialog() == DialogResult.OK)
                    {
                        st = File.OpenRead(ofdLoad.FileName);
                        XmlSerializer xs = new XmlSerializer(typeof(Staff[]));
                        try
                        {
                            Staff[] staffs = (Staff[])xs.Deserialize(st);
                            staffsToLoad = staffs.ToList();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
            }

            st.Close();
            upload(lstBxLoadedContent, staffsToLoad);
        }



    }
}
