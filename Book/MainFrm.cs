using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace Book
{
    public partial class MainFrm : Form
    {
        XmlDocument xmlDoc = new XmlDocument();
        OpenFileDialog ofd = new OpenFileDialog();

        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            btnAddNode.Enabled = btnModify.Enabled = btnRemoveBook.Enabled = false;
        }
        private void btnLoadXml_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ofd.Title = "Open XML Document";
            ofd.Filter = "XML Files (*.xml)|*.xml";
            ofd.FileName = Application.StartupPath + "\\example.xml";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                trVw.Nodes.Clear();
                btnAddNode.Enabled = true;

                
                try
                {
                    xmlDoc.Load(ofd.FileName);
                }
                catch (XmlException xmlEx)
                {
                    MessageBox.Show(xmlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Cursor = Cursors.Default;
                }
                reloadTreeView();
                fillIsbns();
                trVw.Nodes[0].ExpandAll();
            }
            else
                Cursor = Cursors.Default;
        }
        private void addNode(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            if (inXmlNode.HasChildNodes)
            {
                XmlNodeList xmlNodes = inXmlNode.ChildNodes;
                for (int i = 0; i < xmlNodes.Count; ++i)
                {
                    XmlNode xmlNode = inXmlNode.ChildNodes[i];
                    if (xmlNode.Name == "book")
                        try
                        {
                            inTreeNode.Nodes.Add(new TreeNode(xmlNode.Name + " (ISBN: " + xmlNode.Attributes["isbn"].Value + ")"));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    else
                        inTreeNode.Nodes.Add(new TreeNode(xmlNode.Name));
                    TreeNode treeNode = inTreeNode.Nodes[i];
                    addNode(xmlNode, treeNode);
                }
            }
            else
            {
                if (inXmlNode.Name == "author")
                    try
                    {
                        inTreeNode.Text = inXmlNode.Attributes["fname"].Value + " " + inXmlNode.Attributes["lname"].Value;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                else if (inXmlNode.ParentNode.Name == "review")
                    try
                    {
                        inTreeNode.Text = inXmlNode.InnerText + " (evaluation: " + inXmlNode.ParentNode.Attributes["eval"].Value + ")";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                else
                    inTreeNode.Text = inXmlNode.InnerText;
            }
        }
        private void fillIsbns()
        {
            cmbBxIsbn.Items.Clear();
            cmbBxIsbn.Text = "";
            XmlNodeList nodes = xmlDoc.SelectNodes("/books/book");
            foreach (XmlNode node in nodes)
                try
                {
                    cmbBxIsbn.Items.Add(node.Attributes["isbn"].Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        private void btnAddNode_Click(object sender, EventArgs e)
        {
            if (txtBxISBN.Text != "")
            {
                if (!isIsbnExist(txtBxISBN.Text))
                {
                    XmlElement book = xmlDoc.CreateElement("book"),
                        title = xmlDoc.CreateElement("title"),
                        publisher = xmlDoc.CreateElement("publisher"),
                        price = xmlDoc.CreateElement("price"),
                        pages = xmlDoc.CreateElement("pages"),
                        chapters = xmlDoc.CreateElement("chapters"),
                        appendices = xmlDoc.CreateElement("appendices"),
                        authors = xmlDoc.CreateElement("authors"),
                        reviews = xmlDoc.CreateElement("reviews");
                    XmlAttribute isbn = xmlDoc.CreateAttribute("isbn");
                    isbn.Value = txtBxISBN.Text;

                    book.Attributes.Append(isbn);
                    book.AppendChild(title);
                    book.AppendChild(publisher);
                    book.AppendChild(price);
                    book.AppendChild(pages);
                    book.AppendChild(chapters);
                    book.AppendChild(appendices);
                    book.AppendChild(createAuthorsNode(authors));
                    book.AppendChild(createReviewsNode(reviews));
                    title.AppendChild(xmlDoc.CreateTextNode(txtBxTitle.Text));
                    publisher.AppendChild(xmlDoc.CreateTextNode(txtBxPublisher.Text));
                    price.AppendChild(xmlDoc.CreateTextNode(txtBxPrice.Text));
                    pages.AppendChild(xmlDoc.CreateTextNode(txtBxPages.Text));
                    chapters.AppendChild(xmlDoc.CreateTextNode(txtBxChapters.Text));
                    appendices.AppendChild(xmlDoc.CreateTextNode(txtBxAppendices.Text));

                    xmlDoc.DocumentElement.AppendChild(book);
                    reloadTreeView();
                    fillIsbns();
                    xmlDoc.Save(ofd.FileName);
                    trVw.Nodes[0].ExpandAll();
                    clearInputBoxes();
                }
                else
                    MessageBox.Show("ISBN already exist!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("ISBN must be filled!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool isIsbnExist(string newIsbn)
        {
            XmlNodeList nodes = xmlDoc.SelectNodes("/books/book");
            foreach (XmlNode xmlNode in nodes)
                if (xmlNode.Attributes["isbn"].Value == newIsbn)
                    return true;
            return false;
        }
        private void reloadTreeView()
        {
            XmlNode xmlNode = xmlDoc.ChildNodes[1]; //books
            trVw.Nodes.Clear();
            trVw.Nodes.Add(new TreeNode(xmlDoc.DocumentElement.Name));
            TreeNode treeNode = trVw.Nodes[0];
            addNode(xmlNode, treeNode);
        }
        private XmlElement createAuthorsNode(XmlElement element)
        {
            List<XmlAttribute> fnames = new List<XmlAttribute>(), lnames = new List<XmlAttribute>();

            foreach (string line in txtBxFullName.Lines)
            {
                XmlAttribute fname = xmlDoc.CreateAttribute("fname"), lname = xmlDoc.CreateAttribute("lname");
                try
                {
                    string[] names = line.Split(' ');
                    fname.Value = names[0];
                    lname.Value = names[1];
                    fnames.Add(fname);
                    lnames.Add(lname);
                }
                catch
                {
                    MessageBox.Show("Wrong input format! Author name(s) not added! Do not forget to use next format: \n\r\n\r{firstname lastname\n\rfirstname lastname} \n\r\n\r", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            XmlElement authors = element;

            for (int i = 0; i < fnames.Count; ++i)
            {
                XmlElement author = xmlDoc.CreateElement("author");
                authors.AppendChild(author);
                author.Attributes.Append(fnames[i]);
                author.Attributes.Append(lnames[i]);
            }

            return authors;
        }
        private XmlElement createReviewsNode(XmlElement element)
        {
            string[] texts = txtBxText.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                     evals = txtBxEval.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            XmlElement reviews = element;
            if (texts.Length != evals.Length)
            {
                MessageBox.Show("Wrong input format! Do not forget to give evaluation value and review text at one time!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return reviews;
            }

            int i = 0;
            foreach (string line in txtBxEval.Lines)
            {
                XmlElement review = xmlDoc.CreateElement("review");
                reviews.AppendChild(review);
                XmlAttribute eval = xmlDoc.CreateAttribute("eval");
                eval.Value = evals[i];
                review.Attributes.Append(eval);
                try
                {
                    XmlText reviewText = xmlDoc.CreateTextNode(texts[i++]);
                    review.AppendChild(reviewText);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return reviews;
        }
        private void btnRemoveNode_Click(object sender, EventArgs e)
        {
            XmlNode xmlNodeToRemove = xmlDoc.SelectSingleNode("//books/book[@isbn='" + cmbBxIsbn.SelectedItem + "']");
            if (xmlNodeToRemove != null)
                xmlDoc.DocumentElement.RemoveChild(xmlNodeToRemove);

            RemoveModifyPostProc();
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            XmlNode selectedXmlNode = xmlDoc.SelectSingleNode("//books/book[@isbn='" + cmbBxIsbn.SelectedItem + "']");
            if (selectedXmlNode != null)
            {
                List<XmlNode> nodes = new List<XmlNode> { selectedXmlNode["title"], selectedXmlNode["publisher"], selectedXmlNode["price"],
                selectedXmlNode["pages"], selectedXmlNode["chapters"], selectedXmlNode["appendices"]};
                List<TextBox> textBoxes = new List<TextBox> { txtBxTitle, txtBxPublisher, txtBxPrice, txtBxPages, txtBxChapters, txtBxAppendices };
                updateBookInformation(nodes, textBoxes);
            }

            XmlNode authors = xmlDoc.SelectSingleNode("//books/book[@isbn='" + cmbBxIsbn.SelectedItem + "']/authors");
            if (authors != null)
                updateAuthors(authors);

            XmlNode reviews = xmlDoc.SelectSingleNode("//books/book[@isbn='" + cmbBxIsbn.SelectedItem + "']/reviews");
            if (reviews != null)
                updateReview(reviews);

            RemoveModifyPostProc();
        }
        private void RemoveModifyPostProc()
        {
            reloadTreeView();
            fillIsbns();
            xmlDoc.Save(ofd.FileName);
            trVw.Nodes[0].ExpandAll();
            clearInputBoxes();
            setButtonsToAdd();
            txtBxISBN.Enabled = true;
        }
        private void updateBookInformation(List<XmlNode> xmlNodes, List<TextBox> textBoxes)
        {
            for (int i = 0; i < xmlNodes.Count; ++i)
                xmlNodes[i].InnerText = textBoxes[i].Text;
        }
        private void updateAuthors(XmlNode authors)
        {
            int i = 0, j;
            foreach (string line in txtBxFullName.Lines)
            {
                string[] names = line.Split(' ');
                if (names.Length != 2)
                {
                    MessageBox.Show("Wrong input format! Do not forget to use next format: \n\r\n\r{firstname lastname\n\rfirstname lastname} \n\r\n\r", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    continue;
                }
                j = 0;
                if (authors.ChildNodes[i] != null)
                    foreach (XmlAttribute xmlAttribute in authors.ChildNodes[i].Attributes)
                    {
                        try
                        {
                            xmlAttribute.InnerText = names[j];
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        ++j;
                    }
                else if (authors.ChildNodes[i] == null)
                {
                    XmlAttribute fname = xmlDoc.CreateAttribute("fname"),
                                 lname = xmlDoc.CreateAttribute("lname");
                    try
                    {
                        fname.Value = names[0];
                        lname.Value = names[1];
                    }
                    catch
                    {
                        MessageBox.Show("Wrong input format! Do not forget to use next format: \n\r\n\r{firstname lastname\n\rfirstname lastname} \n\r\n\r", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    XmlElement author = xmlDoc.CreateElement("author");
                    authors.AppendChild(author);
                    author.Attributes.Append(fname);
                    author.Attributes.Append(lname);
                }
                ++i;
            }
            if (i < authors.ChildNodes.Count)
                for (int k = authors.ChildNodes.Count - 1; k >= i; --k)
                    authors.RemoveChild(authors.ChildNodes[k]);
        }
        private void updateReview(XmlNode reviews)
        {
            string[] evals = txtBxEval.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None),
                     texts = txtBxText.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            if (texts.Length != evals.Length)
            {
                MessageBox.Show("Wrong input format! Do not forget to give evaluation value and review text at one time!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int i;
            for (i = 0; i < texts.Length; ++i)
            {
                if (reviews.ChildNodes[i] != null)
                {
                    reviews.ChildNodes[i].InnerText = texts[i];
                    reviews.ChildNodes[i].Attributes["eval"].Value = evals[i];
                }
                else if (reviews.ChildNodes[i] == null)
                {
                    XmlElement review = xmlDoc.CreateElement("review");
                    reviews.AppendChild(review);
                    review.AppendChild(xmlDoc.CreateTextNode(texts[i]));
                    XmlAttribute evalAttribute = xmlDoc.CreateAttribute("eval");
                    evalAttribute.Value = evals[i];
                    review.Attributes.Append(evalAttribute);
                }
            }

            if (i < reviews.ChildNodes.Count)
                for (int k = reviews.ChildNodes.Count - 1; k >= i; --k)
                    reviews.RemoveChild(reviews.ChildNodes[k]);
        }
        private void setButtonsToAdd()
        {
            btnAddNode.Enabled = true;
            btnRemoveBook.Enabled = btnModify.Enabled = false;
        }
        private void clearInputBoxes()
        {
            foreach (Control control in grpBxSelectedNodeInformation.Controls)
                if (control is TextBox)
                    control.Text = "";

            foreach (Control control in grpBxAuthors.Controls)
                if (control is TextBox)
                    control.Text = "";

            foreach (Control control in grpBxReviews.Controls)
                if (control is TextBox)
                    control.Text = "";
        }
        private void cmbBxIsbn_SelectedIndexChanged(object sender, EventArgs e)
        {
            setButtonsToModify();
            txtBxISBN.Enabled = false;
            XmlNode selectedNode = xmlDoc.SelectSingleNode("//books/book[@isbn='" + cmbBxIsbn.SelectedItem + "']");

            if (selectedNode != null)
            {
                txtBxISBN.Text = selectedNode.Attributes["isbn"].Value;
                txtBxTitle.Text = selectedNode["title"].InnerText;
                txtBxPublisher.Text = selectedNode["publisher"].InnerText;
                txtBxPrice.Text = selectedNode["price"].InnerText;
                txtBxPages.Text = selectedNode["pages"].InnerText;
                txtBxChapters.Text = selectedNode["chapters"].InnerText;
                txtBxAppendices.Text = selectedNode["appendices"].InnerText;
            }

            XmlNode authorsXmlNode = xmlDoc.SelectSingleNode("//books/book[@isbn='" + cmbBxIsbn.SelectedItem + "']/authors");
            if (authorsXmlNode != null && authorsXmlNode.HasChildNodes)
            {
                string authors = "";
                foreach (XmlNode author in authorsXmlNode.ChildNodes)
                {
                    authors += author.Attributes["fname"].Value + " " + author.Attributes["lname"].Value;
                    if (authorsXmlNode.LastChild != author)
                        authors += Environment.NewLine;
                }
                txtBxFullName.Text = authors;
            }

            XmlNode reviewXmlNode = xmlDoc.SelectSingleNode("//books/book[@isbn='" + cmbBxIsbn.SelectedItem + "']/reviews");
            if (reviewXmlNode != null && reviewXmlNode.HasChildNodes)
            {
                string evals = "", reviewTexts = "";
                foreach (XmlNode review in reviewXmlNode.ChildNodes)
                {
                    evals += review.Attributes["eval"].Value;
                    reviewTexts += review.InnerText;
                    if (reviewXmlNode.LastChild != review)
                    {
                        evals += Environment.NewLine;
                        reviewTexts += Environment.NewLine;
                    }
                }
                txtBxEval.Text = evals;
                txtBxText.Text = reviewTexts;
            }
        }
        private void setButtonsToModify()
        {
            btnAddNode.Enabled = false;
            btnModify.Enabled = btnRemoveBook.Enabled = true;
        }
    }
}